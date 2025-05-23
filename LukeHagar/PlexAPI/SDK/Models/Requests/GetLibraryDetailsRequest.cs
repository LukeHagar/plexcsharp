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
    
    public class GetLibraryDetailsRequest
    {

        /// <summary>
        /// Whether or not to include details for a section (types, filters, and sorts).<br/>
        /// 
        /// <remarks>
        /// Only exists for backwards compatibility, media providers other than the server libraries have it on always.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeDetails")]
        public IncludeDetails? IncludeDetails { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.IncludeDetails.Zero;

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
    }
}