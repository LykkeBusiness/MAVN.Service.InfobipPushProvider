using System.Collections.Generic;

namespace Lykke.Service.InfobipPushProvider.InfobipClient.Models.Responses
{
    public class SendPushNotificationResponseModel
    {
        public List<BulkResponseModel> Bulks { get; set; }
    }
}
