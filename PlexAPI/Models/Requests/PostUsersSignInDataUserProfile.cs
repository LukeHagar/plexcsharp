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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    
    public class PostUsersSignInDataUserProfile
    {

        /// <summary>
        /// If the account has automatically select audio and subtitle tracks enabled
        /// </summary>
        [JsonProperty("autoSelectAudio")]
        public bool? AutoSelectAudio { get; set; } = true;

        /// <summary>
        /// The preferred audio language for the account
        /// </summary>
        [JsonProperty("defaultAudioLanguage", NullValueHandling = NullValueHandling.Include)]
        public string? DefaultAudioLanguage { get; set; }

        /// <summary>
        /// The preferred subtitle language for the account
        /// </summary>
        [JsonProperty("defaultSubtitleLanguage", NullValueHandling = NullValueHandling.Include)]
        public string? DefaultSubtitleLanguage { get; set; }

        /// <summary>
        /// The auto-select subtitle mode (0 = Manually selected, 1 = Shown with foreign audio, 2 = Always enabled)
        /// </summary>
        [JsonProperty("autoSelectSubtitle")]
        public PostUsersSignInDataAutoSelectSubtitle? AutoSelectSubtitle { get; set; }

        /// <summary>
        /// The subtitles for the deaf or hard-of-hearing (SDH) searches mode (0 = Prefer non-SDH subtitles, 1 = Prefer SDH subtitles, 2 = Only show SDH subtitles, 3 = Only shown non-SDH subtitles)
        /// </summary>
        [JsonProperty("defaultSubtitleAccessibility")]
        public PostUsersSignInDataDefaultSubtitleAccessibility? DefaultSubtitleAccessibility { get; set; }

        /// <summary>
        /// The forced subtitles searches mode (0 = Prefer non-forced subtitles, 1 = Prefer forced subtitles, 2 = Only show forced subtitles, 3 = Only show non-forced subtitles)
        /// </summary>
        [JsonProperty("defaultSubtitleForced")]
        public PostUsersSignInDataDefaultSubtitleForced? DefaultSubtitleForced { get; set; }

        [JsonProperty("watchedIndicator")]
        public PostUsersSignInDataWatchedIndicator? WatchedIndicator { get; set; }

        [JsonProperty("mediaReviewsVisibility")]
        public PostUsersSignInDataMediaReviewsVisibility? MediaReviewsVisibility { get; set; }
    }
}