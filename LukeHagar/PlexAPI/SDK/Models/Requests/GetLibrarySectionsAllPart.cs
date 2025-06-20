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
    
    public class GetLibrarySectionsAllPart
    {

        /// <summary>
        /// Indicates if the part is accessible.
        /// </summary>
        [JsonProperty("accessible")]
        public bool? Accessible { get; set; }

        /// <summary>
        /// Indicates if the part exists.
        /// </summary>
        [JsonProperty("exists")]
        public bool? Exists { get; set; }

        /// <summary>
        /// Unique part identifier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Key to access this part.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        [JsonProperty("indexes")]
        public string? Indexes { get; set; }

        /// <summary>
        /// Duration of the part in milliseconds.
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// File path for the part.
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; } = default!;

        /// <summary>
        /// File size in bytes.
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; } = default!;

        [JsonProperty("packetLength")]
        public int? PacketLength { get; set; }

        /// <summary>
        /// Container format of the part.
        /// </summary>
        [JsonProperty("container")]
        public string? Container { get; set; }

        /// <summary>
        /// Video profile for the part.
        /// </summary>
        [JsonProperty("videoProfile")]
        public string? VideoProfile { get; set; }

        /// <summary>
        /// The audio profile used for the media (e.g., DTS, Dolby Digital, etc.).
        /// </summary>
        [JsonProperty("audioProfile")]
        public string? AudioProfile { get; set; }

        [JsonProperty("has64bitOffsets")]
        public bool? Has64bitOffsets { get; set; }

        /// <summary>
        /// Has this media been optimized for streaming. NOTE: This can be 0, 1, false or true
        /// </summary>
        [JsonProperty("optimizedForStreaming")]
        public GetLibrarySectionsAllLibraryOptimizedForStreaming? OptimizedForStreaming { get; set; }

        [JsonProperty("hasThumbnail")]
        public GetLibrarySectionsAllHasThumbnail? HasThumbnail { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.GetLibrarySectionsAllHasThumbnail.False;

        /// <summary>
        /// An array of streams for this part.
        /// </summary>
        [JsonProperty("Stream")]
        public List<GetLibrarySectionsAllStream>? Stream { get; set; }
    }
}