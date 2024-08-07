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
    using PlexAPI.Utils;
    
    public class Server
    {

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("host")]
        public string? Host { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("port")]
        public double? Port { get; set; }

        [JsonProperty("machineIdentifier")]
        public string? MachineIdentifier { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("protocol")]
        public string? Protocol { get; set; }

        [JsonProperty("product")]
        public string? Product { get; set; }

        [JsonProperty("deviceClass")]
        public string? DeviceClass { get; set; }

        [JsonProperty("protocolVersion")]
        public double? ProtocolVersion { get; set; }

        [JsonProperty("protocolCapabilities")]
        public string? ProtocolCapabilities { get; set; }
    }
}