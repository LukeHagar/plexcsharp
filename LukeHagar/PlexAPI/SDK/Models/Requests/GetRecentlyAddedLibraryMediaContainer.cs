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
    using System.Collections.Generic;
    
    /// <summary>
    /// The Meta object is only included in the response if the `includeMeta` parameter is set to `1`.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class GetRecentlyAddedLibraryMediaContainer
    {

        [JsonProperty("Type")]
        public List<GetRecentlyAddedLibraryType>? Type { get; set; }

        [JsonProperty("FieldType")]
        public List<FieldType>? FieldType { get; set; }

        [JsonProperty("size")]
        public double? Size { get; set; }

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("identifier")]
        public string? Identifier { get; set; }

        [JsonProperty("mediaTagPrefix")]
        public string? MediaTagPrefix { get; set; }

        [JsonProperty("mediaTagVersion")]
        public double? MediaTagVersion { get; set; }

        [JsonProperty("mixedParents")]
        public bool? MixedParents { get; set; }

        [JsonProperty("Metadata")]
        public List<GetRecentlyAddedLibraryMetadata>? Metadata { get; set; }
    }
}