//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using Newtonsoft.Json;
    using PlexAPI.Utils;
    
    public class GetMetadataDirector
    {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("filter")]
        public string? Filter { get; set; }

        [JsonProperty("tag")]
        public string? Tag { get; set; }

        [JsonProperty("tagKey")]
        public string? TagKey { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }
    }
}