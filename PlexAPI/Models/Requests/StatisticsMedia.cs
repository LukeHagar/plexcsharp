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
    using PlexAPI.Utils;
    
    public class StatisticsMedia
    {

        [JsonProperty("accountID")]
        public int? AccountID { get; set; }

        [JsonProperty("deviceID")]
        public int? DeviceID { get; set; }

        [JsonProperty("timespan")]
        public int? Timespan { get; set; }

        [JsonProperty("at")]
        public int? At { get; set; }

        [JsonProperty("metadataType")]
        public int? MetadataType { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }
    }
}