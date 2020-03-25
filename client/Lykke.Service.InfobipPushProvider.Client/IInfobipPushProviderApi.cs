using System.Threading.Tasks;
using JetBrains.Annotations;
using Lykke.Service.InfobipPushProvider.Client.Models.Requests;
using Lykke.Service.InfobipPushProvider.Client.Models.Responses;
using Refit;

namespace Lykke.Service.InfobipPushProvider.Client
{
    /// <summary>
    /// InfobipPushProvider client API interface.
    /// </summary>
    [PublicAPI]
    public interface IInfobipPushProviderApi
    {
        /// <summary>
        /// Send push notification
        /// </summary>
        /// <param name="model">Data to use when sending push notification</param>
        /// <returns>Response on push notification</returns>
        [Post("/api/pushNotification")]
        Task<SendPushNotificationResponse> SendPushNotificationAsync(SendPushNotificationRequest model);
    }
}
