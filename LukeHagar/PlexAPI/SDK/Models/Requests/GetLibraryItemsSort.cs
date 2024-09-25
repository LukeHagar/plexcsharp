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
    
    public class GetLibraryItemsSort
    {

        [JsonProperty("default")]
        public string? Default { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The direction of the sort. Can be either `asc` or `desc`.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("activeDirection")]
        public GetLibraryItemsActiveDirection? ActiveDirection { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.GetLibraryItemsActiveDirection.Ascending;

        /// <summary>
        /// The direction of the sort. Can be either `asc` or `desc`.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("defaultDirection")]
        public GetLibraryItemsDefaultDirection? DefaultDirection { get; set; } = LukeHagar.PlexAPI.SDK.Models.Requests.GetLibraryItemsDefaultDirection.Ascending;

        [JsonProperty("descKey")]
        public string? DescKey { get; set; }

        [JsonProperty("firstCharacterKey")]
        public string? FirstCharacterKey { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;
    }
}