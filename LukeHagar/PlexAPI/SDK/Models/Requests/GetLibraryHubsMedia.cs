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
    
    public class GetLibraryHubsMedia
    {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("bitrate")]
        public int? Bitrate { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("aspectRatio")]
        public double? AspectRatio { get; set; }

        [JsonProperty("audioChannels")]
        public int? AudioChannels { get; set; }

        [JsonProperty("audioCodec")]
        public string? AudioCodec { get; set; }

        [JsonProperty("videoCodec")]
        public string? VideoCodec { get; set; }

        [JsonProperty("videoResolution")]
        public string? VideoResolution { get; set; }

        [JsonProperty("container")]
        public string? Container { get; set; }

        [JsonProperty("videoFrameRate")]
        public string? VideoFrameRate { get; set; }

        [JsonProperty("optimizedForStreaming")]
        public int? OptimizedForStreaming { get; set; }

        [JsonProperty("audioProfile")]
        public string? AudioProfile { get; set; }

        [JsonProperty("has64bitOffsets")]
        public bool? Has64bitOffsets { get; set; }

        [JsonProperty("videoProfile")]
        public string? VideoProfile { get; set; }

        [JsonProperty("Part")]
        public List<GetLibraryHubsPart>? Part { get; set; }
    }
}