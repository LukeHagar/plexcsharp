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
    
    public class GetSessionsUser
    {

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }
    }
}