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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    
    public class CheckForUpdatesRequest
    {

        /// <summary>
        /// Indicate that you want to start download any updates found.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=download")]
        public Download? Download { get; set; }
    }
}