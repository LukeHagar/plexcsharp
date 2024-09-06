# Video
(*Video*)

## Overview

API Calls that perform operations with Plex Media Server Videos


### Available Operations

* [GetTimeline](#gettimeline) - Get the timeline for a media item
* [StartUniversalTranscode](#startuniversaltranscode) - Start Universal Transcode

## GetTimeline

Get the timeline for a media item

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

GetTimelineRequest req = new GetTimelineRequest() {
    RatingKey = 23409D,
    Key = "/library/metadata/23409",
    State = PlexAPI.Models.Requests.State.Playing,
    HasMDE = 1D,
    Time = 2000D,
    Duration = 10000D,
    Context = "home:hub.continueWatching",
    PlayQueueItemID = 1D,
    PlayBackTime = 2000D,
    Row = 1D,
};

var res = await sdk.Video.GetTimelineAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetTimelineRequest](../../Models/Requests/GetTimelineRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetTimelineResponse](../../Models/Requests/GetTimelineResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| PlexAPI.Models.Errors.GetTimelineResponseBody | 401                                           | application/json                              |
| PlexAPI.Models.Errors.SDKException            | 4xx-5xx                                       | */*                                           |


## StartUniversalTranscode

Begin a Universal Transcode Session

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

StartUniversalTranscodeRequest req = new StartUniversalTranscodeRequest() {
    HasMDE = 1D,
    Path = "/library/metadata/23409",
    MediaIndex = 0D,
    PartIndex = 0D,
    Protocol = "hls",
    FastSeek = 0D,
    DirectPlay = 0D,
    DirectStream = 0D,
    SubtitleSize = 100D,
    Subtites = "burn",
    AudioBoost = 100D,
    Location = "lan",
    MediaBufferSize = 102400D,
    Session = "zvcage8b7rkioqcm8f4uns4c",
    AddDebugOverlay = 0D,
    AutoAdjustQuality = 0D,
};

var res = await sdk.Video.StartUniversalTranscodeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [StartUniversalTranscodeRequest](../../Models/Requests/StartUniversalTranscodeRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[StartUniversalTranscodeResponse](../../Models/Requests/StartUniversalTranscodeResponse.md)**

### Errors

| Error Object                                              | Status Code                                               | Content Type                                              |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| PlexAPI.Models.Errors.StartUniversalTranscodeResponseBody | 401                                                       | application/json                                          |
| PlexAPI.Models.Errors.SDKException                        | 4xx-5xx                                                   | */*                                                       |
