using System.Threading.Tasks;
using Lykke.Service.InfobipPushProvider.InfobipClient.Models.Requests;
using Lykke.Service.InfobipPushProvider.InfobipClient.Models.Responses;
using Refit;

namespace Lykke.Service.InfobipPushProvider.InfobipClient
{
    /// <summary>
    /// Interface that describes Infobip push notification client access
    /// </summary>
    public interface IInfobip
    {
        /// <summary>
        /// Infobip endpoint that is used to send push notification
        /// </summary>
        /// <param name="requestModel">Push notification data</param>
        /// <returns></returns>
        [Post("/push/2/message/single")]
        Task<SendPushNotificationResponseModel> SendPushNotificationAsync(
            [Body] SendPushNotificationRequestModel requestModel);
    }
}
