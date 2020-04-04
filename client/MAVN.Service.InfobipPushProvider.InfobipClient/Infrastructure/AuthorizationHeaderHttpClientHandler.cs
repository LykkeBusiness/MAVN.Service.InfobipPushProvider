using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MAVN.Service.InfobipPushProvider.InfobipClient.Infrastructure
{
    public class AuthorizationHeaderHttpClientHandler : DelegatingHandler
    {
        private readonly string _accessToken;

        /// <inheritdoc />
        public AuthorizationHeaderHttpClientHandler(string accessToken)
        {
            _accessToken = accessToken;
        }

        /// <inheritdoc />
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.TryAddWithoutValidation("Authorization", $"App {_accessToken}");

            return base.SendAsync(request, cancellationToken);
        }
    }
}
