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
    using Newtonsoft.Json;
    
    public class Connections
    {

        [JsonProperty("protocol")]
        public string Protocol { get; set; } = default!;

        [JsonProperty("address")]
        public string Address { get; set; } = default!;

        [JsonProperty("port")]
        public double Port { get; set; } = default!;

        [JsonProperty("uri")]
        public string Uri { get; set; } = default!;

        [JsonProperty("local")]
        public bool Local { get; set; } = default!;

        [JsonProperty("relay")]
        public bool Relay { get; set; } = default!;

        [JsonProperty("IPv6")]
        public bool IPv6 { get; set; } = default!;
    }
}