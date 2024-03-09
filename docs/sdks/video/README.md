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
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(AccessToken: "<YOUR_API_KEY_HERE>");

GetTimelineRequest req = new GetTimelineRequest() {
    RatingKey = 716.56D,
    Key = "<key>",
    State = State.Paused,
    HasMDE = 7574.33D,
    Time = 3327.51D,
    Duration = 7585.39D,
    Context = "<value>",
    PlayQueueItemID = 1406.21D,
    PlayBackTime = 2699.34D,
    Row = 3536.42D,
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


## StartUniversalTranscode

Begin a Universal Transcode Session

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(AccessToken: "<YOUR_API_KEY_HERE>");

StartUniversalTranscodeRequest req = new StartUniversalTranscodeRequest() {
    HasMDE = 8924.99D,
    Path = "/etc/mail",
    MediaIndex = 9962.95D,
    PartIndex = 1232.82D,
    Protocol = "<value>",
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

