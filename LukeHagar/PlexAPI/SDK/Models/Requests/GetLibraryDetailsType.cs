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
    using System.Collections.Generic;
    
    public class GetLibraryDetailsType
    {

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("Filter")]
        public List<GetLibraryDetailsFilter>? Filter { get; set; }

        [JsonProperty("Sort")]
        public List<GetLibraryDetailsSort>? Sort { get; set; }

        [JsonProperty("Field")]
        public List<GetLibraryDetailsField>? Field { get; set; }
    }
}