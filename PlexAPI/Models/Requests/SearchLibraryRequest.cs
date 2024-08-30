//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    
    public class SearchLibraryRequest
    {

        /// <summary>
        /// the Id of the library to query
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=sectionId")]
        public long SectionId { get; set; } = default!;

        /// <summary>
        /// Plex content type to search for
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=type")]
        public Models.Requests.Type Type { get; set; } = default!;
    }
}