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
    using LukeHagar.PlexAPI.SDK.Models.Components;
    using LukeHagar.PlexAPI.SDK.Models.Requests;
    using LukeHagar.PlexAPI.SDK.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class GetMediaMetaDataMedia
    {

        /// <summary>
        /// Unique media identifier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Duration of the media in milliseconds.
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Bitrate in bits per second.
        /// </summary>
        [JsonProperty("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Video width in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Video height in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Aspect ratio of the video.
        /// </summary>
        [JsonProperty("aspectRatio")]
        public float? AspectRatio { get; set; }

        /// <summary>
        /// Number of audio channels.
        /// </summary>
        [JsonProperty("audioChannels")]
        public int? AudioChannels { get; set; }

        [JsonProperty("displayOffset")]
        public int? DisplayOffset { get; set; }

        /// <summary>
        /// Audio codec used.
        /// </summary>
        [JsonProperty("audioCodec")]
        public string? AudioCodec { get; set; }

        /// <summary>
        /// Video codec used.
        /// </summary>
        [JsonProperty("videoCodec")]
        public string? VideoCodec { get; set; }

        /// <summary>
        /// Video resolution (e.g., 4k).
        /// </summary>
        [JsonProperty("videoResolution")]
        public string? VideoResolution { get; set; }

        /// <summary>
        /// File container type.
        /// </summary>
        [JsonProperty("container")]
        public string? Container { get; set; }

        /// <summary>
        /// Frame rate of the video. Values found include NTSC, PAL, 24p<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("videoFrameRate")]
        public string? VideoFrameRate { get; set; }

        /// <summary>
        /// Video profile (e.g., main 10).
        /// </summary>
        [JsonProperty("videoProfile")]
        public string? VideoProfile { get; set; }

        /// <summary>
        /// Indicates whether voice activity is detected.
        /// </summary>
        [JsonProperty("hasVoiceActivity")]
        public bool? HasVoiceActivity { get; set; }

        /// <summary>
        /// The audio profile used for the media (e.g., DTS, Dolby Digital, etc.).
        /// </summary>
        [JsonProperty("audioProfile")]
        public string? AudioProfile { get; set; }

        /// <summary>
        /// Has this media been optimized for streaming. NOTE: This can be 0, 1, false or true
        /// </summary>
        [JsonProperty("optimizedForStreaming")]
        public GetMediaMetaDataOptimizedForStreaming? OptimizedForStreaming { get; set; }

        [JsonProperty("has64bitOffsets")]
        public bool? Has64bitOffsets { get; set; }

        /// <summary>
        /// An array of parts for this media item.
        /// </summary>
        [JsonProperty("Part")]
        public List<GetMediaMetaDataPart>? Part { get; set; }
    }
}