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
    
    public class GetActorsLibraryDirectory
    {

        /// <summary>
        /// A fast lookup key for the actor relative url.
        /// </summary>
        [JsonProperty("fastKey")]
        public string FastKey { get; set; } = default!;

        /// <summary>
        /// URL for the thumbnail image of the actor.
        /// </summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; } = default!;

        /// <summary>
        /// A unique key representing the actor.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The name of the actor.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = default!;
    }
}