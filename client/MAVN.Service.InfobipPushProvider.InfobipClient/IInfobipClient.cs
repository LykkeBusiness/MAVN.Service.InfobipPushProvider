namespace MAVN.Service.InfobipPushProvider.InfobipClient
{
    /// <summary>
    /// Infobip API client
    /// </summary>
    public interface IInfobipClient
    {
        /// <summary>
        /// Infobip service provider URL
        /// </summary>
        string ServiceUrl { get; }

        /// <summary>
        /// Infobip service connection timeout in milliseconds
        /// </summary>
        int TimeoutMs { get; }

        /// <summary>
        /// Number of retries that are made before request fails
        /// </summary>
        int Retries { get; }

        /// <summary>
        /// Access token that will be used for authentication with API
        /// </summary>
        string AccessToken { get; }

        /// <summary>
        /// API interface to deal with Infobip
        /// </summary>
        IInfobip Api { get; }
    }
}
