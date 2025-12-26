# Timeline

## Overview

The actions feature within a media provider

### Available Operations

* [MarkPlayed](#markplayed) - Mark an item as played
* [Report](#report) - Report media timeline
* [Unscrobble](#unscrobble) - Mark an item as unplayed

## MarkPlayed

Mark an item as played.  Note, this does not create any view history of this item but rather just sets the state as played. The client must provide either the `key` or `uri` query parameter
This API does respond to the GET verb but applications should use PUT

### Example Usage

<!-- UsageSnippet language="csharp" operationID="markPlayed" method="put" path="/:/scrobble" -->
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

MarkPlayedRequest req = new MarkPlayedRequest() {
    Identifier = "<value>",
    Key = "59398",
};

var res = await sdk.Timeline.MarkPlayedAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [MarkPlayedRequest](../../Models/Requests/MarkPlayedRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[MarkPlayedResponse](../../Models/Requests/MarkPlayedResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## Report

This endpoint is hit during media playback for an item. It must be hit whenever the play state changes, or in the absence of a play state change, in a regular fashion (generally this means every 10 seconds on a LAN/WAN, and every 20 seconds over cellular).


### Example Usage

<!-- UsageSnippet language="csharp" operationID="report" method="post" path="/:/timeline" -->
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

ReportRequest req = new ReportRequest() {
    Key = "/foo",
    RatingKey = "xyz",
    State = State.Playing,
    PlayQueueItemID = "123",
    Time = 0,
    Duration = 10000,
    Continuing = BoolInt.True,
    Updated = 14200000,
    Offline = BoolInt.True,
    TimeToFirstFrame = 1000,
    TimeStalled = 1000,
    Bandwidth = 100,
    BufferedTime = 100,
    BufferedSize = 1024,
};

var res = await sdk.Timeline.ReportAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [ReportRequest](../../Models/Requests/ReportRequest.md) | :heavy_check_mark:                                      | The request object to use for the request.              |

### Response

**[ReportResponse](../../Models/Requests/ReportResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## Unscrobble

Mark an item as unplayed. The client must provide either the `key` or `uri` query parameter
This API does respond to the GET verb but applications should use PUT

### Example Usage

<!-- UsageSnippet language="csharp" operationID="unscrobble" method="put" path="/:/unscrobble" -->
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

UnscrobbleRequest req = new UnscrobbleRequest() {
    Identifier = "<value>",
};

var res = await sdk.Timeline.UnscrobbleAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [UnscrobbleRequest](../../Models/Requests/UnscrobbleRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[UnscrobbleResponse](../../Models/Requests/UnscrobbleResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |