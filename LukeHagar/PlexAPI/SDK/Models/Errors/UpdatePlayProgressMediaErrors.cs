//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace LukeHagar.PlexAPI.SDK.Models.Errors
{
    using LukeHagar.PlexAPI.SDK.Utils;
    using Newtonsoft.Json;
    
    public class UpdatePlayProgressMediaErrors
    {

        [JsonProperty("code")]
        public long? Code { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("status")]
        public long? Status { get; set; }
    }
}