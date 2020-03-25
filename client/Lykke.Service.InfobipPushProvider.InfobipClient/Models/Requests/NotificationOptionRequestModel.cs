using Newtonsoft.Json;

namespace Lykke.Service.InfobipPushProvider.InfobipClient.Models.Requests
{
    /// <summary>
    /// Different options on how to alert the user when PUSH message is received
    /// </summary>
    public class NotificationOptionRequestModel
    {
        /// <summary>
        /// Notification vibration (Android only)
        /// Default = true
        /// </summary>
        [JsonProperty("vibrationEnabled")]
        public bool VibrationEnabled { get; set; }

        /// <summary>
        /// Sound when notification arrives on a device
        /// Default = true
        /// </summary>
        [JsonProperty("soundEnabled")]
        public bool SoundEnabled { get; set; }

        /// <summary>
        /// Name of the custom sound played when notification arrives on a device.
        /// File should be located in the app with max 30 seconds length.
        /// File extension is required for iOS and optional for Android.
        /// For custom sound to be played soundEnabled shouldn't be false
        /// </summary>
        [JsonProperty("soundName")]
        public string SoundName { get; set; }

        /// <summary>
        /// Badge counter (iOS only)
        /// Default = true
        /// </summary>
        [JsonProperty("badge")]
        public int Badge { get; set; }

        /// <summary>
        /// URL of the image displayed in the notification.
        /// Rich push notifications are available on devices with iOS 10 and Android 4.1.+.
        /// Supported on iOS since MM SDK version 2.5.8. Supported on Android since MM SDK version 1.6.4.
        /// </summary>
        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// Category id for actionable notification.
        /// Supported on Android since MM SDK version 1.6.16.
        /// Supported on iOS since MM SDK version 2.6.9.
        /// Predefined category ids: mm_accept_decline - Accept & Decline button actions.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Possible values: MODAL, BANNER.
        /// Set to MODAL to use in app dialog for actionable message, or BANNER to show a standard banner view.
        /// MODAL is supported on iOS from 3.6.0, on Android from 1.13.0 and on Cordova from 0.7.0.
        /// BANNER is supported from iOS 5.0.0, Android 2.0.0 and Cordova 1.0.0
        /// </summary>
        [JsonProperty("inAppStyle")]
        public string InAppStyle { get; set; }

        /// <summary>
        /// Set to true to send silent push message.
        /// Such messages aren't displayed on device lock screen and in the notification center.
        /// Silent messages can be used to deliver custom data to your mobile application or to trigger an in-app notification.
        /// </summary>
        [JsonProperty("isSilent")]
        public bool IsSilent { get; set; }

        /// <summary>
        /// Notification title displayed within notification.
        /// Requires iOS 10+ or Android 4.1+ (may depend on Android custom firmware)
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
