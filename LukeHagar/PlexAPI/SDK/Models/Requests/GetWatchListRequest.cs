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
    
    public class GetWatchListRequest
    {

        /// <summary>
        /// Filter
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=filter")]
        public Filter Filter { get; set; } = default!;

        /// <summary>
        /// An authentication token, obtained from plex.tv
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Plex-Token")]
        public string XPlexToken { get; set; } = default!;

        /// <summary>
        /// In the format &quot;field:dir&quot;. Available fields are &quot;watchlistedAt&quot; (Added At),<br/>
        /// 
        /// <remarks>
        /// &quot;titleSort&quot; (Title), &quot;originallyAvailableAt&quot; (Release Date), or &quot;rating&quot; (Critic Rating).<br/>
        /// &quot;dir&quot; can be &quot;asc&quot; or &quot;desc&quot;<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=sort")]
        public string? Sort { get; set; }

        /// <summary>
        /// The type of library to filter. Can be &quot;movie&quot; or &quot;show&quot;, or all if not present.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=libtype")]
        public Libtype? Libtype { get; set; }

        /// <summary>
        /// The number of items to return. If not specified, all items will be returned.<br/>
        /// 
        /// <remarks>
        /// If the number of items exceeds the limit, the response will be paginated.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=maxresults")]
        public int? Maxresults { get; set; }

        /// <summary>
        /// include collections in the results<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeCollections")]
        public IncludeCollections? IncludeCollections { get; set; }

        /// <summary>
        /// include external media in the results<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeExternalMedia")]
        public IncludeExternalMedia? IncludeExternalMedia { get; set; }

        /// <summary>
        /// The index of the first item to return. If not specified, the first item will be returned.<br/>
        /// 
        /// <remarks>
        /// If the number of items exceeds the limit, the response will be paginated.<br/>
        /// By default this is 0<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Container-Start")]
        public int? XPlexContainerStart { get; set; } = 0;

        /// <summary>
        /// The number of items to return. If not specified, all items will be returned.<br/>
        /// 
        /// <remarks>
        /// If the number of items exceeds the limit, the response will be paginated.<br/>
        /// By default this is 50<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Container-Size")]
        public int? XPlexContainerSize { get; set; } = 50;
    }
}