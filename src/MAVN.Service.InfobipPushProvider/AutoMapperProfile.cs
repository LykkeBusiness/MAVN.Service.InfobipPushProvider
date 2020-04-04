using AutoMapper;
using MAVN.Service.InfobipPushProvider.Client.Models.Requests;
using MAVN.Service.InfobipPushProvider.Client.Models.Responses;

namespace MAVN.Service.InfobipPushProvider
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
