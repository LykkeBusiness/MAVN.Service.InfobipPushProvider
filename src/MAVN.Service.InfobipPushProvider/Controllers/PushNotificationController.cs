using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using MAVN.Service.InfobipPushProvider.Client;
using MAVN.Service.InfobipPushProvider.Client.Models.Requests;
using MAVN.Service.InfobipPushProvider.Client.Models.Responses;
using MAVN.Service.InfobipPushProvider.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace MAVN.Service.InfobipPushProvider.Controllers
{
    [Route("/api/")]
    [ApiController]
    public class PushNotificationController : Controller, IInfobipPushProviderApi
    {
        private readonly IPushNotificationService _pushNotificationService;
        private readonly IMapper _mapper;

        public PushNotificationController(IPushNotificationService pushNotificationService, IMapper mapper)
        {
            _pushNotificationService = pushNotificationService;
            _mapper = mapper;
        }

        /// <summary>
        /// Send push notification
        /// </summary>
        /// <param name="model">Data to use when sending push notification</param>
        /// <returns>Response on push notification</returns>
        [HttpPost("pushNotification")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<SendPushNotificationResponse> SendPushNotificationAsync(SendPushNotificationRequest model)
        {
            var result = await _pushNotificationService.SendPushNotificationAsync(
                _mapper.Map<Domain.SendPushNotificationModel>(model));

            return _mapper.Map<SendPushNotificationResponse>(result);
        }
    }
}
