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
    using LukeHagar.PlexAPI.SDK.Models.Requests;
    using LukeHagar.PlexAPI.SDK.Utils;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Logged in user details
    /// </summary>
    public class GetTokenDetailsUserPlexAccount
    {

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("adsConsent", NullValueHandling = NullValueHandling.Include)]
        public bool? AdsConsent { get; set; }

        [JsonProperty("adsConsentReminderAt", NullValueHandling = NullValueHandling.Include)]
        public long? AdsConsentReminderAt { get; set; }

        [JsonProperty("adsConsentSetAt", NullValueHandling = NullValueHandling.Include)]
        public long? AdsConsentSetAt { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("anonymous")]
        public bool? Anonymous { get; set; } = false;

        /// <summary>
        /// The account token
        /// </summary>
        [JsonProperty("authToken")]
        public string AuthToken { get; set; } = default!;

        /// <summary>
        /// If the two-factor authentication backup codes have been created
        /// </summary>
        [JsonProperty("backupCodesCreated")]
        public bool? BackupCodesCreated { get; set; } = false;

        /// <summary>
        /// If the account has been confirmed
        /// </summary>
        [JsonProperty("confirmed")]
        public bool? Confirmed { get; set; } = false;

        /// <summary>
        /// The account country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; } = default!;

        /// <summary>
        /// The account email address
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// If login with email only is enabled
        /// </summary>
        [JsonProperty("emailOnlyAuth")]
        public bool? EmailOnlyAuth { get; set; } = false;

        /// <summary>
        /// If experimental features are enabled
        /// </summary>
        [JsonProperty("experimentalFeatures")]
        public bool? ExperimentalFeatures { get; set; } = false;

        /// <summary>
        /// Your account full name
        /// </summary>
        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; } = default!;

        /// <summary>
        /// List of devices your allowed to use with this account
        /// </summary>
        [JsonProperty("entitlements")]
        public List<string> Entitlements { get; set; } = default!;

        /// <summary>
        /// If the account is a Plex Home guest user
        /// </summary>
        [JsonProperty("guest")]
        public bool? Guest { get; set; } = false;

        /// <summary>
        /// If the account has a password
        /// </summary>
        [JsonProperty("hasPassword")]
        public bool? HasPassword { get; set; } = true;

        /// <summary>
        /// If the account is a Plex Home user
        /// </summary>
        [JsonProperty("home")]
        public bool? Home { get; set; } = false;

        /// <summary>
        /// If the account is the Plex Home admin
        /// </summary>
        [JsonProperty("homeAdmin")]
        public bool? HomeAdmin { get; set; } = false;

        /// <summary>
        /// The number of accounts in the Plex Home
        /// </summary>
        [JsonProperty("homeSize")]
        public int HomeSize { get; set; } = default!;

        /// <summary>
        /// The Plex account ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Unix epoch datetime in seconds
        /// </summary>
        [JsonProperty("joinedAt")]
        public long JoinedAt { get; set; } = default!;

        /// <summary>
        /// The account locale
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Include)]
        public string? Locale { get; set; }

        /// <summary>
        /// If you are subscribed to the Plex newsletter
        /// </summary>
        [JsonProperty("mailingListActive")]
        public bool? MailingListActive { get; set; } = false;

        /// <summary>
        /// Your current mailing list status (active or unsubscribed)
        /// </summary>
        [JsonProperty("mailingListStatus")]
        public MailingListStatus MailingListStatus { get; set; } = default!;

        /// <summary>
        /// The maximum number of accounts allowed in the Plex Home
        /// </summary>
        [JsonProperty("maxHomeSize")]
        public int MaxHomeSize { get; set; } = default!;

        /// <summary>
        /// [Might be removed] The hashed Plex Home PIN 
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("pin")]
        public string? Pin { get; set; }

        [JsonProperty("profile")]
        public UserProfile Profile { get; set; } = default!;

        /// <summary>
        /// If the account has a Plex Home PIN enabled
        /// </summary>
        [JsonProperty("protected")]
        public bool? Protected { get; set; } = false;

        /// <summary>
        /// Unix epoch datetime in seconds
        /// </summary>
        [JsonProperty("rememberExpiresAt")]
        public long RememberExpiresAt { get; set; } = default!;

        /// <summary>
        /// If the account is a Plex Home managed user
        /// </summary>
        [JsonProperty("restricted")]
        public bool? Restricted { get; set; } = false;

        /// <summary>
        /// [Might be removed] List of account roles. Plexpass membership listed here
        /// </summary>
        [JsonProperty("roles")]
        public List<string>? Roles { get; set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("scrobbleTypes")]
        public string ScrobbleTypes { get; set; } = default!;

        [JsonProperty("services")]
        public List<Services> Services { get; set; } = default!;

        /// <summary>
        /// If the account’s Plex Pass subscription is active
        /// </summary>
        [JsonProperty("subscription")]
        public Subscription Subscription { get; set; } = default!;

        /// <summary>
        /// Description of the Plex Pass subscription
        /// </summary>
        [JsonProperty("subscriptionDescription", NullValueHandling = NullValueHandling.Include)]
        public string? SubscriptionDescription { get; set; }

        [JsonProperty("subscriptions")]
        public List<GetTokenDetailsSubscription>? Subscriptions { get; set; }

        /// <summary>
        /// URL of the account thumbnail
        /// </summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; } = default!;

        /// <summary>
        /// The title of the account (username or friendly name)
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// If two-factor authentication is enabled
        /// </summary>
        [JsonProperty("twoFactorEnabled")]
        public bool? TwoFactorEnabled { get; set; } = false;

        /// <summary>
        /// The account username
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; } = default!;

        /// <summary>
        /// The account UUID
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; } = default!;

        [JsonProperty("attributionPartner", NullValueHandling = NullValueHandling.Include)]
        public string? AttributionPartner { get; set; }
    }
}