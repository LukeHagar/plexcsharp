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
    
    public class Part
    {

        [JsonProperty("id")]
        public int Id { get; set; } = default!;

        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("file")]
        public string File { get; set; } = default!;

        [JsonProperty("size")]
        public long Size { get; set; } = default!;

        /// <summary>
        /// The container format of the media file.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("container")]
        public string Container { get; set; } = default!;

        [JsonProperty("audioProfile")]
        public string? AudioProfile { get; set; }

        [JsonProperty("has64bitOffsets")]
        public bool? Has64bitOffsets { get; set; }

        [JsonProperty("optimizedForStreaming")]
        public bool? OptimizedForStreaming { get; set; }

        [JsonProperty("videoProfile")]
        public string? VideoProfile { get; set; }

        [JsonProperty("indexes")]
        public string? Indexes { get; set; }

        [JsonProperty("hasThumbnail")]
        public HasThumbnail? HasThumbnail { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.HasThumbnail.False;

        [JsonProperty("Stream")]
        public List<Stream>? Stream { get; set; }
    }
}