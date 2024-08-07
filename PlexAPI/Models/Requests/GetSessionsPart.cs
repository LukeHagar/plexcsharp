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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    
    public class GetSessionsPart
    {

        [JsonProperty("container")]
        public string? Container { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("file")]
        public string? File { get; set; }

        [JsonProperty("hasThumbnail")]
        public string? HasThumbnail { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("decision")]
        public string? Decision { get; set; }

        [JsonProperty("selected")]
        public bool? Selected { get; set; }

        [JsonProperty("Stream")]
        public List<GetSessionsStream>? Stream { get; set; }
    }
}