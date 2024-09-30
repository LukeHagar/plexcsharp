//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace LukeHagar.PlexAPI.SDK.Models.Requests
{
    using LukeHagar.PlexAPI.SDK.Utils;
    using Newtonsoft.Json;
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
        [JsonProperty("album-types")]
        AlbumTypes,
        [JsonProperty("allow_dvr")]
        AllowDvr,
        [JsonProperty("amazon-loop-debug")]
        AmazonLoopDebug,
        [JsonProperty("avod-ad-analysis")]
        AvodAdAnalysis,
        [JsonProperty("avod-new-media")]
        AvodNewMedia,
        [JsonProperty("blacklist_get_signin")]
        BlacklistGetSignin,
        [JsonProperty("boost-voices")]
        BoostVoices,
        [JsonProperty("camera_upload")]
        CameraUpload,
        [JsonProperty("client-radio-stations")]
        ClientRadioStations,
        [JsonProperty("cloudflare-turnstile-required")]
        CloudflareTurnstileRequired,
        [JsonProperty("cloudsync")]
        Cloudsync,
        [JsonProperty("collections")]
        Collections,
        [JsonProperty("comments_and_replies_push_notifications")]
        CommentsAndRepliesPushNotifications,
        [JsonProperty("community_access_plex_tv")]
        CommunityAccessPlexTv,
        [JsonProperty("companions_sonos")]
        CompanionsSonos,
        [JsonProperty("content_filter")]
        ContentFilter,
        [JsonProperty("custom-home-removal")]
        CustomHomeRemoval,
        [JsonProperty("disable_home_user_friendships")]
        DisableHomeUserFriendships,
        [JsonProperty("disable_sharing_friendships")]
        DisableSharingFriendships,
        [JsonProperty("downloads-gating")]
        DownloadsGating,
        [JsonProperty("drm_support")]
        DrmSupport,
        [JsonProperty("dvr")]
        Dvr,
        [JsonProperty("dvr-block-unsupported-countries")]
        DvrBlockUnsupportedCountries,
        [JsonProperty("epg-recent-channels")]
        EpgRecentChannels,
        [JsonProperty("exclude restrictions")]
        ExcludeRestrictions,
        [JsonProperty("federated-auth")]
        FederatedAuth,
        [JsonProperty("friend_request_push_notifications")]
        FriendRequestPushNotifications,
        [JsonProperty("grandfather-sync")]
        GrandfatherSync,
        [JsonProperty("guided-upgrade")]
        GuidedUpgrade,
        [JsonProperty("hardware_transcoding")]
        HardwareTranscoding,
        [JsonProperty("home")]
        Home,
        [JsonProperty("hwtranscode")]
        Hwtranscode,
        [JsonProperty("imagga-v2")]
        ImaggaV2,
        [JsonProperty("increase-password-complexity")]
        IncreasePasswordComplexity,
        [JsonProperty("ios14-privacy-banner")]
        Ios14PrivacyBanner,
        [JsonProperty("iterable-notification-tokens")]
        IterableNotificationTokens,
        [JsonProperty("item_clusters")]
        ItemClusters,
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
        [JsonProperty("lyrics")]
        Lyrics,
        [JsonProperty("metadata_search")]
        MetadataSearch,
        [JsonProperty("music-analysis")]
        MusicAnalysis,
        [JsonProperty("music_videos")]
        MusicVideos,
        [JsonProperty("new_plex_pass_prices")]
        NewPlexPassPrices,
        [JsonProperty("news-provider-sunset-modal")]
        NewsProviderSunsetModal,
        [JsonProperty("nominatim")]
        Nominatim,
        [JsonProperty("pass")]
        Pass,
        [JsonProperty("photos-favorites")]
        PhotosFavorites,
        [JsonProperty("photos-metadata-edition")]
        PhotosMetadataEdition,
        [JsonProperty("photosV6-edit")]
        PhotosV6Edit,
        [JsonProperty("photosV6-tv-albums")]
        PhotosV6TvAlbums,
        [JsonProperty("pms_health")]
        PmsHealth,
        [JsonProperty("premium-dashboard")]
        PremiumDashboard,
        [JsonProperty("premium_music_metadata")]
        PremiumMusicMetadata,
        [JsonProperty("radio")]
        Radio,
        [JsonProperty("rate-limit-client-token")]
        RateLimitClientToken,
        [JsonProperty("scrobbling-service-plex-tv")]
        ScrobblingServicePlexTv,
        [JsonProperty("session_bandwidth_restrictions")]
        SessionBandwidthRestrictions,
        [JsonProperty("session_kick")]
        SessionKick,
        [JsonProperty("shared_server_notification")]
        SharedServerNotification,
        [JsonProperty("shared_source_notification")]
        SharedSourceNotification,
        [JsonProperty("signin_notification")]
        SigninNotification,
        [JsonProperty("signin_with_apple")]
        SigninWithApple,
        [JsonProperty("silence-removal")]
        SilenceRemoval,
        [JsonProperty("sleep-timer")]
        SleepTimer,
        [JsonProperty("spring_serve_ad_provider")]
        SpringServeAdProvider,
        [JsonProperty("sync")]
        Sync,
        [JsonProperty("sweet-fades")]
        SweetFades,
        [JsonProperty("transcoder_cache")]
        TranscoderCache,
        [JsonProperty("trailers")]
        Trailers,
        [JsonProperty("tuner-sharing")]
        TunerSharing,
        [JsonProperty("two-factor-authentication")]
        TwoFactorAuthentication,
        [JsonProperty("unsupportedtuners")]
        Unsupportedtuners,
        [JsonProperty("upgrade-3ds2")]
        Upgrade3ds2,
        [JsonProperty("visualizers")]
        Visualizers,
        [JsonProperty("vod-schema")]
        VodSchema,
        [JsonProperty("vod_cloudflare")]
        VodCloudflare,
        [JsonProperty("volume-leveling")]
        VolumeLeveling,
        [JsonProperty("watch-together-invite")]
        WatchTogetherInvite,
        [JsonProperty("watchlist-rss")]
        WatchlistRss,
        [JsonProperty("web_server_dashboard")]
        WebServerDashboard,
        [JsonProperty("webhooks")]
        Webhooks,
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