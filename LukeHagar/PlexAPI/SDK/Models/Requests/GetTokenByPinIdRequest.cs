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
    
    public class GetTokenByPinIdRequest
    {

        /// <summary>
        /// The PinID to retrieve an access token for
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=pinID")]
        public long PinID { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the client application<br/>
        /// 
        /// <remarks>
        /// This is used to track the client application and its usage<br/>
        /// (UUID, serial number, or other number unique per device)<br/>
        /// 
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Client-Identifier")]
        public string? ClientID { get; set; }
    }
}