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
    
    public class GetAllMediaLibraryUltraBlurColors
    {

        [JsonProperty("topLeft")]
        public string TopLeft { get; set; } = default!;

        [JsonProperty("topRight")]
        public string TopRight { get; set; } = default!;

        [JsonProperty("bottomRight")]
        public string BottomRight { get; set; } = default!;

        [JsonProperty("bottomLeft")]
        public string BottomLeft { get; set; } = default!;
    }
}