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
    
    public class AddPlaylistContentsMediaContainer
    {

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("leafCountAdded")]
        public int? LeafCountAdded { get; set; }

        [JsonProperty("leafCountRequested")]
        public int? LeafCountRequested { get; set; }

        [JsonProperty("Metadata")]
        public List<AddPlaylistContentsMetadata>? Metadata { get; set; }
    }
}