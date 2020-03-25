using JetBrains.Annotations;

namespace Lykke.Service.InfobipPushProvider.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class InfobipPushProviderSettings
    {
        public DbSettings Db { get; set; }
    }
}
