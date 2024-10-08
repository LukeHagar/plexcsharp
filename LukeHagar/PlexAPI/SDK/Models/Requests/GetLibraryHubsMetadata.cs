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
    
    public class GetLibraryHubsMetadata
    {

        [JsonProperty("ratingKey")]
        public string? RatingKey { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("guid")]
        public string? Guid { get; set; }

        [JsonProperty("studio")]
        public string? Studio { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("librarySectionTitle")]
        public string? LibrarySectionTitle { get; set; }

        [JsonProperty("librarySectionID")]
        public int? LibrarySectionID { get; set; }

        [JsonProperty("librarySectionKey")]
        public string? LibrarySectionKey { get; set; }

        [JsonProperty("contentRating")]
        public string? ContentRating { get; set; }

        [JsonProperty("summary")]
        public string? Summary { get; set; }

        [JsonProperty("rating")]
        public double? Rating { get; set; }

        [JsonProperty("audienceRating")]
        public double? AudienceRating { get; set; }

        [JsonProperty("viewCount")]
        public int? ViewCount { get; set; }

        [JsonProperty("lastViewedAt")]
        public int? LastViewedAt { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("tagline")]
        public string? Tagline { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("originallyAvailableAt")]
        public LocalDate? OriginallyAvailableAt { get; set; }

        [JsonProperty("addedAt")]
        public int? AddedAt { get; set; }

        [JsonProperty("updatedAt")]
        public int? UpdatedAt { get; set; }

        [JsonProperty("audienceRatingImage")]
        public string? AudienceRatingImage { get; set; }

        [JsonProperty("primaryExtraKey")]
        public string? PrimaryExtraKey { get; set; }

        [JsonProperty("ratingImage")]
        public string? RatingImage { get; set; }

        [JsonProperty("Media")]
        public List<GetLibraryHubsMedia>? Media { get; set; }

        [JsonProperty("Genre")]
        public List<GetLibraryHubsGenre>? Genre { get; set; }

        [JsonProperty("Country")]
        public List<GetLibraryHubsCountry>? Country { get; set; }

        [JsonProperty("Director")]
        public List<GetLibraryHubsDirector>? Director { get; set; }

        [JsonProperty("Role")]
        public List<GetLibraryHubsRole>? Role { get; set; }

        [JsonProperty("Writer")]
        public List<GetLibraryHubsWriter>? Writer { get; set; }

        [JsonProperty("skipCount")]
        public int? SkipCount { get; set; }

        [JsonProperty("chapterSource")]
        public string? ChapterSource { get; set; }
    }
}