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
    
    public class Connections
    {

        [JsonProperty("protocol")]
        public string? Protocol { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("port")]
        public double? Port { get; set; }

        [JsonProperty("uri")]
        public string? Uri { get; set; }

        [JsonProperty("local")]
        public bool? Local { get; set; }

        [JsonProperty("relay")]
        public bool? Relay { get; set; }

        [JsonProperty("IPv6")]
        public bool? IPv6 { get; set; }
    }
}