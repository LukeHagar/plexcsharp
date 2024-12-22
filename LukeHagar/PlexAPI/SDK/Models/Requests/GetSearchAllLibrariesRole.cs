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
    
    public class GetSearchAllLibrariesRole
    {

        /// <summary>
        /// The ID of the tag or actor.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The filter used to find the actor or tag.
        /// </summary>
        [JsonProperty("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// The thumbnail of the actor
        /// </summary>
        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        /// <summary>
        /// The name of the tag or actor.
        /// </summary>
        [JsonProperty("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Unique identifier for the tag.
        /// </summary>
        [JsonProperty("tagKey")]
        public string? TagKey { get; set; }

        /// <summary>
        /// The role of the actor or tag in the media.
        /// </summary>
        [JsonProperty("role")]
        public string? Role { get; set; }
    }
}