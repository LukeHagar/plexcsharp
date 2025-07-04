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
    
    public class GetLibrarySectionsAllMediaContainer
    {

        /// <summary>
        /// Number of media items returned in this response.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Total number of media items in the library.
        /// </summary>
        [JsonProperty("totalSize")]
        public int TotalSize { get; set; } = default!;

        /// <summary>
        /// Offset value for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public long Offset { get; set; } = default!;

        /// <summary>
        /// Indicates whether syncing is allowed.
        /// </summary>
        [JsonProperty("allowSync")]
        public bool AllowSync { get; set; } = default!;

        /// <summary>
        /// URL for the background artwork of the media container.
        /// </summary>
        [JsonProperty("art")]
        public string Art { get; set; } = default!;

        /// <summary>
        /// The content type or mode.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; } = default!;

        /// <summary>
        /// An plugin identifier for the media container.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the library section.
        /// </summary>
        [JsonProperty("librarySectionID")]
        public long? LibrarySectionID { get; set; }

        /// <summary>
        /// The title of the library section.
        /// </summary>
        [JsonProperty("librarySectionTitle")]
        public string? LibrarySectionTitle { get; set; }

        /// <summary>
        /// The universally unique identifier for the library section.
        /// </summary>
        [JsonProperty("librarySectionUUID")]
        public string? LibrarySectionUUID { get; set; }

        /// <summary>
        /// The prefix used for media tag resource paths.
        /// </summary>
        [JsonProperty("mediaTagPrefix")]
        public string MediaTagPrefix { get; set; } = default!;

        /// <summary>
        /// The version number for media tags.
        /// </summary>
        [JsonProperty("mediaTagVersion")]
        public long MediaTagVersion { get; set; } = default!;

        /// <summary>
        /// URL for the thumbnail image of the media container.
        /// </summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; } = default!;

        /// <summary>
        /// Specifies whether caching is disabled.
        /// </summary>
        [JsonProperty("nocache")]
        public bool Nocache { get; set; } = default!;

        /// <summary>
        /// The primary title of the media container.
        /// </summary>
        [JsonProperty("title1")]
        public string Title1 { get; set; } = default!;

        /// <summary>
        /// The secondary title of the media container.
        /// </summary>
        [JsonProperty("title2")]
        public string Title2 { get; set; } = default!;

        /// <summary>
        /// Identifier for the view group layout.
        /// </summary>
        [JsonProperty("viewGroup")]
        public string ViewGroup { get; set; } = default!;

        /// <summary>
        /// The Meta object is only included in the response if the `includeMeta` parameter is set to `1`.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("Meta")]
        public GetLibrarySectionsAllMeta? Meta { get; set; }

        /// <summary>
        /// An array of metadata items.
        /// </summary>
        [JsonProperty("Metadata")]
        public List<GetLibrarySectionsAllMetadata>? Metadata { get; set; }
    }
}