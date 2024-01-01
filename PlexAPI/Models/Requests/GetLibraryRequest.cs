
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using PlexAPI.Utils;
    
    public class GetLibraryRequest
    {

        /// <summary>
        /// the Id of the library to query
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=sectionId")]
        public double SectionId { get; set; } = default!;

        /// <summary>
        /// Whether or not to include details for a section (types, filters, and sorts). <br/>
        /// 
        /// <remarks>
        /// Only exists for backwards compatibility, media providers other than the server libraries have it on always.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeDetails")]
        public IncludeDetails? IncludeDetails { get; set; }
    }
}