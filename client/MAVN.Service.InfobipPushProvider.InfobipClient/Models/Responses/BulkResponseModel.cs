using MAVN.Service.InfobipPushProvider.InfobipClient.Models.Requests;

namespace MAVN.Service.InfobipPushProvider.InfobipClient.Models.Responses
{
    /// <summary>
    /// Model that represents send push notification response
    /// </summary>
    public class BulkResponseModel
    {
        /// <summary>
        /// Recipient destination address.
        /// </summary>
        public RecipientDestinationAddressTypeModel To { get; set; }

        /// <summary>
        /// Message status.
        /// </summary>
        public StatusResponseModel Status { get; set; }

        /// <summary>
        /// Number of recipients for targeted segment.
        /// </summary>
        public int MessageCount { get; set; }

        /// <summary>
        /// The ID which uniquely identifies the request.
        /// </summary>
        public string BulkId { get; set; }
    }
}
