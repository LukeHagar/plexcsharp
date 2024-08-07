//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Errors
{
    using Newtonsoft.Json;
    using PlexAPI.Models.Errors;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System;
    
    /// <summary>
    /// X-Plex-Client-Identifier is missing
    /// </summary>
    public class GetTokenResponseBody : Exception
    {

        [JsonProperty("errors")]
        public List<GetTokenErrors>? Errors { get; set; }

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        [JsonProperty("-")]
        public HttpResponseMessage? RawResponse { get; set; }
    }
}