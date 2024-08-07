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
    
    public class ApplyUpdatesRequest
    {

        /// <summary>
        /// Indicate that you want the update to run during the next Butler execution. Omitting this or setting it to false indicates that the update should install
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=tonight")]
        public Tonight? Tonight { get; set; }

        /// <summary>
        /// Indicate that the latest version should be marked as skipped. The &lt;Release&gt; entry for this version will have the `state` set to `skipped`.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=skip")]
        public Skip? Skip { get; set; }
    }
}