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
    
    public class GetSearchAllLibrariesMediaContainer
    {

        [JsonProperty("size")]
        public double Size { get; set; } = default!;

        [JsonProperty("SearchResult")]
        public List<SearchResult> SearchResult { get; set; } = default!;
    }
}