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
    
    public class GetMediaMetaDataUltraBlurColors
    {

        /// <summary>
        /// The top-left color value.
        /// </summary>
        [JsonProperty("topLeft")]
        public string TopLeft { get; set; } = default!;

        /// <summary>
        /// The top-right color value.
        /// </summary>
        [JsonProperty("topRight")]
        public string TopRight { get; set; } = default!;

        /// <summary>
        /// The bottom-right color value.
        /// </summary>
        [JsonProperty("bottomRight")]
        public string BottomRight { get; set; } = default!;

        /// <summary>
        /// The bottom-left color value.
        /// </summary>
        [JsonProperty("bottomLeft")]
        public string BottomLeft { get; set; } = default!;
    }
}