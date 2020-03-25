using System.Threading.Tasks;

namespace Lykke.Service.InfobipPushProvider.Domain.Services
{
    public interface IPushNotificationService
    {
        Task<SendPushNotificationResultModel> SendPushNotificationAsync(SendPushNotificationModel model);
    }
}
