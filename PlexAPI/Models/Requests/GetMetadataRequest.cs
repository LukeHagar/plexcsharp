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
    
    public class GetMetadataRequest
    {

        /// <summary>
        /// the id of the library item to return the children of.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ratingKey")]
        public double RatingKey { get; set; } = default!;
    }
}