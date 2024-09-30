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
        /// The unique identifier for the client application. This is used to track the client application and its usage. (UUID, serial number, or other number unique per device)
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Client-Identifier")]
        public string? ClientID { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Product")]
        public string? ClientName { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Device")]
        public string? DeviceName { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Version")]
        public string? ClientVersion { get; set; }

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=X-Plex-Platform")]
        public string? ClientPlatform { get; set; }
    }
}