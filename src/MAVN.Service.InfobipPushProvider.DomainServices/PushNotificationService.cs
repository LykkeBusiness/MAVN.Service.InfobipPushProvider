using System;
using System.Linq;
using System.Threading.Tasks;
using Common.Log;
using Lykke.Common.Log;
using MAVN.Service.InfobipPushProvider.Domain;
using MAVN.Service.InfobipPushProvider.Domain.Services;
using MAVN.Service.InfobipPushProvider.InfobipClient;
using MAVN.Service.InfobipPushProvider.InfobipClient.Models;
using MAVN.Service.InfobipPushProvider.InfobipClient.Models.Requests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MAVN.Service.InfobipPushProvider.DomainServices
{
    public class PushNotificationService : IPushNotificationService
    {
        private readonly string _fromSender;
        private readonly ILog _log;
        private readonly IInfobipClient _infobipClient;

        public PushNotificationService(ILogFactory logFactory, IInfobipClient infobipClient, string fromSender)
        {
            _infobipClient = infobipClient;
            _fromSender = fromSender;
            _log = logFactory.CreateLog(this);
        }

        public async Task<SendPushNotificationResultModel> SendPushNotificationAsync(SendPushNotificationModel model)
        {
            var result = new SendPushNotificationResultModel();

            // Try to send push notification via Infobip client and propagate proper audit message
            try
            {
                _log.Info("Sending push notification with Infobip...", new {model.MessageId});

                var response =
                    await _infobipClient.Api.SendPushNotificationAsync(new SendPushNotificationRequestModel
                    {
                        From = _fromSender,
                        To = new RecipientDestinationAddressTypeModel
                        {
                            PushRegistrationId = model.PushRegistrationId
                        },
                        Text = model.Message,
                        CustomPayload = model.CustomPayload?.Count == 0 ? new JObject() : JObject.Parse(JsonConvert.SerializeObject(model.CustomPayload, Formatting.Indented))
                    });

                // Valid statuses that are treated as push notification is sent
                // 0 - OK, 1 - PENDING, 3 - DELIVERED
                var validStatuses = new[] {"OK", "PENDING", "DELIVERED"};
                var errorMessage = "";

                foreach (var bulk in response.Bulks)
                {
                    if (validStatuses.All(x =>
                        string.Compare(x, bulk.Status.GroupName, StringComparison.InvariantCultureIgnoreCase) != 0))
                    {
                        _log.Error(
                            null,
                            "Could not send push notification",
                            new {model.MessageId, InfobipResponse = new {bulk.BulkId, bulk.Status}});

                        if (string.IsNullOrEmpty(errorMessage))
                            errorMessage += $"{bulk.Status.Name} - {bulk.Status.Description}";
                        else
                            errorMessage += $"{Environment.NewLine}{bulk.Status.Name} - {bulk.Status.Description}";
                    }
                }

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    result.Result = ResultCodeModel.Error;
                    result.ErrorMessage = errorMessage;

                    return result;
                }

                result.Result = ResultCodeModel.Ok;

                _log.Info("Push notification sent", new {model.MessageId});
            }
            catch (Exception e)
            {
                _log.Error(e, "Could not send push notification", new {model.MessageId});

                result.Result = ResultCodeModel.Error;
                result.ErrorMessage = e.Message;
            }

            return result;
        }
    }
}
