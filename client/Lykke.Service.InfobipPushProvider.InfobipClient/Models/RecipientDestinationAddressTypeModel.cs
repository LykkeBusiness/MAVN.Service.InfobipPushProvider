using Newtonsoft.Json;

namespace Lykke.Service.InfobipPushProvider.InfobipClient.Models
{
    /// <summary>
    /// Recipient destination address type
    /// </summary>
    public class RecipientDestinationAddressTypeModel
    {
        /// <summary>
        /// Push Registration Id is unique ID which identifies application instance and specific device
        /// </summary>
        [JsonProperty("pushRegistrationId")]
        public string PushRegistrationId { get; set; }
    }
}
