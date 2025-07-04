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
    
    public class GetLibraryItemsRole
    {

        /// <summary>
        /// The unique identifier for the role.<br/>
        /// 
        /// <remarks>
        /// NOTE: This is different for each Plex server and is not globally unique.<br/>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The display tag for the actor (typically the actor&apos;s name).
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; } = default!;

        /// <summary>
        /// The role played by the actor in the media item.
        /// </summary>
        [JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The absolute URL of the thumbnail image for the actor.
        /// </summary>
        [JsonProperty("thumb")]
        public string? Thumb { get; set; }
    }
}