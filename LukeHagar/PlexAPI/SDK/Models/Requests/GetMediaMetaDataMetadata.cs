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
    
    public class GetMediaMetaDataMetadata
    {

        /// <summary>
        /// The rating key of the metadata item.
        /// </summary>
        [JsonProperty("ratingKey")]
        public string RatingKey { get; set; } = default!;

        /// <summary>
        /// The rating key of the parent of this metadata item.
        /// </summary>
        [JsonProperty("parentRatingKey")]
        public string? ParentRatingKey { get; set; }

        /// <summary>
        /// The rating key of the grandparent of this metadata item.
        /// </summary>
        [JsonProperty("grandparentRatingKey")]
        public string? GrandparentRatingKey { get; set; }

        /// <summary>
        /// A GUID identifying the parent entity (e.g., season) for the item.
        /// </summary>
        [JsonProperty("parentGuid")]
        public string? ParentGuid { get; set; }

        /// <summary>
        /// A GUID identifying the grandparent entity (e.g., show).
        /// </summary>
        [JsonProperty("grandparentGuid")]
        public string? GrandparentGuid { get; set; }

        /// <summary>
        /// A URL-friendly identifier (slug) for the grandparent entity.
        /// </summary>
        [JsonProperty("grandparentSlug")]
        public string? GrandparentSlug { get; set; }

        /// <summary>
        /// A key identifying the grandparent metadata in the library.
        /// </summary>
        [JsonProperty("grandparentKey")]
        public string? GrandparentKey { get; set; }

        /// <summary>
        /// A key identifying the parent metadata in the library.
        /// </summary>
        [JsonProperty("parentKey")]
        public string? ParentKey { get; set; }

        /// <summary>
        /// The API key to access metadata details.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The globally unique identifier for the item.
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; } = default!;

        /// <summary>
        /// A URL-friendly identifier for the item.
        /// </summary>
        [JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// The studio that produced the content.
        /// </summary>
        [JsonProperty("studio")]
        public string? Studio { get; set; }

        /// <summary>
        /// The type of content (e.g., show, movie).
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The title of the content.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The original title of the content.
        /// </summary>
        [JsonProperty("originalTitle")]
        public string? OriginalTitle { get; set; }

        /// <summary>
        /// The title of the library section.
        /// </summary>
        [JsonProperty("librarySectionTitle")]
        public string LibrarySectionTitle { get; set; } = default!;

        /// <summary>
        /// The ID of the library section.
        /// </summary>
        [JsonProperty("librarySectionID")]
        public long LibrarySectionID { get; set; } = default!;

        /// <summary>
        /// The key of the library section.
        /// </summary>
        [JsonProperty("librarySectionKey")]
        public string LibrarySectionKey { get; set; } = default!;

        /// <summary>
        /// The content rating (e.g., TV-MA).
        /// </summary>
        [JsonProperty("contentRating")]
        public string? ContentRating { get; set; }

        /// <summary>
        /// A summary of the content.
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// The index or order of the item.
        /// </summary>
        [JsonProperty("index")]
        public long? Index { get; set; }

        /// <summary>
        /// The title of the grandparent entity (typically the show&apos;s title).
        /// </summary>
        [JsonProperty("grandparentTitle")]
        public string? GrandparentTitle { get; set; }

        /// <summary>
        /// The title of the parent entity (typically the season&apos;s title).
        /// </summary>
        [JsonProperty("parentTitle")]
        public string? ParentTitle { get; set; }

        /// <summary>
        /// The audience rating for the content.
        /// </summary>
        [JsonProperty("audienceRating")]
        public float? AudienceRating { get; set; }

        /// <summary>
        /// The number of times the item has been viewed.
        /// </summary>
        [JsonProperty("viewCount")]
        public long? ViewCount { get; set; }

        /// <summary>
        /// The number of times the item has been skipped.
        /// </summary>
        [JsonProperty("skipCount")]
        public long? SkipCount { get; set; }

        /// <summary>
        /// Unix timestamp of when the item was last viewed.
        /// </summary>
        [JsonProperty("lastViewedAt")]
        public long? LastViewedAt { get; set; }

        /// <summary>
        /// The release year.
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; } = default!;

        /// <summary>
        /// The general rating
        /// </summary>
        [JsonProperty("rating")]
        public float? Rating { get; set; }

        /// <summary>
        /// The URL or identifier for the rating image (e.g., Rotten Tomatoes rating image).
        /// </summary>
        [JsonProperty("ratingImage")]
        public string? RatingImage { get; set; }

        /// <summary>
        /// The tagline of the content.
        /// </summary>
        [JsonProperty("tagline")]
        public string? Tagline { get; set; }

        [JsonProperty("chapterSource")]
        public string? ChapterSource { get; set; }

        [JsonProperty("primaryExtraKey")]
        public string? PrimaryExtraKey { get; set; }

        /// <summary>
        /// URL of the thumbnail image.
        /// </summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; } = default!;

        /// <summary>
        /// URL of the art image.
        /// </summary>
        [JsonProperty("art")]
        public string Art { get; set; } = default!;

        /// <summary>
        /// URL of the theme image.
        /// </summary>
        [JsonProperty("theme")]
        public string? Theme { get; set; }

        /// <summary>
        /// Duration of the content in milliseconds.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; } = default!;

        /// <summary>
        /// The original release date.
        /// </summary>
        [JsonProperty("originallyAvailableAt")]
        public LocalDate? OriginallyAvailableAt { get; set; }

        /// <summary>
        /// The total number of episodes (or leaves).
        /// </summary>
        [JsonProperty("leafCount")]
        public long? LeafCount { get; set; }

        /// <summary>
        /// The number of episodes that have been viewed.
        /// </summary>
        [JsonProperty("viewedLeafCount")]
        public long? ViewedLeafCount { get; set; }

        /// <summary>
        /// The number of child items.
        /// </summary>
        [JsonProperty("childCount")]
        public int? ChildCount { get; set; }

        [JsonProperty("addedAt")]
        public long AddedAt { get; set; } = default!;

        [JsonProperty("updatedAt")]
        public long UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The URL for the audience rating image.
        /// </summary>
        [JsonProperty("audienceRatingImage")]
        public string? AudienceRatingImage { get; set; }

        /// <summary>
        /// The index number of the parent entity, which could indicate its order or position.
        /// </summary>
        [JsonProperty("parentIndex")]
        public long? ParentIndex { get; set; }

        /// <summary>
        /// The URL of the parent&apos;s thumbnail image.
        /// </summary>
        [JsonProperty("parentThumb")]
        public string? ParentThumb { get; set; }

        /// <summary>
        /// The URL of the grandparent&apos;s thumbnail image.
        /// </summary>
        [JsonProperty("grandparentThumb")]
        public string? GrandparentThumb { get; set; }

        /// <summary>
        /// The URL of the grandparent&apos;s art image.
        /// </summary>
        [JsonProperty("grandparentArt")]
        public string? GrandparentArt { get; set; }

        [JsonProperty("Media")]
        public List<GetMediaMetaDataMedia>? Media { get; set; }

        /// <summary>
        /// An array of image objects.
        /// </summary>
        [JsonProperty("Image")]
        public List<GetMediaMetaDataImage> Image { get; set; } = default!;

        [JsonProperty("UltraBlurColors")]
        public GetMediaMetaDataUltraBlurColors UltraBlurColors { get; set; } = default!;

        /// <summary>
        /// An array of genre tags.
        /// </summary>
        [JsonProperty("Genre")]
        public List<GetMediaMetaDataGenre>? Genre { get; set; }

        /// <summary>
        /// An array of country tags.
        /// </summary>
        [JsonProperty("Country")]
        public List<GetMediaMetaDataCountry>? Country { get; set; }

        /// <summary>
        /// An array of GUID objects.
        /// </summary>
        [JsonProperty("Guid")]
        public List<GetMediaMetaDataGuids>? Guids { get; set; }

        /// <summary>
        /// An array of rating objects.
        /// </summary>
        [JsonProperty("Rating")]
        public List<Ratings>? Ratings { get; set; }

        /// <summary>
        /// An array of Actor roles.
        /// </summary>
        [JsonProperty("Role")]
        public List<GetMediaMetaDataRole>? Role { get; set; }

        /// <summary>
        /// An array of Director roles.
        /// </summary>
        [JsonProperty("Director")]
        public List<GetMediaMetaDataDirector>? Director { get; set; }

        /// <summary>
        /// An array of Writer roles.
        /// </summary>
        [JsonProperty("Writer")]
        public List<GetMediaMetaDataWriter>? Writer { get; set; }

        /// <summary>
        /// An array of Writer roles.
        /// </summary>
        [JsonProperty("Producer")]
        public List<GetMediaMetaDataProducer>? Producer { get; set; }

        /// <summary>
        /// An array of similar content objects.
        /// </summary>
        [JsonProperty("Similar")]
        public List<GetMediaMetaDataSimilar>? Similar { get; set; }

        /// <summary>
        /// An array of location objects.
        /// </summary>
        [JsonProperty("Location")]
        public List<GetMediaMetaDataLocation>? Location { get; set; }
    }
}