
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
    
    public class AddPlaylistContentsMetadata
    {

        [JsonProperty("ratingKey")]
        public string? RatingKey { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("guid")]
        public string? Guid { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("summary")]
        public string? Summary { get; set; }

        [JsonProperty("smart")]
        public bool? Smart { get; set; }

        [JsonProperty("playlistType")]
        public string? PlaylistType { get; set; }

        [JsonProperty("composite")]
        public string? Composite { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("leafCount")]
        public int? LeafCount { get; set; }

        [JsonProperty("addedAt")]
        public int? AddedAt { get; set; }

        [JsonProperty("updatedAt")]
        public int? UpdatedAt { get; set; }
    }
}