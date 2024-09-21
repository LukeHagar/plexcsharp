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
    
    public class GetLibraryItemsLibraryType
    {

        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("active")]
        public bool Active { get; set; } = default!;

        [JsonProperty("Filter")]
        public List<GetLibraryItemsFilter>? Filter { get; set; }

        [JsonProperty("Sort")]
        public List<GetLibraryItemsSort>? Sort { get; set; }

        [JsonProperty("Field")]
        public List<GetLibraryItemsField>? Field { get; set; }
    }
}