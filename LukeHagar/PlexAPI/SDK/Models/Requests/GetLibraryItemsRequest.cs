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
    
    public class GetLibraryItemsRequest
    {

        /// <summary>
        /// A key representing a specific tag within the section.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=tag")]
        public Tag Tag { get; set; } = default!;

        /// <summary>
        /// The unique key of the Plex library. <br/>
        /// 
        /// <remarks>
        /// Note: This is unique in the context of the Plex server.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=sectionKey")]
        public int SectionKey { get; set; } = default!;

        /// <summary>
        /// Adds the Guids object to the response<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeGuids")]
        public IncludeGuids? IncludeGuids { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.IncludeGuids.Disable;

        /// <summary>
        /// The type of media to retrieve.<br/>
        /// 
        /// <remarks>
        /// 1 = movie<br/>
        /// 2 = show<br/>
        /// 3 = season<br/>
        /// 4 = episode<br/>
        /// E.g. A movie library will not return anything with type 3 as there are no seasons for movie libraries<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=type")]
        public GetLibraryItemsQueryParamType? Type { get; set; }

        /// <summary>
        /// Adds the Meta object to the response<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeMeta")]
        public GetLibraryItemsQueryParamIncludeMeta? IncludeMeta { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.GetLibraryItemsQueryParamIncludeMeta.Disable;

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