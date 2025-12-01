<!-- Start SDK Example Usage [usage] -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

StartTranscodeSessionRequest req = new StartTranscodeSessionRequest() {
    TranscodeType = TranscodeType.Music,
    Extension = Extension.Mpd,
    AdvancedSubtitles = LukeHagar.PlexAPI.SDK.Models.Components.AdvancedSubtitles.Burn,
    AudioBoost = 50,
    AudioChannelCount = 5,
    AutoAdjustQuality = BoolInt.True,
    AutoAdjustSubtitle = BoolInt.True,
    DirectPlay = BoolInt.True,
    DirectStream = BoolInt.True,
    DirectStreamAudio = BoolInt.True,
    DisableResolutionRotation = BoolInt.True,
    HasMDE = BoolInt.True,
    Location = StartTranscodeSessionQueryParamLocation.Wan,
    MediaBufferSize = 102400,
    MediaIndex = 0,
    MusicBitrate = 5000,
    Offset = 90.5D,
    PartIndex = 0,
    Path = "/library/metadata/151671",
    PeakBitrate = 12000,
    PhotoResolution = "1080x1080",
    Protocol = StartTranscodeSessionQueryParamProtocol.Dash,
    SecondsPerSegment = 5,
    SubtitleSize = 50,
    VideoBitrate = 12000,
    VideoQuality = 50,
    VideoResolution = "1080x1080",
    XPlexClientProfileExtra = "add-limitation(scope=videoCodec&scopeName=*&type=upperBound&name=video.frameRate&value=60&replace=true)+append-transcode-target-codec(type=videoProfile&context=streaming&videoCodec=h264%2Chevc&audioCodec=aac&protocol=dash)",
    XPlexClientProfileName = "generic",
};

var res = await sdk.Transcoder.StartTranscodeSessionAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->