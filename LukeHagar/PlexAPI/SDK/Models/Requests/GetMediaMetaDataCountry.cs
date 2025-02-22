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
    
    public class GetMediaMetaDataCountry
    {

        /// <summary>
        /// The unique country identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The filter string for the country.
        /// </summary>
        [JsonProperty("filter")]
        public string Filter { get; set; } = default!;

        /// <summary>
        /// The country name.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; } = default!;
    }
}