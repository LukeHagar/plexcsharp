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
    
    public class GetCountriesLibraryDirectory
    {

        [JsonProperty("fastKey")]
        public string FastKey { get; set; } = default!;

        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;
    }
}