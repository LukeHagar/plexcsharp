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
    using LukeHagar.PlexAPI.SDK.Models.Requests;
    using LukeHagar.PlexAPI.SDK.Utils;
    using Newtonsoft.Json;
    
    public class Connections
    {

        /// <summary>
        /// The protocol used for the connection (http, https, etc)
        /// </summary>
        [JsonProperty("protocol")]
        public Protocol Protocol { get; set; } = default!;

        /// <summary>
        /// The (ip) address or domain name used for the connection
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// The port used for the connection
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; } = default!;

        /// <summary>
        /// The full URI of the connection
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// If the connection is local address
        /// </summary>
        [JsonProperty("local")]
        public bool Local { get; set; } = default!;

        /// <summary>
        /// If the connection is relayed through plex.direct
        /// </summary>
        [JsonProperty("relay")]
        public bool Relay { get; set; } = default!;

        /// <summary>
        /// If the connection is using IPv6
        /// </summary>
        [JsonProperty("IPv6")]
        public bool IPv6 { get; set; } = default!;
    }
}