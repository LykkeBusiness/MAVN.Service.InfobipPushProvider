using Newtonsoft.Json;

namespace MAVN.Service.InfobipPushProvider.InfobipClient.Models.Requests
{
    /// <summary>
    /// Model used to send push notification
    /// </summary>
    public class SendPushNotificationRequestModel
    {
        /// <summary>
        /// PUSH Application Code you are using to send messages.
        /// Application Code is the application identifier which links your mobile application
        /// to the application profile created in Infobip Platform.
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// Recipient destination address
        /// </summary>
        [JsonProperty("to")]
        public RecipientDestinationAddressTypeModel To { get; set; }

        /// <summary>
        /// Text of the message that will be sent
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        ///// <summary>
        ///// Used for scheduled Push notifications. Message will be sent at scheduled time.
        ///// </summary>
        //public DateTime SendAt { get; set; }

        /// <summary>
        /// Additional data that can be delivered with the Push message. Must be formatted as JSON object
        /// </summary>
        [JsonProperty("customPayload")]
        public object CustomPayload { get; set; }

        ///// <summary>
        ///// Details on notification options
        ///// </summary>
        //[JsonProperty("notificationOptions")]
        //public NotificationOptionRequestModel NotificationOptionsRequest { get; set; }

        ///// <summary>
        ///// The message validity period.
        ///// Unless specified differently in validityPeriodTimeUnit, it is expressed in hours.
        ///// When the period expires, it will not be allowed for the message to be sent or message will be canceled if it's pending in Cloud (APNS or FCM).
        ///// Default value 48h. Minimum value is 30 sec. Maximum value is 72h.
        ///// </summary>
        //[JsonProperty("validityPeriod")]
        //public int ValidityPeriod { get; set; }

        ///// <summary>
        ///// The URL on your callback server on which the Delivery report will be sent
        ///// </summary>
        //[JsonProperty("notifyUrl")]
        //public string NotifyUrl { get; set; }

        ///// <summary>
        ///// Preferred Delivery report content type.
        ///// Supported content types: application/json, application/xml.
        ///// </summary>
        //[JsonProperty("notifyContentType")]
        //public string NotifyContentType { get; set; }

        ///// <summary>
        ///// Additional client's data that will be sent on the notifyUrl.
        ///// The maximum value is 200 characters.
        ///// </summary>
        //[JsonProperty("callbackData")]
        //public string CallbackData { get; set; }

        ///// <summary>
        ///// Set to true to only send messages to push devices which are marked as primary devices.
        ///// By default, messages will be sent to all targeted devices, including both primary and non-primary.
        ///// </summary>
        //[JsonProperty("targetOnlyPrimaryDevices")]
        //public bool TargetOnlyPrimaryDevices { get; set; }
    }
}
