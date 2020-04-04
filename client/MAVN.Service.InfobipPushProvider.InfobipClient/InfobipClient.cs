using System;
using Lykke.HttpClientGenerator.Infrastructure;
using Lykke.HttpClientGenerator.Retries;
using MAVN.Service.InfobipPushProvider.InfobipClient.Infrastructure;

namespace MAVN.Service.InfobipPushProvider.InfobipClient
{
    /// <summary>
    /// Infobip API client
    /// </summary>
    public class InfobipClient : IInfobipClient
    {
        /// <summary>
        /// Infobip service provider URL
        /// </summary>
        public string ServiceUrl { get; }

        /// <summary>
        /// Infobip service connection timeout in milliseconds
        /// </summary>
        public int TimeoutMs { get; }

        /// <summary>
        /// Number of retries that are made before request fails
        /// </summary>
        public int Retries { get; }

        /// <summary>
        /// Access token that will be used for authentication with API
        /// </summary>
        public string AccessToken { get; }

        /// <summary>
        /// API interface to deal with Infobip
        /// </summary>
        public IInfobip Api { get; private set; }

        /// <summary>
        /// Infobip client constructor
        /// </summary>
        /// <param name="serviceUrl">Url of the Infobip service</param>
        /// <param name="timeoutMs">Client timeout in milliseconds</param>
        /// <param name="retries">Number of retries per request that should be executed before request fails</param>
        /// <param name="accessToken">Access token that will be used for authentication with API</param>
        public InfobipClient(string serviceUrl, int timeoutMs, int retries, string accessToken)
        {
            ServiceUrl = serviceUrl;
            TimeoutMs = timeoutMs;
            Retries = retries;
            AccessToken = accessToken;

            InitializeClient();
        }

        private void InitializeClient()
        {
            var clientBuilder = HttpClientGenerator.HttpClientGenerator.BuildForUrl(ServiceUrl)
                .WithAdditionalCallsWrapper(new ExceptionHandlerCallsWrapper())
                .WithRetriesStrategy(new LinearRetryStrategy(TimeSpan.FromMilliseconds(TimeoutMs), Retries))
                .WithAdditionalDelegatingHandler(new AuthorizationHeaderHttpClientHandler(AccessToken));

            Api = clientBuilder.Create().Generate<IInfobip>();
        }
    }
}
