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
    
    public class GetLibraryDetailsField
    {

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("subType")]
        public string? SubType { get; set; }
    }
}