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
    
    public class GetBandwidthStatisticsAccount
    {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("defaultAudioLanguage")]
        public string? DefaultAudioLanguage { get; set; }

        [JsonProperty("autoSelectAudio")]
        public bool? AutoSelectAudio { get; set; }

        [JsonProperty("defaultSubtitleLanguage")]
        public string? DefaultSubtitleLanguage { get; set; }

        [JsonProperty("subtitleMode")]
        public int? SubtitleMode { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }
    }
}