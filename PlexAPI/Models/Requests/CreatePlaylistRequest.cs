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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    
    public class CreatePlaylistRequest
    {

        /// <summary>
        /// name of the playlist
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// type of playlist to create
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=type")]
        public QueryParamType Type { get; set; } = default!;

        /// <summary>
        /// whether the playlist is smart or not
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=smart")]
        public Smart Smart { get; set; } = default!;

        /// <summary>
        /// the content URI for the playlist
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=uri")]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// the play queue to copy to a playlist
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=playQueueID")]
        public double? PlayQueueID { get; set; }
    }
}