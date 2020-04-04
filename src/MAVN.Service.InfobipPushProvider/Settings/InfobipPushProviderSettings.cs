using JetBrains.Annotations;

namespace MAVN.Service.InfobipPushProvider.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class InfobipPushProviderSettings
    {
        public DbSettings Db { get; set; }
    }
}
