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
    using PlexAPI.Utils;
    using System;
    
    /// <summary>
    /// The subtitles for the deaf or hard-of-hearing (SDH) searches mode (0 = Prefer non-SDH subtitles, 1 = Prefer SDH subtitles, 2 = Only show SDH subtitles, 3 = Only shown non-SDH subtitles)
    /// </summary>
    public enum DefaultSubtitleAccessibility
    {
        [JsonProperty("0")]
        Zero,
        [JsonProperty("1")]
        One,
    }

    public static class DefaultSubtitleAccessibilityExtension
    {
        public static string Value(this DefaultSubtitleAccessibility value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static DefaultSubtitleAccessibility ToEnum(this string value)
        {
            foreach(var field in typeof(DefaultSubtitleAccessibility).GetFields())
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

                    if (enumVal is DefaultSubtitleAccessibility)
                    {
                        return (DefaultSubtitleAccessibility)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum DefaultSubtitleAccessibility");
        }
    }

}