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
    
    /// <summary>
    /// The type of media to retrieve or filter by.<br/>
    /// 
    /// <remarks>
    /// 1 = movie<br/>
    /// 2 = show<br/>
    /// 3 = season<br/>
    /// 4 = episode<br/>
    /// E.g. A movie library will not return anything with type 3 as there are no seasons for movie libraries<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum GetPlaylistContentsQueryParamType
    {
        Movie = 1,
        TvShow = 2,
        Season = 3,
        Episode = 4,
        Artist = 5,
        Album = 6,
        Track = 7,
        PhotoAlbum = 8,
        Photo = 9,
    }

}