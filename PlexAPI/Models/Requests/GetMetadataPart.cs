
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
    
    public class GetMetadataPart
    {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("file")]
        public string? File { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("audioProfile")]
        public string? AudioProfile { get; set; }

        [JsonProperty("container")]
        public string? Container { get; set; }

        [JsonProperty("has64bitOffsets")]
        public bool? Has64bitOffsets { get; set; }

        [JsonProperty("optimizedForStreaming")]
        public bool? OptimizedForStreaming { get; set; }

        [JsonProperty("videoProfile")]
        public string? VideoProfile { get; set; }

        [JsonProperty("Stream")]
        public List<Stream>? Stream { get; set; }
    }
}