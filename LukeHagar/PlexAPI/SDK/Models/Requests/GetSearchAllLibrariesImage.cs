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
    
    public class GetSearchAllLibrariesImage
    {

        [JsonProperty("alt")]
        public string Alt { get; set; } = default!;

        [JsonProperty("type")]
        public GetSearchAllLibrariesLibraryType Type { get; set; } = default!;

        [JsonProperty("url")]
        public string Url { get; set; } = default!;
    }
}