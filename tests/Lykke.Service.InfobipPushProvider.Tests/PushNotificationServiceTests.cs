using System.Threading.Tasks;
using AutoFixture;
using Lykke.Logs;
using Lykke.Service.InfobipPushProvider.Domain;
using Lykke.Service.InfobipPushProvider.DomainServices;
using Lykke.Service.InfobipPushProvider.InfobipClient;
using Lykke.Service.InfobipPushProvider.InfobipClient.Models.Requests;
using Lykke.Service.InfobipPushProvider.InfobipClient.Models.Responses;
using Moq;
using Xunit;

namespace Lykke.Service.InfobipPushProvider.Tests
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
