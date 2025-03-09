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
    
    /// <summary>
    /// Unknown<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class GetRecentlyAddedMetadata
    {

        [JsonProperty("addedAt")]
        public long AddedAt { get; set; } = default!;

        /// <summary>
        /// The art image URL for the media item.
        /// </summary>
        [JsonProperty("art")]
        public string Art { get; set; } = default!;

        /// <summary>
        /// The URL for the audience rating image.
        /// </summary>
        [JsonProperty("audienceRatingImage")]
        public string? AudienceRatingImage { get; set; }

        /// <summary>
        /// The audience rating for the media item.
        /// </summary>
        [JsonProperty("audienceRating")]
        public double AudienceRating { get; set; } = default!;

        /// <summary>
        /// The source from which chapter data is derived.
        /// </summary>
        [JsonProperty("chapterSource")]
        public string? ChapterSource { get; set; }

        /// <summary>
        /// The number of child items associated with this media item.
        /// </summary>
        [JsonProperty("childCount")]
        public int ChildCount { get; set; } = default!;

        /// <summary>
        /// The content rating for the media item.
        /// </summary>
        [JsonProperty("contentRating")]
        public string? ContentRating { get; set; }

        /// <summary>
        /// The accuracy of the creation timestamp. This value indicates the format(s) provided (for example, &apos;epoch,local&apos; means both epoch and local time formats are available).
        /// </summary>
        [JsonProperty("createdAtAccuracy")]
        public string? CreatedAtAccuracy { get; set; }

        /// <summary>
        /// The time zone offset for the creation timestamp, represented as a string. This offset indicates the difference from UTC.
        /// </summary>
        [JsonProperty("createdAtTZOffset")]
        public string? CreatedAtTZOffset { get; set; }

        /// <summary>
        /// The duration of the media item in milliseconds.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; } = default!;

        /// <summary>
        /// The art URL for the grandparent media item.
        /// </summary>
        [JsonProperty("grandparentArt")]
        public string? GrandparentArt { get; set; }

        /// <summary>
        /// The GUID of the grandparent media item.
        /// </summary>
        [JsonProperty("grandparentGuid")]
        public string? GrandparentGuid { get; set; }

        /// <summary>
        /// The key of the grandparent media item.
        /// </summary>
        [JsonProperty("grandparentKey")]
        public string? GrandparentKey { get; set; }

        /// <summary>
        /// The rating key of the grandparent media item.
        /// </summary>
        [JsonProperty("grandparentRatingKey")]
        public string? GrandparentRatingKey { get; set; }

        /// <summary>
        /// The slug for the grandparent media item.
        /// </summary>
        [JsonProperty("grandparentSlug")]
        public string? GrandparentSlug { get; set; }

        /// <summary>
        /// The theme URL for the grandparent media item.
        /// </summary>
        [JsonProperty("grandparentTheme")]
        public string? GrandparentTheme { get; set; }

        /// <summary>
        /// The thumbnail URL for the grandparent media item.
        /// </summary>
        [JsonProperty("grandparentThumb")]
        public string? GrandparentThumb { get; set; }

        /// <summary>
        /// The title of the grandparent media item.
        /// </summary>
        [JsonProperty("grandparentTitle")]
        public string? GrandparentTitle { get; set; }

        /// <summary>
        /// The globally unique identifier for the media item.
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; } = default!;

        /// <summary>
        /// The index position of the media item.
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The unique key for the media item.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp representing the last time the item was rated.
        /// </summary>
        [JsonProperty("lastRatedAt")]
        public long? LastRatedAt { get; set; }

        /// <summary>
        /// Unix timestamp for when the media item was last viewed.
        /// </summary>
        [JsonProperty("lastViewedAt")]
        public int? LastViewedAt { get; set; }

        /// <summary>
        /// The number of leaf items (end nodes) under this media item.
        /// </summary>
        [JsonProperty("leafCount")]
        public int? LeafCount { get; set; }

        /// <summary>
        /// The identifier for the library section.
        /// </summary>
        [JsonProperty("librarySectionID")]
        public long LibrarySectionID { get; set; } = default!;

        /// <summary>
        /// The key corresponding to the library section.
        /// </summary>
        [JsonProperty("librarySectionKey")]
        public string LibrarySectionKey { get; set; } = default!;

        /// <summary>
        /// The title of the library section.
        /// </summary>
        [JsonProperty("librarySectionTitle")]
        public string LibrarySectionTitle { get; set; } = default!;

        /// <summary>
        /// The original title of the media item (if different).
        /// </summary>
        [JsonProperty("originalTitle")]
        public string? OriginalTitle { get; set; }

        /// <summary>
        /// The original release date of the media item.
        /// </summary>
        [JsonProperty("originallyAvailableAt")]
        public LocalDate OriginallyAvailableAt { get; set; } = default!;

        /// <summary>
        /// The GUID of the parent media item.
        /// </summary>
        [JsonProperty("parentGuid")]
        public string? ParentGuid { get; set; }

        /// <summary>
        /// The index position of the parent media item.
        /// </summary>
        [JsonProperty("parentIndex")]
        public int? ParentIndex { get; set; }

        /// <summary>
        /// The key of the parent media item.
        /// </summary>
        [JsonProperty("parentKey")]
        public string? ParentKey { get; set; }

        /// <summary>
        /// The rating key of the parent media item.
        /// </summary>
        [JsonProperty("parentRatingKey")]
        public string? ParentRatingKey { get; set; }

        /// <summary>
        /// The slug for the parent media item.
        /// </summary>
        [JsonProperty("parentSlug")]
        public string? ParentSlug { get; set; }

        /// <summary>
        /// The studio of the parent media item.
        /// </summary>
        [JsonProperty("parentStudio")]
        public string ParentStudio { get; set; } = default!;

        /// <summary>
        /// The theme URL for the parent media item.
        /// </summary>
        [JsonProperty("parentTheme")]
        public string ParentTheme { get; set; } = default!;

        /// <summary>
        /// The thumbnail URL for the parent media item.
        /// </summary>
        [JsonProperty("parentThumb")]
        public string? ParentThumb { get; set; }

        /// <summary>
        /// The title of the parent media item.
        /// </summary>
        [JsonProperty("parentTitle")]
        public string? ParentTitle { get; set; }

        /// <summary>
        /// The release year of the parent media item.
        /// </summary>
        [JsonProperty("parentYear")]
        public int? ParentYear { get; set; }

        /// <summary>
        /// The primary extra key associated with this media item.
        /// </summary>
        [JsonProperty("primaryExtraKey")]
        public string? PrimaryExtraKey { get; set; }

        /// <summary>
        /// The URL for the rating image.
        /// </summary>
        [JsonProperty("ratingImage")]
        public string? RatingImage { get; set; }

        /// <summary>
        /// The rating key (Media ID) of this media item. Note: Although this is always an integer, it is represented as a string in the API.
        /// </summary>
        [JsonProperty("ratingKey")]
        public string RatingKey { get; set; } = default!;

        /// <summary>
        /// The critic rating for the media item.
        /// </summary>
        [JsonProperty("rating")]
        public float Rating { get; set; } = default!;

        /// <summary>
        /// The total number of seasons (for TV shows).
        /// </summary>
        [JsonProperty("seasonCount")]
        public int SeasonCount { get; set; } = default!;

        /// <summary>
        /// The number of times this media item has been skipped.
        /// </summary>
        [JsonProperty("skipCount")]
        public int? SkipCount { get; set; }

        /// <summary>
        /// A URL‐friendly version of the media title.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// The studio that produced the media item.
        /// </summary>
        [JsonProperty("studio")]
        public string? Studio { get; set; }

        /// <summary>
        /// A classification that further describes the type of media item. For example, &apos;clip&apos; indicates that the item is a short video clip.
        /// </summary>
        [JsonProperty("subtype")]
        public string? Subtype { get; set; }

        /// <summary>
        /// A synopsis of the media item.
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// A brief tagline for the media item.
        /// </summary>
        [JsonProperty("tagline")]
        public string Tagline { get; set; } = default!;

        /// <summary>
        /// The theme URL for the media item.
        /// </summary>
        [JsonProperty("theme")]
        public string Theme { get; set; } = default!;

        /// <summary>
        /// The thumbnail image URL for the media item.
        /// </summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; } = default!;

        /// <summary>
        /// The sort title used for ordering media items.
        /// </summary>
        [JsonProperty("titleSort")]
        public string TitleSort { get; set; } = default!;

        /// <summary>
        /// The title of the media item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("type")]
        public GetRecentlyAddedHubsType Type { get; set; } = default!;

        /// <summary>
        /// Unix epoch datetime in seconds
        /// </summary>
        [JsonProperty("updatedAt")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// The rating provided by a user for the item. This value is expressed as a decimal number.
        /// </summary>
        [JsonProperty("userRating")]
        public float? UserRating { get; set; }

        /// <summary>
        /// The number of times this media item has been viewed.
        /// </summary>
        [JsonProperty("viewCount")]
        public int? ViewCount { get; set; }

        /// <summary>
        /// The current playback offset (in milliseconds).
        /// </summary>
        [JsonProperty("viewOffset")]
        public int? ViewOffset { get; set; }

        /// <summary>
        /// The number of leaf items that have been viewed.
        /// </summary>
        [JsonProperty("viewedLeafCount")]
        public int? ViewedLeafCount { get; set; }

        /// <summary>
        /// The release year of the media item.
        /// </summary>
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("Image")]
        public List<GetRecentlyAddedImage>? Image { get; set; }

        [JsonProperty("UltraBlurColors")]
        public UltraBlurColors? UltraBlurColors { get; set; }

        [JsonProperty("Media")]
        public List<Models.Requests.Media>? Media { get; set; }

        [JsonProperty("Genre")]
        public List<Genre>? Genre { get; set; }

        [JsonProperty("Country")]
        public List<Country>? Country { get; set; }

        [JsonProperty("Director")]
        public List<Director>? Director { get; set; }

        [JsonProperty("Writer")]
        public List<Writer>? Writer { get; set; }

        [JsonProperty("Role")]
        public List<Role>? Role { get; set; }

        [JsonProperty("Producer")]
        public List<Producer>? Producer { get; set; }

        [JsonProperty("Rating")]
        public List<Rating>? Rating1 { get; set; }

        [JsonProperty("Similar")]
        public List<Similar>? Similar { get; set; }

        [JsonProperty("Location")]
        public List<Location>? Location { get; set; }

        [JsonProperty("Guid")]
        public List<Guids>? Guids { get; set; }

        [JsonProperty("Collection")]
        public List<Collection>? Collection { get; set; }
    }
}