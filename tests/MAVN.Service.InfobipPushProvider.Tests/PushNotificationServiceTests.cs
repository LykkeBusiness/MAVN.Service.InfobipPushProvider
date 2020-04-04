using System.Threading.Tasks;
using AutoFixture;
using Lykke.Logs;
using MAVN.Service.InfobipPushProvider.Domain;
using MAVN.Service.InfobipPushProvider.DomainServices;
using MAVN.Service.InfobipPushProvider.InfobipClient;
using MAVN.Service.InfobipPushProvider.InfobipClient.Models.Requests;
using MAVN.Service.InfobipPushProvider.InfobipClient.Models.Responses;
using Moq;
using Xunit;

namespace MAVN.Service.InfobipPushProvider.Tests
{
    public class PushNotificationServiceTests
    {
        private readonly Fixture _fixture = new Fixture();
        private readonly Mock<IInfobipClient> _infobipClientMock = new Mock<IInfobipClient>();
        private readonly PushNotificationService _service;

        public PushNotificationServiceTests()
        {
            _service = new PushNotificationService(EmptyLogFactory.Instance, _infobipClientMock.Object, "");
        }

        [Fact]
        public async Task
            When_Send_Push_Notification_Async_Is_Executed_Expect_That_Infobip_Client_Send_Push_Notification_Async_Is_Called()
        {
            _infobipClientMock.Setup(x => x.Api.SendPushNotificationAsync(It.IsAny<SendPushNotificationRequestModel>()))
                .Returns(Task.FromResult(_fixture.Build<SendPushNotificationResponseModel>().Create()));

            await _service.SendPushNotificationAsync(_fixture.Build<SendPushNotificationModel>().Create());

            _infobipClientMock.Verify(
                x => x.Api.SendPushNotificationAsync(It.IsAny<SendPushNotificationRequestModel>()), Times.Once);
        }
    }
}
