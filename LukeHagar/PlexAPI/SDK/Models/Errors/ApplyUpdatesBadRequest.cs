//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace LukeHagar.PlexAPI.SDK.Models.Errors
{
    using LukeHagar.PlexAPI.SDK.Models.Errors;
    using LukeHagar.PlexAPI.SDK.Utils;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    
    /// <summary>
    /// Bad Request - A parameter was not specified, or was specified incorrectly.
    /// </summary>
    public class ApplyUpdatesBadRequest : Exception
    {

        [JsonProperty("errors")]
        public List<ApplyUpdatesErrors>? Errors { get; set; }

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        [JsonProperty("-")]
        public HttpResponseMessage? RawResponse { get; set; }
    }
}