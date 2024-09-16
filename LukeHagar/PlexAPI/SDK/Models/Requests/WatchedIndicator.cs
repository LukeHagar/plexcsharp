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
    
    public enum WatchedIndicator
    {
        [JsonProperty("0")]
        Zero,
        [JsonProperty("1")]
        One,
    }

    public static class WatchedIndicatorExtension
    {
        public static string Value(this WatchedIndicator value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static WatchedIndicator ToEnum(this string value)
        {
            foreach(var field in typeof(WatchedIndicator).GetFields())
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

                    if (enumVal is WatchedIndicator)
                    {
                        return (WatchedIndicator)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum WatchedIndicator");
        }
    }

}