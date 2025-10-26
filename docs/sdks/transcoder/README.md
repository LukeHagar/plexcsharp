# Transcoder
(*Transcoder*)

## Overview

API Operations against the Transcoder

### Available Operations

* [TranscodeImage](#transcodeimage) - Transcode an image
* [MakeDecision](#makedecision) - Make a decision on media playback
* [TriggerFallback](#triggerfallback) - Manually trigger a transcoder fallback
* [TranscodeSubtitles](#transcodesubtitles) - Transcode subtitles
* [StartTranscodeSession](#starttranscodesession) - Start A Transcoding Session

## TranscodeImage

Transcode an image, possibly changing format or size

### Example Usage

<!-- UsageSnippet language="csharp" operationID="transcodeImage" method="get" path="/photo/:/transcode" -->
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

TranscodeImageRequest req = new TranscodeImageRequest() {
    Url = "/library/metadata/265/thumb/1715112705",
    Background = "#ff5522",
    Upscale = BoolInt.One,
    MinSize = BoolInt.One,
    Rotate = BoolInt.One,
    BlendColor = "#ff5522",
};

var res = await sdk.Transcoder.TranscodeImageAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [TranscodeImageRequest](../../Models/Requests/TranscodeImageRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[TranscodeImageResponse](../../Models/Requests/TranscodeImageResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## MakeDecision

Make a decision on media playback based on client profile, and requested settings such as bandwidth and resolution.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="makeDecision" method="get" path="/{transcodeType}/:/transcode/universal/decision" -->
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

MakeDecisionRequest req = new MakeDecisionRequest() {
    TranscodeType = TranscodeType.Music,
    AdvancedSubtitles = LukeHagar.PlexAPI.SDK.Models.Components.AdvancedSubtitles.Burn,
    AudioBoost = 50,
    AudioChannelCount = 5,
    AutoAdjustQuality = BoolInt.One,
    AutoAdjustSubtitle = BoolInt.One,
    DirectPlay = BoolInt.One,
    DirectStream = BoolInt.One,
    DirectStreamAudio = BoolInt.One,
    DisableResolutionRotation = BoolInt.One,
    HasMDE = BoolInt.One,
    Location = LukeHagar.PlexAPI.SDK.Models.Requests.Location.Wan,
    MediaBufferSize = 102400,
    MediaIndex = 0,
    MusicBitrate = 5000,
    Offset = 90.5D,
    PartIndex = 0,
    Path = "/library/metadata/151671",
    PeakBitrate = 12000,
    PhotoResolution = "1080x1080",
    Protocol = LukeHagar.PlexAPI.SDK.Models.Requests.Protocol.Dash,
    SecondsPerSegment = 5,
    SubtitleSize = 50,
    VideoBitrate = 12000,
    VideoQuality = 50,
    VideoResolution = "1080x1080",
    XPlexClientProfileExtra = "add-limitation(scope=videoCodec&scopeName=*&type=upperBound&name=video.frameRate&value=60&replace=true)+append-transcode-target-codec(type=videoProfile&context=streaming&videoCodec=h264%2Chevc&audioCodec=aac&protocol=dash)",
    XPlexClientProfileName = "generic",
};

var res = await sdk.Transcoder.MakeDecisionAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [MakeDecisionRequest](../../Models/Requests/MakeDecisionRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[MakeDecisionResponse](../../Models/Requests/MakeDecisionResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## TriggerFallback

Manually trigger a transcoder fallback ex: HEVC to h.264 or hw to sw

### Example Usage

<!-- UsageSnippet language="csharp" operationID="triggerFallback" method="post" path="/{transcodeType}/:/transcode/universal/fallback" -->
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

TriggerFallbackRequest req = new TriggerFallbackRequest() {
    TranscodeType = TranscodeType.Audio,
};

var res = await sdk.Transcoder.TriggerFallbackAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [TriggerFallbackRequest](../../Models/Requests/TriggerFallbackRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[TriggerFallbackResponse](../../Models/Requests/TriggerFallbackResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## TranscodeSubtitles

Only transcode subtitle streams.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="transcodeSubtitles" method="get" path="/{transcodeType}/:/transcode/universal/subtitles" -->
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

TranscodeSubtitlesRequest req = new TranscodeSubtitlesRequest() {
    TranscodeType = TranscodeType.Audio,
    AdvancedSubtitles = LukeHagar.PlexAPI.SDK.Models.Components.AdvancedSubtitles.Burn,
    AudioBoost = 50,
    AudioChannelCount = 5,
    AutoAdjustQuality = BoolInt.One,
    AutoAdjustSubtitle = BoolInt.One,
    DirectPlay = BoolInt.One,
    DirectStream = BoolInt.One,
    DirectStreamAudio = BoolInt.One,
    DisableResolutionRotation = BoolInt.One,
    HasMDE = BoolInt.One,
    Location = QueryParamLocation.Wan,
    MediaBufferSize = 102400,
    MediaIndex = 0,
    MusicBitrate = 5000,
    Offset = 90.5D,
    PartIndex = 0,
    Path = "/library/metadata/151671",
    PeakBitrate = 12000,
    PhotoResolution = "1080x1080",
    Protocol = QueryParamProtocol.Dash,
    SecondsPerSegment = 5,
    SubtitleSize = 50,
    VideoBitrate = 12000,
    VideoQuality = 50,
    VideoResolution = "1080x1080",
    XPlexClientProfileExtra = "add-limitation(scope=videoCodec&scopeName=*&type=upperBound&name=video.frameRate&value=60&replace=true)+append-transcode-target-codec(type=videoProfile&context=streaming&videoCodec=h264%2Chevc&audioCodec=aac&protocol=dash)",
    XPlexClientProfileName = "generic",
};

var res = await sdk.Transcoder.TranscodeSubtitlesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [TranscodeSubtitlesRequest](../../Models/Requests/TranscodeSubtitlesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[TranscodeSubtitlesResponse](../../Models/Requests/TranscodeSubtitlesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## StartTranscodeSession

Starts the transcoder and returns the corresponding streaming resource document.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="startTranscodeSession" method="get" path="/{transcodeType}/:/transcode/universal/start.{extension}" -->
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
    AutoAdjustQuality = BoolInt.One,
    AutoAdjustSubtitle = BoolInt.One,
    DirectPlay = BoolInt.One,
    DirectStream = BoolInt.One,
    DirectStreamAudio = BoolInt.One,
    DisableResolutionRotation = BoolInt.One,
    HasMDE = BoolInt.One,
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

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [StartTranscodeSessionRequest](../../Models/Requests/StartTranscodeSessionRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[StartTranscodeSessionResponse](../../Models/Requests/StartTranscodeSessionResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |