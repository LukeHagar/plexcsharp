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
    
    public class GetAllMediaLibraryStream
    {

        /// <summary>
        /// Unique stream identifier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Stream type (1=video, 2=audio, 3=subtitle).
        /// </summary>
        [JsonProperty("streamType")]
        public int StreamType { get; set; } = default!;

        /// <summary>
        /// Indicates if this stream is default.
        /// </summary>
        [JsonProperty("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Codec used by the stream.
        /// </summary>
        [JsonProperty("codec")]
        public string Codec { get; set; } = default!;

        /// <summary>
        /// Index of the stream.
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Bitrate of the stream.
        /// </summary>
        [JsonProperty("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Language of the stream.
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Language tag (e.g., en).
        /// </summary>
        [JsonProperty("languageTag")]
        public string? LanguageTag { get; set; }

        /// <summary>
        /// ISO language code.
        /// </summary>
        [JsonProperty("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Indicates whether header compression is enabled.
        /// </summary>
        [JsonProperty("headerCompression")]
        public bool? HeaderCompression { get; set; }

        /// <summary>
        /// Dolby Vision BL compatibility ID.
        /// </summary>
        [JsonProperty("DOVIBLCompatID")]
        public int? DOVIBLCompatID { get; set; }

        /// <summary>
        /// Indicates if Dolby Vision BL is present.
        /// </summary>
        [JsonProperty("DOVIBLPresent")]
        public bool? DOVIBLPresent { get; set; }

        /// <summary>
        /// Indicates if Dolby Vision EL is present.
        /// </summary>
        [JsonProperty("DOVIELPresent")]
        public bool? DOVIELPresent { get; set; }

        /// <summary>
        /// Dolby Vision level.
        /// </summary>
        [JsonProperty("DOVILevel")]
        public int? DOVILevel { get; set; }

        /// <summary>
        /// Indicates if Dolby Vision is present.
        /// </summary>
        [JsonProperty("DOVIPresent")]
        public bool? DOVIPresent { get; set; }

        /// <summary>
        /// Dolby Vision profile.
        /// </summary>
        [JsonProperty("DOVIProfile")]
        public int? DOVIProfile { get; set; }

        /// <summary>
        /// Indicates if Dolby Vision RPU is present.
        /// </summary>
        [JsonProperty("DOVIRPUPresent")]
        public bool? DOVIRPUPresent { get; set; }

        /// <summary>
        /// Dolby Vision version.
        /// </summary>
        [JsonProperty("DOVIVersion")]
        public string? DOVIVersion { get; set; }

        /// <summary>
        /// Bit depth of the video stream.
        /// </summary>
        [JsonProperty("bitDepth")]
        public int? BitDepth { get; set; }

        /// <summary>
        /// Chroma sample location.
        /// </summary>
        [JsonProperty("chromaLocation")]
        public string? ChromaLocation { get; set; }

        /// <summary>
        /// Chroma subsampling format.
        /// </summary>
        [JsonProperty("chromaSubsampling")]
        public string? ChromaSubsampling { get; set; }

        /// <summary>
        /// Coded video height.
        /// </summary>
        [JsonProperty("codedHeight")]
        public int? CodedHeight { get; set; }

        /// <summary>
        /// Coded video width.
        /// </summary>
        [JsonProperty("codedWidth")]
        public int? CodedWidth { get; set; }

        [JsonProperty("closedCaptions")]
        public bool? ClosedCaptions { get; set; }

        /// <summary>
        /// Color primaries used.
        /// </summary>
        [JsonProperty("colorPrimaries")]
        public string? ColorPrimaries { get; set; }

        /// <summary>
        /// Color range (e.g., tv).
        /// </summary>
        [JsonProperty("colorRange")]
        public string? ColorRange { get; set; }

        /// <summary>
        /// Color space.
        /// </summary>
        [JsonProperty("colorSpace")]
        public string? ColorSpace { get; set; }

        /// <summary>
        /// Color transfer characteristics.
        /// </summary>
        [JsonProperty("colorTrc")]
        public string? ColorTrc { get; set; }

        /// <summary>
        /// Frame rate of the stream.
        /// </summary>
        [JsonProperty("frameRate")]
        public float? FrameRate { get; set; }

        /// <summary>
        /// Height of the video stream.
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Video level.
        /// </summary>
        [JsonProperty("level")]
        public int? Level { get; set; }

        /// <summary>
        /// Indicates if this is the original stream.
        /// </summary>
        [JsonProperty("original")]
        public bool? Original { get; set; }

        [JsonProperty("hasScalingMatrix")]
        public bool? HasScalingMatrix { get; set; }

        /// <summary>
        /// Video profile.
        /// </summary>
        [JsonProperty("profile")]
        public string? Profile { get; set; }

        [JsonProperty("scanType")]
        public string? ScanType { get; set; }

        [JsonProperty("embeddedInVideo")]
        public string? EmbeddedInVideo { get; set; }

        /// <summary>
        /// Number of reference frames.
        /// </summary>
        [JsonProperty("refFrames")]
        public int? RefFrames { get; set; }

        /// <summary>
        /// Width of the video stream.
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Display title for the stream.
        /// </summary>
        [JsonProperty("displayTitle")]
        public string DisplayTitle { get; set; } = default!;

        /// <summary>
        /// Extended display title for the stream.
        /// </summary>
        [JsonProperty("extendedDisplayTitle")]
        public string ExtendedDisplayTitle { get; set; } = default!;

        /// <summary>
        /// Indicates if this stream is selected (applicable for audio streams).
        /// </summary>
        [JsonProperty("selected")]
        public bool? Selected { get; set; }

        [JsonProperty("forced")]
        public bool? Forced { get; set; }

        /// <summary>
        /// Number of audio channels (for audio streams).
        /// </summary>
        [JsonProperty("channels")]
        public int? Channels { get; set; }

        /// <summary>
        /// Audio channel layout.
        /// </summary>
        [JsonProperty("audioChannelLayout")]
        public string? AudioChannelLayout { get; set; }

        /// <summary>
        /// Sampling rate for the audio stream.
        /// </summary>
        [JsonProperty("samplingRate")]
        public int? SamplingRate { get; set; }

        /// <summary>
        /// Indicates if the stream can auto-sync.
        /// </summary>
        [JsonProperty("canAutoSync")]
        public bool? CanAutoSync { get; set; }

        /// <summary>
        /// Indicates if the stream is for the hearing impaired.
        /// </summary>
        [JsonProperty("hearingImpaired")]
        public bool? HearingImpaired { get; set; }

        /// <summary>
        /// Indicates if the stream is a dub.
        /// </summary>
        [JsonProperty("dub")]
        public bool? Dub { get; set; }

        /// <summary>
        /// Optional title for the stream (e.g., language variant).
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
    }
}