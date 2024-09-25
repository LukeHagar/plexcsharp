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
    
    public class Media
    {

        [JsonProperty("id")]
        public int Id { get; set; } = default!;

        [JsonProperty("duration")]
        public int Duration { get; set; } = default!;

        [JsonProperty("bitrate")]
        public int Bitrate { get; set; } = default!;

        [JsonProperty("width")]
        public int Width { get; set; } = default!;

        [JsonProperty("height")]
        public int Height { get; set; } = default!;

        [JsonProperty("aspectRatio")]
        public double AspectRatio { get; set; } = default!;

        [JsonProperty("audioProfile")]
        public string? AudioProfile { get; set; }

        [JsonProperty("audioChannels")]
        public int AudioChannels { get; set; } = default!;

        [JsonProperty("audioCodec")]
        public string AudioCodec { get; set; } = default!;

        [JsonProperty("videoCodec")]
        public string VideoCodec { get; set; } = default!;

        [JsonProperty("videoResolution")]
        public string VideoResolution { get; set; } = default!;

        [JsonProperty("container")]
        public string Container { get; set; } = default!;

        [JsonProperty("videoFrameRate")]
        public string VideoFrameRate { get; set; } = default!;

        [JsonProperty("videoProfile")]
        public string VideoProfile { get; set; } = default!;

        [JsonProperty("hasVoiceActivity")]
        public bool? HasVoiceActivity { get; set; }

        [JsonProperty("optimizedForStreaming")]
        public OptimizedForStreaming? OptimizedForStreaming { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.OptimizedForStreaming.Disable;

        [JsonProperty("has64bitOffsets")]
        public bool? Has64bitOffsets { get; set; }

        [JsonProperty("Part")]
        public List<Part> Part { get; set; } = default!;
    }
}