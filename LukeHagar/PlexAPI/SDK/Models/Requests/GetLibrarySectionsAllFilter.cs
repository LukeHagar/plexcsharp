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
    
    public class GetLibrarySectionsAllFilter
    {

        [JsonProperty("filter")]
        public string Filter { get; set; } = default!;

        [JsonProperty("filterType")]
        public string FilterType { get; set; } = default!;

        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("advanced")]
        public bool? Advanced { get; set; }
    }
}