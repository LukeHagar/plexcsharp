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
    using NodaTime;
    using System.Collections.Generic;
    
    public class Metadata
    {

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("guid")]
        public string? Guid { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("ratingKey")]
        public string? RatingKey { get; set; }

        [JsonProperty("studio")]
        public string? Studio { get; set; }

        [JsonProperty("tagline")]
        public string? Tagline { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("addedAt")]
        public int? AddedAt { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("publicPagesURL")]
        public string? PublicPagesURL { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("userState")]
        public bool? UserState { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("contentRating")]
        public string? ContentRating { get; set; }

        [JsonProperty("originallyAvailableAt")]
        public LocalDate? OriginallyAvailableAt { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("Image")]
        public List<Image>? Image { get; set; }

        [JsonProperty("banner")]
        public string? Banner { get; set; }

        [JsonProperty("rating")]
        public double? Rating { get; set; }

        [JsonProperty("expiresAt")]
        public int? ExpiresAt { get; set; }

        [JsonProperty("originalTitle")]
        public string? OriginalTitle { get; set; }

        [JsonProperty("audienceRating")]
        public double? AudienceRating { get; set; }

        [JsonProperty("audienceRatingImage")]
        public string? AudienceRatingImage { get; set; }

        [JsonProperty("ratingImage")]
        public string? RatingImage { get; set; }

        [JsonProperty("imdbRatingCount")]
        public int? ImdbRatingCount { get; set; }

        [JsonProperty("subtype")]
        public string? Subtype { get; set; }

        [JsonProperty("theme")]
        public string? Theme { get; set; }

        [JsonProperty("leafCount")]
        public int? LeafCount { get; set; }

        [JsonProperty("childCount")]
        public int? ChildCount { get; set; }

        [JsonProperty("isContinuingSeries")]
        public bool? IsContinuingSeries { get; set; }

        [JsonProperty("skipChildren")]
        public bool? SkipChildren { get; set; }

        [JsonProperty("availabilityId")]
        public string? AvailabilityId { get; set; }

        [JsonProperty("streamingMediaId")]
        public string? StreamingMediaId { get; set; }

        [JsonProperty("playableKey")]
        public string? PlayableKey { get; set; }
    }
}