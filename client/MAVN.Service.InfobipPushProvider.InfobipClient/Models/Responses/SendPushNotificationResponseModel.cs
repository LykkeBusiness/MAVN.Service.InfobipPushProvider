using System.Collections.Generic;

namespace MAVN.Service.InfobipPushProvider.InfobipClient.Models.Responses
{
    public class SendPushNotificationResponseModel
    {
        public List<BulkResponseModel> Bulks { get; set; }
    }
}
