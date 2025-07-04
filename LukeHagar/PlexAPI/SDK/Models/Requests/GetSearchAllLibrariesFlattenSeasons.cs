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
    
    /// <summary>
    /// Setting that indicates if seasons are set to hidden for the show. (-1 = Library default, 0 = Hide, 1 = Show).<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum GetSearchAllLibrariesFlattenSeasons
    {
        [JsonProperty("-1")]
        LibraryDefault,
        [JsonProperty("0")]
        Hide,
        [JsonProperty("1")]
        Show,
    }

    public static class GetSearchAllLibrariesFlattenSeasonsExtension
    {
        public static string Value(this GetSearchAllLibrariesFlattenSeasons value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetSearchAllLibrariesFlattenSeasons ToEnum(this string value)
        {
            foreach(var field in typeof(GetSearchAllLibrariesFlattenSeasons).GetFields())
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

                    if (enumVal is GetSearchAllLibrariesFlattenSeasons)
                    {
                        return (GetSearchAllLibrariesFlattenSeasons)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetSearchAllLibrariesFlattenSeasons");
        }
    }

}