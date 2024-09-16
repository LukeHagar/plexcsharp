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
    
    public class StartUniversalTranscodeRequest
    {

        /// <summary>
        /// Whether the media item has MDE
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=hasMDE")]
        public double HasMDE { get; set; } = default!;

        /// <summary>
        /// The path to the media item to transcode
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=path")]
        public string Path { get; set; } = default!;

        /// <summary>
        /// The index of the media item to transcode
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=mediaIndex")]
        public double MediaIndex { get; set; } = default!;

        /// <summary>
        /// The index of the part to transcode
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=partIndex")]
        public double PartIndex { get; set; } = default!;

        /// <summary>
        /// The protocol to use for the transcode session
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=protocol")]
        public string Protocol { get; set; } = default!;

        /// <summary>
        /// Whether to use fast seek or not
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=fastSeek")]
        public double? FastSeek { get; set; }

        /// <summary>
        /// Whether to use direct play or not
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=directPlay")]
        public double? DirectPlay { get; set; }

        /// <summary>
        /// Whether to use direct stream or not
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=directStream")]
        public double? DirectStream { get; set; }

        /// <summary>
        /// The size of the subtitles
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=subtitleSize")]
        public double? SubtitleSize { get; set; }

        /// <summary>
        /// The subtitles
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=subtites")]
        public string? Subtites { get; set; }

        /// <summary>
        /// The audio boost
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=audioBoost")]
        public double? AudioBoost { get; set; }

        /// <summary>
        /// The location of the transcode session
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=location")]
        public string? Location { get; set; }

        /// <summary>
        /// The size of the media buffer
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=mediaBufferSize")]
        public double? MediaBufferSize { get; set; }

        /// <summary>
        /// The session ID
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=session")]
        public string? Session { get; set; }

        /// <summary>
        /// Whether to add a debug overlay or not
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=addDebugOverlay")]
        public double? AddDebugOverlay { get; set; }

        /// <summary>
        /// Whether to auto adjust quality or not
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=autoAdjustQuality")]
        public double? AutoAdjustQuality { get; set; }
    }
}