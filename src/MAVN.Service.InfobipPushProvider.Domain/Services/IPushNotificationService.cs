using System.Threading.Tasks;

namespace MAVN.Service.InfobipPushProvider.Domain.Services
{
    public interface IPushNotificationService
    {
        Task<SendPushNotificationResultModel> SendPushNotificationAsync(SendPushNotificationModel model);
    }
}
