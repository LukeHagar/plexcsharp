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
    using LukeHagar.PlexAPI.SDK.Utils;
    
    public class GetMediaArtsRequest
    {

        /// <summary>
        /// the id of the library item to return the artwork of.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=ratingKey")]
        public long RatingKey { get; set; } = default!;
    }
}