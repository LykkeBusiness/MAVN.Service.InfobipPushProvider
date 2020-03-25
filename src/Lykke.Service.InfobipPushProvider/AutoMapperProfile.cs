using AutoMapper;
using Lykke.Service.InfobipPushProvider.Client.Models.Requests;
using Lykke.Service.InfobipPushProvider.Client.Models.Responses;

namespace Lykke.Service.InfobipPushProvider
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SendPushNotificationRequest, Domain.SendPushNotificationModel>();

            CreateMap<Domain.SendPushNotificationResultModel, SendPushNotificationResponse>();
        }
    }
}
