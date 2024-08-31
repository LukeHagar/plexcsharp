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
    /// The auto-select subtitle mode (0 = Manually selected, 1 = Shown with foreign audio, 2 = Always enabled)
    /// </summary>
    public enum PostUsersSignInDataAutoSelectSubtitle
    {
        [JsonProperty("0")]
        Zero,
        [JsonProperty("1")]
        One,
    }

    public static class PostUsersSignInDataAutoSelectSubtitleExtension
    {
        public static string Value(this PostUsersSignInDataAutoSelectSubtitle value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PostUsersSignInDataAutoSelectSubtitle ToEnum(this string value)
        {
            foreach(var field in typeof(PostUsersSignInDataAutoSelectSubtitle).GetFields())
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

                    if (enumVal is PostUsersSignInDataAutoSelectSubtitle)
                    {
                        return (PostUsersSignInDataAutoSelectSubtitle)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PostUsersSignInDataAutoSelectSubtitle");
        }
    }

}