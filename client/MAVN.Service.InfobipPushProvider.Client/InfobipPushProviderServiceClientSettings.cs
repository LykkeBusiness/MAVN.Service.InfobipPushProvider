using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.InfobipPushProvider.Client 
{
    /// <summary>
    /// InfobipPushProvider client settings.
    /// </summary>
    public class InfobipPushProviderServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
