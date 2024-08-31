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
    /// String representation of subscriptionActive
    /// </summary>
    public enum PostUsersSignInDataAuthenticationStatus
    {
        [JsonProperty("Inactive")]
        Inactive,
        [JsonProperty("Active")]
        Active,
    }

    public static class PostUsersSignInDataAuthenticationStatusExtension
    {
        public static string Value(this PostUsersSignInDataAuthenticationStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PostUsersSignInDataAuthenticationStatus ToEnum(this string value)
        {
            foreach(var field in typeof(PostUsersSignInDataAuthenticationStatus).GetFields())
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

                    if (enumVal is PostUsersSignInDataAuthenticationStatus)
                    {
                        return (PostUsersSignInDataAuthenticationStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PostUsersSignInDataAuthenticationStatus");
        }
    }

}