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
    
    public class DeleteLibraryRequest
    {

        /// <summary>
        /// the Id of the library to query
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=sectionId")]
        public double SectionId { get; set; } = default!;
    }
}