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
    
    public class Sort
    {

        [JsonProperty("default")]
        public string? Default { get; set; }

        [JsonProperty("defaultDirection")]
        public string? DefaultDirection { get; set; }

        [JsonProperty("descKey")]
        public string? DescKey { get; set; }

        [JsonProperty("firstCharacterKey")]
        public string? FirstCharacterKey { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }
    }
}