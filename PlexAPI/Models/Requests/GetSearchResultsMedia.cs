
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class GetSearchResultsMedia
    {

        [JsonProperty("id")]
        public double? Id { get; set; }

        [JsonProperty("duration")]
        public double? Duration { get; set; }

        [JsonProperty("bitrate")]
        public double? Bitrate { get; set; }

        [JsonProperty("width")]
        public double? Width { get; set; }

        [JsonProperty("height")]
        public double? Height { get; set; }

        [JsonProperty("aspectRatio")]
        public double? AspectRatio { get; set; }

        [JsonProperty("audioChannels")]
        public double? AudioChannels { get; set; }

        [JsonProperty("audioCodec")]
        public string? AudioCodec { get; set; }

        [JsonProperty("videoCodec")]
        public string? VideoCodec { get; set; }

        [JsonProperty("videoResolution")]
        public double? VideoResolution { get; set; }

        [JsonProperty("container")]
        public string? Container { get; set; }

        [JsonProperty("videoFrameRate")]
        public string? VideoFrameRate { get; set; }

        [JsonProperty("audioProfile")]
        public string? AudioProfile { get; set; }

        [JsonProperty("videoProfile")]
        public string? VideoProfile { get; set; }

        [JsonProperty("Part")]
        public List<GetSearchResultsPart>? Part { get; set; }
    }
}