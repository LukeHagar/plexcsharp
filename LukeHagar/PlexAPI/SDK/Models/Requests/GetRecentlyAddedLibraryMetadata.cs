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
    using System;
    
    public class GetRecentlyAddedLibraryMetadata
    {

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("librarySectionID")]
        public double? LibrarySectionID { get; set; }

        [JsonProperty("librarySectionTitle")]
        public string? LibrarySectionTitle { get; set; }

        [JsonProperty("librarySectionUUID")]
        public string? LibrarySectionUUID { get; set; }

        [JsonProperty("ratingKey")]
        public double? RatingKey { get; set; }

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

        [JsonProperty("contentRating")]
        public string? ContentRating { get; set; }

        [JsonProperty("summary")]
        public string? Summary { get; set; }

        [JsonProperty("rating")]
        public double? Rating { get; set; }

        [JsonProperty("audienceRating")]
        public double? AudienceRating { get; set; }

        [JsonProperty("year")]
        public double? Year { get; set; }

        [JsonProperty("tagline")]
        public string? Tagline { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("duration")]
        public double? Duration { get; set; }

        [JsonProperty("originallyAvailableAt")]
        public DateTime? OriginallyAvailableAt { get; set; }

        [JsonProperty("addedAt")]
        public double? AddedAt { get; set; }

        [JsonProperty("updatedAt")]
        public double? UpdatedAt { get; set; }

        [JsonProperty("audienceRatingImage")]
        public string? AudienceRatingImage { get; set; }

        [JsonProperty("chapterSource")]
        public string? ChapterSource { get; set; }

        [JsonProperty("primaryExtraKey")]
        public string? PrimaryExtraKey { get; set; }

        [JsonProperty("ratingImage")]
        public string? RatingImage { get; set; }

        [JsonProperty("Media")]
        public List<GetRecentlyAddedLibraryMedia>? Media { get; set; }

        [JsonProperty("Genre")]
        public List<GetRecentlyAddedLibraryGenre>? Genre { get; set; }

        [JsonProperty("Director")]
        public List<GetRecentlyAddedLibraryDirector>? Director { get; set; }

        [JsonProperty("Writer")]
        public List<GetRecentlyAddedLibraryWriter>? Writer { get; set; }

        [JsonProperty("Country")]
        public List<GetRecentlyAddedLibraryCountry>? Country { get; set; }

        [JsonProperty("Role")]
        public List<GetRecentlyAddedLibraryRole>? Role { get; set; }
    }
}