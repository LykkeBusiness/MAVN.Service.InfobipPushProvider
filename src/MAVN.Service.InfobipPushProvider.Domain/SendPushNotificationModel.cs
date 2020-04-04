using System.Collections.Generic;

namespace MAVN.Service.InfobipPushProvider.Domain
{
    public class SendPushNotificationModel
    {
        public string MessageId { get; set; }

        public string PushRegistrationId { get; set; }

        public string Message { get; set; }

        public Dictionary<string, string> CustomPayload { get; set; }
    }
}
