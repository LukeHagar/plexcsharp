
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
    
    public class Player
    {

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("machineIdentifier")]
        public string? MachineIdentifier { get; set; }

        [JsonProperty("model")]
        public string? Model { get; set; }

        [JsonProperty("platform")]
        public string? Platform { get; set; }

        [JsonProperty("platformVersion")]
        public string? PlatformVersion { get; set; }

        [JsonProperty("product")]
        public string? Product { get; set; }

        [JsonProperty("profile")]
        public string? Profile { get; set; }

        [JsonProperty("remotePublicAddress")]
        public string? RemotePublicAddress { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("local")]
        public bool? Local { get; set; }

        [JsonProperty("relayed")]
        public bool? Relayed { get; set; }

        [JsonProperty("secure")]
        public bool? Secure { get; set; }

        [JsonProperty("userID")]
        public int? UserID { get; set; }
    }
}