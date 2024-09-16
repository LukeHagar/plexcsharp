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
    using System.Collections.Generic;
    
    public class GetAllLibrariesDirectory
    {

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("composite")]
        public string? Composite { get; set; }

        [JsonProperty("filters")]
        public bool? Filters { get; set; }

        [JsonProperty("refreshing")]
        public bool? Refreshing { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("agent")]
        public string? Agent { get; set; }

        [JsonProperty("scanner")]
        public string? Scanner { get; set; }

        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Unix epoch datetime
        /// </summary>
        [JsonProperty("updatedAt")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// Unix epoch datetime
        /// </summary>
        [JsonProperty("createdAt")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Unix epoch datetime
        /// </summary>
        [JsonProperty("scannedAt")]
        public long? ScannedAt { get; set; }

        [JsonProperty("content")]
        public bool? Content { get; set; }

        [JsonProperty("directory")]
        public bool? Directory { get; set; }

        [JsonProperty("contentChangedAt")]
        public int? ContentChangedAt { get; set; }

        [JsonProperty("hidden")]
        public int? Hidden { get; set; }

        [JsonProperty("Location")]
        public List<Location>? Location { get; set; }
    }
}