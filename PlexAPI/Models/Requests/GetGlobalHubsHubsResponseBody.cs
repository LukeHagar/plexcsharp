
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
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    /// <summary>
    /// Unauthorized - Returned if the X-Plex-Token is missing from the header or query.
    /// </summary>
    public class GetGlobalHubsHubsResponseBody
    {

        [JsonProperty("errors")]
        public List<GetGlobalHubsErrors>? Errors { get; set; }
    }
}