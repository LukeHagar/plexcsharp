
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// A key representing a specific tag within the section.
    /// </summary>
    public enum Tag
    {
        [JsonProperty("all")]
        All,
        [JsonProperty("unwatched")]
        Unwatched,
        [JsonProperty("newest")]
        Newest,
        [JsonProperty("recentlyAdded")]
        RecentlyAdded,
        [JsonProperty("recentlyViewed")]
        RecentlyViewed,
        [JsonProperty("onDeck")]
        OnDeck,
        [JsonProperty("collection")]
        Collection,
        [JsonProperty("edition")]
        Edition,
        [JsonProperty("genre")]
        Genre,
        [JsonProperty("year")]
        Year,
        [JsonProperty("decade")]
        Decade,
        [JsonProperty("director")]
        Director,
        [JsonProperty("actor")]
        Actor,
        [JsonProperty("country")]
        Country,
        [JsonProperty("contentRating")]
        ContentRating,
        [JsonProperty("rating")]
        Rating,
        [JsonProperty("resolution")]
        Resolution,
        [JsonProperty("firstCharacter")]
        FirstCharacter,
        [JsonProperty("folder")]
        Folder,
        [JsonProperty("search?type=1")]
        SearchTypeEqual1,
    }

    public static class TagExtension
    {
        public static string Value(this Tag value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Tag ToEnum(this string value)
        {
            foreach(var field in typeof(Tag).GetFields())
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

                    if (enumVal is Tag)
                    {
                        return (Tag)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Tag");
        }
    }

}