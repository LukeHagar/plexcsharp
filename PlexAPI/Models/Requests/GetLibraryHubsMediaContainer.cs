//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using Newtonsoft.Json;
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    
    public class GetLibraryHubsMediaContainer
    {

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("allowSync")]
        public bool? AllowSync { get; set; }

        [JsonProperty("identifier")]
        public string? Identifier { get; set; }

        [JsonProperty("librarySectionID")]
        public int? LibrarySectionID { get; set; }

        [JsonProperty("librarySectionTitle")]
        public string? LibrarySectionTitle { get; set; }

        [JsonProperty("librarySectionUUID")]
        public string? LibrarySectionUUID { get; set; }

        [JsonProperty("Hub")]
        public List<GetLibraryHubsHub>? Hub { get; set; }
    }
}