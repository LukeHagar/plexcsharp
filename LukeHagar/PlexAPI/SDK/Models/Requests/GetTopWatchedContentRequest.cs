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
    
    public class GetTopWatchedContentRequest
    {

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
        public GetTopWatchedContentQueryParamType Type { get; set; } = default!;

        /// <summary>
        /// Adds the Guids object to the response<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeGuids")]
        public long? IncludeGuids { get; set; }
    }
}