
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
    
    /// <summary>
    /// force overwriting of duplicate playlists. By default, a playlist file uploaded with the same path will overwrite the existing playlist. <br/>
    /// 
    /// <remarks>
    /// The `force` argument is used to disable overwriting. If the `force` argument is set to 0, a new playlist will be created suffixed with the date and time that the duplicate was uploaded.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum Force
    {
        Zero = 0,
        One = 1,
    }
}