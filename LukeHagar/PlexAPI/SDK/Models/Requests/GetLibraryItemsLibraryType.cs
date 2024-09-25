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
    /// The type of media content<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum GetLibraryItemsLibraryType
    {
        [JsonProperty("movie")]
        Movie,
        [JsonProperty("show")]
        TvShow,
        [JsonProperty("season")]
        Season,
        [JsonProperty("episode")]
        Episode,
    }

    public static class GetLibraryItemsLibraryTypeExtension
    {
        public static string Value(this GetLibraryItemsLibraryType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetLibraryItemsLibraryType ToEnum(this string value)
        {
            foreach(var field in typeof(GetLibraryItemsLibraryType).GetFields())
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

                    if (enumVal is GetLibraryItemsLibraryType)
                    {
                        return (GetLibraryItemsLibraryType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetLibraryItemsLibraryType");
        }
    }

}