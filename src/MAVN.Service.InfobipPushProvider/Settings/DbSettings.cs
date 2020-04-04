using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.InfobipPushProvider.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
