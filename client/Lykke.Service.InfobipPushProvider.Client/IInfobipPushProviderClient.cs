using JetBrains.Annotations;

namespace Lykke.Service.InfobipPushProvider.Client
{
    /// <summary>
    /// InfobipPushProvider client interface.
    /// </summary>
    [PublicAPI]
    public interface IInfobipPushProviderClient
    {
        /// <summary>Application Api interface</summary>
        IInfobipPushProviderApi Api { get; }
    }
}
