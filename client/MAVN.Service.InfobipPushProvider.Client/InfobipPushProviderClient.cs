using Lykke.HttpClientGenerator;

namespace MAVN.Service.InfobipPushProvider.Client
{
    /// <summary>
    /// InfobipPushProvider API aggregating interface.
    /// </summary>
    public class InfobipPushProviderClient : IInfobipPushProviderClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to InfobipPushProvider Api.</summary>
        public IInfobipPushProviderApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public InfobipPushProviderClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<IInfobipPushProviderApi>();
        }
    }
}
