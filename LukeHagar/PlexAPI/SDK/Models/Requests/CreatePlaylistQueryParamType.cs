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
    /// type of playlist to create
    /// </summary>
    public enum CreatePlaylistQueryParamType
    {
        [JsonProperty("audio")]
        Audio,
        [JsonProperty("video")]
        Video,
        [JsonProperty("photo")]
        Photo,
    }

    public static class CreatePlaylistQueryParamTypeExtension
    {
        public static string Value(this CreatePlaylistQueryParamType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CreatePlaylistQueryParamType ToEnum(this string value)
        {
            foreach(var field in typeof(CreatePlaylistQueryParamType).GetFields())
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

                    if (enumVal is CreatePlaylistQueryParamType)
                    {
                        return (CreatePlaylistQueryParamType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CreatePlaylistQueryParamType");
        }
    }

}