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
    
    public class Activity
    {

        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("cancellable")]
        public bool? Cancellable { get; set; }

        [JsonProperty("userID")]
        public double? UserID { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("subtitle")]
        public string? Subtitle { get; set; }

        [JsonProperty("progress")]
        public double? Progress { get; set; }

        [JsonProperty("Context")]
        public Context? Context { get; set; }
    }
}