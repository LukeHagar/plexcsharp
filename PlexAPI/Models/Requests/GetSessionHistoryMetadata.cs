//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using Newtonsoft.Json;
    using NodaTime;
    using PlexAPI.Utils;
    
    public class GetSessionHistoryMetadata
    {

        [JsonProperty("historyKey")]
        public string? HistoryKey { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("ratingKey")]
        public string? RatingKey { get; set; }

        [JsonProperty("librarySectionID")]
        public string? LibrarySectionID { get; set; }

        [JsonProperty("parentKey")]
        public string? ParentKey { get; set; }

        [JsonProperty("grandparentKey")]
        public string? GrandparentKey { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("grandparentTitle")]
        public string? GrandparentTitle { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("parentThumb")]
        public string? ParentThumb { get; set; }

        [JsonProperty("grandparentThumb")]
        public string? GrandparentThumb { get; set; }

        [JsonProperty("grandparentArt")]
        public string? GrandparentArt { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("parentIndex")]
        public int? ParentIndex { get; set; }

        [JsonProperty("originallyAvailableAt")]
        public LocalDate? OriginallyAvailableAt { get; set; }

        [JsonProperty("viewedAt")]
        public int? ViewedAt { get; set; }

        [JsonProperty("accountID")]
        public int? AccountID { get; set; }

        [JsonProperty("deviceID")]
        public int? DeviceID { get; set; }
    }
}