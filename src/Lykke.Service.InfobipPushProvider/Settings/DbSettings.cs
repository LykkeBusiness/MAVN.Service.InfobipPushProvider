using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.InfobipPushProvider.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
