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
    
    public class GetMediaMetaDataRatings
    {

        /// <summary>
        /// The image or reference for the rating.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; } = default!;

        /// <summary>
        /// The rating value.
        /// </summary>
        [JsonProperty("value")]
        public float Value { get; set; } = default!;

        /// <summary>
        /// The type of rating (e.g., audience, critic).
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = default!;
    }
}