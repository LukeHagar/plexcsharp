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
    /// The direction of the sort. Can be either `asc` or `desc`.<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public enum GetLibraryItemsActiveDirection
    {
        [JsonProperty("asc")]
        Ascending,
        [JsonProperty("desc")]
        Descending,
    }

    public static class GetLibraryItemsActiveDirectionExtension
    {
        public static string Value(this GetLibraryItemsActiveDirection value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static GetLibraryItemsActiveDirection ToEnum(this string value)
        {
            foreach(var field in typeof(GetLibraryItemsActiveDirection).GetFields())
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

                    if (enumVal is GetLibraryItemsActiveDirection)
                    {
                        return (GetLibraryItemsActiveDirection)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum GetLibraryItemsActiveDirection");
        }
    }

}