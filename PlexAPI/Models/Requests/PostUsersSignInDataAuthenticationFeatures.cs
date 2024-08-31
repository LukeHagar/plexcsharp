//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using Newtonsoft.Json;
    using PlexAPI.Utils;
    using System;
    
    public enum PostUsersSignInDataAuthenticationFeatures
    {
        [JsonProperty("Android - Dolby Vision")]
        AndroidDolbyVision,
        [JsonProperty("Android - PiP")]
        AndroidPiP,
        [JsonProperty("CU Sunset")]
        CUSunset,
        [JsonProperty("HRK_enable_EUR")]
        HRKEnableEUR,
        [JsonProperty("TREBLE-show-features")]
        TREBLEShowFeatures,
        [JsonProperty("ad-countdown-timer")]
        AdCountdownTimer,
        [JsonProperty("adaptive_bitrate")]
        AdaptiveBitrate,
        [JsonProperty("amazon-loop-debug")]
        AmazonLoopDebug,
        [JsonProperty("avod-ad-analysis")]
        AvodAdAnalysis,
        [JsonProperty("avod-new-media")]
        AvodNewMedia,
        [JsonProperty("blacklist_get_signin")]
        BlacklistGetSignin,
        [JsonProperty("client-radio-stations")]
        ClientRadioStations,
        [JsonProperty("cloudflare-turnstile-required")]
        CloudflareTurnstileRequired,
        [JsonProperty("collections")]
        Collections,
        [JsonProperty("comments_and_replies_push_notifications")]
        CommentsAndRepliesPushNotifications,
        [JsonProperty("community_access_plex_tv")]
        CommunityAccessPlexTv,
        [JsonProperty("companions_sonos")]
        CompanionsSonos,
        [JsonProperty("custom-home-removal")]
        CustomHomeRemoval,
        [JsonProperty("disable_home_user_friendships")]
        DisableHomeUserFriendships,
        [JsonProperty("disable_sharing_friendships")]
        DisableSharingFriendships,
        [JsonProperty("drm_support")]
        DrmSupport,
        [JsonProperty("exclude restrictions")]
        ExcludeRestrictions,
        [JsonProperty("federated-auth")]
        FederatedAuth,
        [JsonProperty("friend_request_push_notifications")]
        FriendRequestPushNotifications,
        [JsonProperty("guided-upgrade")]
        GuidedUpgrade,
        [JsonProperty("home")]
        Home,
        [JsonProperty("increase-password-complexity")]
        IncreasePasswordComplexity,
        [JsonProperty("ios14-privacy-banner")]
        Ios14PrivacyBanner,
        [JsonProperty("iterable-notification-tokens")]
        IterableNotificationTokens,
        [JsonProperty("keep-payment-method")]
        KeepPaymentMethod,
        [JsonProperty("kevin-bacon")]
        KevinBacon,
        [JsonProperty("korea-consent")]
        KoreaConsent,
        [JsonProperty("le_isrg_root_x1")]
        LeIsrgRootX1,
        [JsonProperty("lets_encrypt")]
        LetsEncrypt,
        [JsonProperty("lightning-dvr-pivot")]
        LightningDvrPivot,
        [JsonProperty("live-tv-support-incomplete-segments")]
        LiveTvSupportIncompleteSegments,
        [JsonProperty("livetv")]
        Livetv,
        [JsonProperty("metadata_search")]
        MetadataSearch,
        [JsonProperty("new_plex_pass_prices")]
        NewPlexPassPrices,
        [JsonProperty("news-provider-sunset-modal")]
        NewsProviderSunsetModal,
        [JsonProperty("photos-favorites")]
        PhotosFavorites,
        [JsonProperty("photos-metadata-edition")]
        PhotosMetadataEdition,
        [JsonProperty("pms_health")]
        PmsHealth,
        [JsonProperty("radio")]
        Radio,
        [JsonProperty("rate-limit-client-token")]
        RateLimitClientToken,
        [JsonProperty("scrobbling-service-plex-tv")]
        ScrobblingServicePlexTv,
        [JsonProperty("shared_server_notification")]
        SharedServerNotification,
        [JsonProperty("shared_source_notification")]
        SharedSourceNotification,
        [JsonProperty("signin_with_apple")]
        SigninWithApple,
        [JsonProperty("spring_serve_ad_provider")]
        SpringServeAdProvider,
        [JsonProperty("transcoder_cache")]
        TranscoderCache,
        [JsonProperty("tuner-sharing")]
        TunerSharing,
        [JsonProperty("two-factor-authentication")]
        TwoFactorAuthentication,
        [JsonProperty("unsupportedtuners")]
        Unsupportedtuners,
        [JsonProperty("upgrade-3ds2")]
        Upgrade3ds2,
        [JsonProperty("vod-schema")]
        VodSchema,
        [JsonProperty("vod_cloudflare")]
        VodCloudflare,
        [JsonProperty("watch-together-invite")]
        WatchTogetherInvite,
        [JsonProperty("web_server_dashboard")]
        WebServerDashboard,
    }

    public static class PostUsersSignInDataAuthenticationFeaturesExtension
    {
        public static string Value(this PostUsersSignInDataAuthenticationFeatures value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PostUsersSignInDataAuthenticationFeatures ToEnum(this string value)
        {
            foreach(var field in typeof(PostUsersSignInDataAuthenticationFeatures).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is PostUsersSignInDataAuthenticationFeatures)
                    {
                        return (PostUsersSignInDataAuthenticationFeatures)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PostUsersSignInDataAuthenticationFeatures");
        }
    }

}