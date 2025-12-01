# DownloadQueue
(*DownloadQueue*)

## Overview

API Operations against the Download Queue

### Available Operations

* [CreateDownloadQueue](#createdownloadqueue) - Create download queue
* [GetDownloadQueue](#getdownloadqueue) - Get a download queue
* [AddDownloadQueueItems](#adddownloadqueueitems) - Add to download queue
* [ListDownloadQueueItems](#listdownloadqueueitems) - Get download queue items
* [GetItemDecision](#getitemdecision) - Grab download queue item decision
* [GetDownloadQueueMedia](#getdownloadqueuemedia) - Grab download queue media
* [RemoveDownloadQueueItems](#removedownloadqueueitems) - Delete download queue items
* [GetDownloadQueueItems](#getdownloadqueueitems) - Get download queue items
* [RestartProcessingDownloadQueueItems](#restartprocessingdownloadqueueitems) - Restart processing of items from the decision

## CreateDownloadQueue

Available: 0.2.0

Creates a download queue for this client if one doesn't exist, or returns the existing queue for this client and user.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="createDownloadQueue" method="post" path="/downloadQueue" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.DownloadQueue.CreateDownloadQueueAsync();

// handle response
```

### Response

**[CreateDownloadQueueResponse](../../Models/Requests/CreateDownloadQueueResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetDownloadQueue

Available: 0.2.0

Get a download queue by its id


### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDownloadQueue" method="get" path="/downloadQueue/{queueId}" -->
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

GetDownloadQueueRequest req = new GetDownloadQueueRequest() {
    QueueId = 922802,
};

var res = await sdk.DownloadQueue.GetDownloadQueueAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetDownloadQueueRequest](../../Models/Requests/GetDownloadQueueRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetDownloadQueueResponse](../../Models/Requests/GetDownloadQueueResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## AddDownloadQueueItems

Available: 0.2.0

Add items to the download queue


### Example Usage

<!-- UsageSnippet language="csharp" operationID="addDownloadQueueItems" method="post" path="/downloadQueue/{queueId}/add" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

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

AddDownloadQueueItemsRequest req = new AddDownloadQueueItemsRequest() {
    QueueId = 984925,
    Keys = new List<string>() {
        "/library/metadata/3",
        "/library/metadata/6",
    },
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
    Location = LukeHagar.PlexAPI.SDK.Models.Components.Location.Wan,
    MediaBufferSize = 102400,
    MediaIndex = 0,
    MusicBitrate = 5000,
    Offset = 90.5D,
    PartIndex = 0,
    Path = "/library/metadata/151671",
    PeakBitrate = 12000,
    PhotoResolution = "1080x1080",
    Protocol = LukeHagar.PlexAPI.SDK.Models.Components.Protocol.Dash,
    SecondsPerSegment = 5,
    SubtitleSize = 50,
    VideoBitrate = 12000,
    VideoQuality = 50,
    VideoResolution = "1080x1080",
};

var res = await sdk.DownloadQueue.AddDownloadQueueItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [AddDownloadQueueItemsRequest](../../Models/Requests/AddDownloadQueueItemsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[AddDownloadQueueItemsResponse](../../Models/Requests/AddDownloadQueueItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ListDownloadQueueItems

Available: 0.2.0

Get items from a download queue


### Example Usage

<!-- UsageSnippet language="csharp" operationID="listDownloadQueueItems" method="get" path="/downloadQueue/{queueId}/items" -->
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

ListDownloadQueueItemsRequest req = new ListDownloadQueueItemsRequest() {
    QueueId = 524138,
};

var res = await sdk.DownloadQueue.ListDownloadQueueItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListDownloadQueueItemsRequest](../../Models/Requests/ListDownloadQueueItemsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListDownloadQueueItemsResponse](../../Models/Requests/ListDownloadQueueItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetItemDecision

Available: 0.2.0

Grab the decision for a download queue item


### Example Usage

<!-- UsageSnippet language="csharp" operationID="getItemDecision" method="get" path="/downloadQueue/{queueId}/item/{itemId}/decision" -->
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

GetItemDecisionRequest req = new GetItemDecisionRequest() {
    QueueId = 231605,
    ItemId = 32,
};

var res = await sdk.DownloadQueue.GetItemDecisionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetItemDecisionRequest](../../Models/Requests/GetItemDecisionRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetItemDecisionResponse](../../Models/Requests/GetItemDecisionResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetDownloadQueueMedia

Available: 0.2.0

Grab the media for a download queue item


### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDownloadQueueMedia" method="get" path="/downloadQueue/{queueId}/item/{itemId}/media" -->
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

GetDownloadQueueMediaRequest req = new GetDownloadQueueMediaRequest() {
    QueueId = 663184,
    ItemId = 32,
};

var res = await sdk.DownloadQueue.GetDownloadQueueMediaAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetDownloadQueueMediaRequest](../../Models/Requests/GetDownloadQueueMediaRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetDownloadQueueMediaResponse](../../Models/Requests/GetDownloadQueueMediaResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## RemoveDownloadQueueItems

delete items from a download queue

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeDownloadQueueItems" method="delete" path="/downloadQueue/{queueId}/items/{itemId}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

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

RemoveDownloadQueueItemsRequest req = new RemoveDownloadQueueItemsRequest() {
    QueueId = 946275,
    ItemId = new List<long>() {
        32,
        345,
        23,
    },
};

var res = await sdk.DownloadQueue.RemoveDownloadQueueItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [RemoveDownloadQueueItemsRequest](../../Models/Requests/RemoveDownloadQueueItemsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[RemoveDownloadQueueItemsResponse](../../Models/Requests/RemoveDownloadQueueItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetDownloadQueueItems

Available: 0.2.0

Get items from a download queue


### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDownloadQueueItems" method="get" path="/downloadQueue/{queueId}/items/{itemId}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

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

GetDownloadQueueItemsRequest req = new GetDownloadQueueItemsRequest() {
    QueueId = 809886,
    ItemId = new List<long>() {
        32,
        345,
        23,
    },
};

var res = await sdk.DownloadQueue.GetDownloadQueueItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetDownloadQueueItemsRequest](../../Models/Requests/GetDownloadQueueItemsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetDownloadQueueItemsResponse](../../Models/Requests/GetDownloadQueueItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## RestartProcessingDownloadQueueItems

Available: 0.2.0

Reprocess download queue items with previous decision parameters


### Example Usage

<!-- UsageSnippet language="csharp" operationID="restartProcessingDownloadQueueItems" method="post" path="/downloadQueue/{queueId}/items/{itemId}/restart" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

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

RestartProcessingDownloadQueueItemsRequest req = new RestartProcessingDownloadQueueItemsRequest() {
    QueueId = 713001,
    ItemId = new List<long>() {
        32,
        345,
        23,
    },
};

var res = await sdk.DownloadQueue.RestartProcessingDownloadQueueItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [RestartProcessingDownloadQueueItemsRequest](../../Models/Requests/RestartProcessingDownloadQueueItemsRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[RestartProcessingDownloadQueueItemsResponse](../../Models/Requests/RestartProcessingDownloadQueueItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |