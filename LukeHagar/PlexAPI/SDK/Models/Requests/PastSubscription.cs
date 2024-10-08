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
    
    public class PastSubscription
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string? Id { get; set; }

        [JsonProperty("mode", NullValueHandling = NullValueHandling.Include)]
        public string? Mode { get; set; }

        [JsonProperty("renewsAt", NullValueHandling = NullValueHandling.Include)]
        public long? RenewsAt { get; set; }

        [JsonProperty("endsAt", NullValueHandling = NullValueHandling.Include)]
        public long? EndsAt { get; set; }

        [JsonProperty("canceled")]
        public bool? Canceled { get; set; } = false;

        [JsonProperty("gracePeriod")]
        public bool? GracePeriod { get; set; } = false;

        [JsonProperty("onHold")]
        public bool? OnHold { get; set; } = false;

        [JsonProperty("canReactivate")]
        public bool? CanReactivate { get; set; } = false;

        [JsonProperty("canUpgrade")]
        public bool? CanUpgrade { get; set; } = false;

        [JsonProperty("canDowngrade")]
        public bool? CanDowngrade { get; set; } = false;

        [JsonProperty("canConvert")]
        public bool? CanConvert { get; set; } = false;

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("transfer", NullValueHandling = NullValueHandling.Include)]
        public string? Transfer { get; set; }

        [JsonProperty("state")]
        public PostUsersSignInDataState State { get; set; } = default!;

        [JsonProperty("billing")]
        public Billing Billing { get; set; } = default!;
    }
}