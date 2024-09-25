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
    using System;
    
    public enum GetRecentlyAddedHubsResponseType
    {
        [JsonProperty("coverPoster")]
        CoverPoster,
        [JsonProperty("background")]
        Background,
        [JsonProperty("snapshot")]
        Snapshot,
        [JsonProperty("clearLogo")]
        ClearLogo,
    }

    public static class GetRecentlyAddedHubsResponseTypeExtension
    {
        public static string Value(this GetRecentlyAddedHubsResponseType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetRecentlyAddedHubsResponseType ToEnum(this string value)
        {
            foreach(var field in typeof(GetRecentlyAddedHubsResponseType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is GetRecentlyAddedHubsResponseType)
                    {
                        return (GetRecentlyAddedHubsResponseType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetRecentlyAddedHubsResponseType");
        }
    }

}