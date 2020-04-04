namespace MAVN.Service.InfobipPushProvider.Settings
{
    public class InfobipSettings
    {
        public int TimeoutMs { get; set; }

        public int Retries { get; set; }

        public string Token { get; set; }

        public string FromSender { get; set; }

        public string ServiceUrl { get; set; }
    }
}
