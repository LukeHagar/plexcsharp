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
    
    public class GetSearchAllLibrariesMetadata
    {

        /// <summary>
        /// The rating key (Media ID) of this media item.<br/>
        /// 
        /// <remarks>
        /// Note: This is always an integer, but is represented as a string in the API.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("ratingKey")]
        public string RatingKey { get; set; } = default!;

        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        [JsonProperty("guid")]
        public string Guid { get; set; } = default!;

        [JsonProperty("studio")]
        public string? Studio { get; set; }

        [JsonProperty("skipChildren")]
        public bool? SkipChildren { get; set; }

        [JsonProperty("librarySectionID")]
        public long? LibrarySectionID { get; set; }

        [JsonProperty("librarySectionTitle")]
        public string? LibrarySectionTitle { get; set; }

        [JsonProperty("librarySectionKey")]
        public string? LibrarySectionKey { get; set; }

        /// <summary>
        /// The type of media content<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("type")]
        public GetSearchAllLibrariesType Type { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("contentRating")]
        public string? ContentRating { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; } = default!;

        [JsonProperty("rating")]
        public double? Rating { get; set; }

        [JsonProperty("audienceRating")]
        public double? AudienceRating { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("seasonCount")]
        public int? SeasonCount { get; set; }

        [JsonProperty("tagline")]
        public string? Tagline { get; set; }

        [JsonProperty("flattenSeasons")]
        public GetSearchAllLibrariesFlattenSeasons? FlattenSeasons { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.GetSearchAllLibrariesFlattenSeasons.False;

        /// <summary>
        /// Setting that indicates the episode ordering for the show <br/>
        /// 
        /// <remarks>
        /// None = Library default, <br/>
        /// tmdbAiring = The Movie Database (Aired), <br/>
        /// aired = TheTVDB (Aired), <br/>
        /// dvd = TheTVDB (DVD), <br/>
        /// absolute = TheTVDB (Absolute)).<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("showOrdering")]
        public GetSearchAllLibrariesShowOrdering? ShowOrdering { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("art")]
        public string? Art { get; set; }

        [JsonProperty("banner")]
        public string? Banner { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("originallyAvailableAt")]
        public LocalDate? OriginallyAvailableAt { get; set; }

        /// <summary>
        /// Unix epoch datetime in seconds
        /// </summary>
        [JsonProperty("addedAt")]
        public long AddedAt { get; set; } = default!;

        /// <summary>
        /// Unix epoch datetime in seconds
        /// </summary>
        [JsonProperty("updatedAt")]
        public long? UpdatedAt { get; set; }

        [JsonProperty("audienceRatingImage")]
        public string? AudienceRatingImage { get; set; }

        [JsonProperty("chapterSource")]
        public string? ChapterSource { get; set; }

        [JsonProperty("primaryExtraKey")]
        public string? PrimaryExtraKey { get; set; }

        [JsonProperty("ratingImage")]
        public string? RatingImage { get; set; }

        [JsonProperty("grandparentRatingKey")]
        public string? GrandparentRatingKey { get; set; }

        [JsonProperty("grandparentGuid")]
        public string? GrandparentGuid { get; set; }

        [JsonProperty("grandparentKey")]
        public string? GrandparentKey { get; set; }

        [JsonProperty("grandparentTitle")]
        public string? GrandparentTitle { get; set; }

        [JsonProperty("grandparentThumb")]
        public string? GrandparentThumb { get; set; }

        [JsonProperty("parentSlug")]
        public string? ParentSlug { get; set; }

        [JsonProperty("grandparentSlug")]
        public string? GrandparentSlug { get; set; }

        [JsonProperty("grandparentArt")]
        public string? GrandparentArt { get; set; }

        [JsonProperty("grandparentTheme")]
        public string? GrandparentTheme { get; set; }

        /// <summary>
        /// The Media object is only included when type query is `4` or higher.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("Media")]
        public List<GetSearchAllLibrariesMedia>? Media { get; set; }

        [JsonProperty("Genre")]
        public List<GetSearchAllLibrariesGenre>? Genre { get; set; }

        [JsonProperty("Country")]
        public List<GetSearchAllLibrariesCountry>? Country { get; set; }

        [JsonProperty("Director")]
        public List<GetSearchAllLibrariesDirector>? Director { get; set; }

        [JsonProperty("Writer")]
        public List<GetSearchAllLibrariesWriter>? Writer { get; set; }

        [JsonProperty("Collection")]
        public List<GetSearchAllLibrariesCollection>? Collection { get; set; }

        [JsonProperty("Role")]
        public List<GetSearchAllLibrariesRole>? Role { get; set; }

        [JsonProperty("Location")]
        public List<GetSearchAllLibrariesLocation>? Location { get; set; }

        /// <summary>
        /// The Guid object is only included in the response if the `includeGuids` parameter is set to `1`.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("Guid")]
        public List<GetSearchAllLibrariesMediaGuid>? MediaGuid { get; set; }

        [JsonProperty("UltraBlurColors")]
        public GetSearchAllLibrariesUltraBlurColors? UltraBlurColors { get; set; }

        [JsonProperty("Rating")]
        public List<GetSearchAllLibrariesMetaDataRating>? MetaDataRating { get; set; }

        [JsonProperty("Image")]
        public List<GetSearchAllLibrariesImage>? Image { get; set; }

        [JsonProperty("titleSort")]
        public string? TitleSort { get; set; }

        [JsonProperty("viewCount")]
        public int? ViewCount { get; set; }

        [JsonProperty("lastViewedAt")]
        public int? LastViewedAt { get; set; }

        [JsonProperty("originalTitle")]
        public string? OriginalTitle { get; set; }

        [JsonProperty("viewOffset")]
        public int? ViewOffset { get; set; }

        [JsonProperty("skipCount")]
        public int? SkipCount { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("theme")]
        public string? Theme { get; set; }

        [JsonProperty("leafCount")]
        public int? LeafCount { get; set; }

        [JsonProperty("viewedLeafCount")]
        public int? ViewedLeafCount { get; set; }

        [JsonProperty("childCount")]
        public int? ChildCount { get; set; }

        [JsonProperty("hasPremiumExtras")]
        public string? HasPremiumExtras { get; set; }

        [JsonProperty("hasPremiumPrimaryExtra")]
        public string? HasPremiumPrimaryExtra { get; set; }

        /// <summary>
        /// The rating key of the parent item.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("parentRatingKey")]
        public string? ParentRatingKey { get; set; }

        [JsonProperty("parentGuid")]
        public string? ParentGuid { get; set; }

        [JsonProperty("parentStudio")]
        public string? ParentStudio { get; set; }

        [JsonProperty("parentKey")]
        public string? ParentKey { get; set; }

        [JsonProperty("parentTitle")]
        public string? ParentTitle { get; set; }

        [JsonProperty("parentIndex")]
        public int? ParentIndex { get; set; }

        [JsonProperty("parentYear")]
        public int? ParentYear { get; set; }

        [JsonProperty("parentThumb")]
        public string? ParentThumb { get; set; }

        [JsonProperty("parentTheme")]
        public string? ParentTheme { get; set; }
    }
}