# PlayQueue

## Overview

The playqueue feature within a media provider
A play queue represents the current list of media for playback. Although queues are persisted by the server, they should be regarded by the user as a fairly lightweight, an ephemeral list of items queued up for playback in a session.  There is generally one active queue for each type of media (music, video, photos) that can be added to or destroyed and replaced with a fresh queue.
Play Queues has a region, which we refer to in this doc (partially for historical reasons) as "Up Next". This region is defined by `playQueueLastAddedItemID` existing on the media container. This follows iTunes' terminology. It is a special region after the currently playing item but before the originally-played items. This enables "Party Mode" listening/viewing, where items can be added on-the-fly, and normal queue playback resumed when completed. 
You can visualize the play queue as a sliding window in the complete list of media queued for playback. This model is important when scaling to larger play queues (e.g. shuffling 40,000 audio tracks). The client only needs visibility into small areas of the queue at any given time, and the server can optimize access in this fashion.
All created play queues will have an empty "Up Next" area - unless the item is an album and no `key` is provided. In this case the "Up Next" area will be populated by the contents of the album. This is to allow queueing of multiple albums - since the 'Add to Up Next' will insert after all the tracks. This means that If you're creating a PQ from an album, you can only shuffle it if you set `key`. This is due to the above implicit queueing of albums when no `key` is provided as well as the current limitation that you cannot shuffle a PQ with an "Up Next" area.
The play queue window advances as the server receives timeline requests. The client needs to retrieve the play queue as the “now playing” item changes. There is no play queue API to update the playing item.

### Available Operations

* [CreatePlayQueue](#createplayqueue) - Create a play queue
* [GetPlayQueue](#getplayqueue) - Retrieve a play queue
* [AddToPlayQueue](#addtoplayqueue) - Add a generator or playlist to a play queue
* [ClearPlayQueue](#clearplayqueue) - Clear a play queue
* [ResetPlayQueue](#resetplayqueue) - Reset a play queue
* [Shuffle](#shuffle) - Shuffle a play queue
* [Unshuffle](#unshuffle) - Unshuffle a play queue
* [DeletePlayQueueItem](#deleteplayqueueitem) - Delete an item from a play queue
* [MovePlayQueueItem](#moveplayqueueitem) - Move an item in a play queue

## CreatePlayQueue

Makes a new play queue for a device. The source of the playqueue can either be a URI, or a playlist. The response is a media container with the initial items in the queue. Each item in the queue will be a regular item but with `playQueueItemID` - a unique ID since the queue could have repeated items with the same `ratingKey`.
Note: Either `uri` or `playlistID` must be specified

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPlayQueue" method="post" path="/playQueues" -->
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

CreatePlayQueueRequest req = new CreatePlayQueueRequest() {
    Type = LukeHagar.PlexAPI.SDK.Models.Requests.Type.Audio,
    Shuffle = BoolInt.True,
    Repeat = BoolInt.True,
    Continuous = BoolInt.True,
    Recursive = BoolInt.True,
    OnDeck = BoolInt.True,
};

var res = await sdk.PlayQueue.CreatePlayQueueAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreatePlayQueueRequest](../../Models/Requests/CreatePlayQueueRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[CreatePlayQueueResponse](../../Models/Requests/CreatePlayQueueResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetPlayQueue

Retrieves the play queue, centered at current item. This can be treated as a regular container by play queue-oblivious clients, but they may wish to request a large window onto the queue since they won't know to refresh.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPlayQueue" method="get" path="/playQueues/{playQueueId}" -->
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

GetPlayQueueRequest req = new GetPlayQueueRequest() {
    PlayQueueId = 210646,
    Own = BoolInt.True,
    IncludeBefore = BoolInt.True,
    IncludeAfter = BoolInt.True,
};

var res = await sdk.PlayQueue.GetPlayQueueAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetPlayQueueRequest](../../Models/Requests/GetPlayQueueRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[GetPlayQueueResponse](../../Models/Requests/GetPlayQueueResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## AddToPlayQueue

Adds an item to a play queue (e.g. party mode). Increments the version of the play queue. Takes the following parameters (`uri` and `playlistID` are mutually exclusive). Returns the modified play queue.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addToPlayQueue" method="put" path="/playQueues/{playQueueId}" -->
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

AddToPlayQueueRequest req = new AddToPlayQueueRequest() {
    PlayQueueId = 919248,
    Next = BoolInt.True,
};

var res = await sdk.PlayQueue.AddToPlayQueueAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [AddToPlayQueueRequest](../../Models/Requests/AddToPlayQueueRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[AddToPlayQueueResponse](../../Models/Requests/AddToPlayQueueResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ClearPlayQueue

Deletes all items in the play queue, and increases the version of the play queue.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="clearPlayQueue" method="delete" path="/playQueues/{playQueueId}/items" -->
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

ClearPlayQueueRequest req = new ClearPlayQueueRequest() {
    PlayQueueId = 86357,
};

var res = await sdk.PlayQueue.ClearPlayQueueAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ClearPlayQueueRequest](../../Models/Requests/ClearPlayQueueRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ClearPlayQueueResponse](../../Models/Requests/ClearPlayQueueResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ResetPlayQueue

Reset a play queue to the first item being the current item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="resetPlayQueue" method="put" path="/playQueues/{playQueueId}/reset" -->
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

ResetPlayQueueRequest req = new ResetPlayQueueRequest() {
    PlayQueueId = 581891,
};

var res = await sdk.PlayQueue.ResetPlayQueueAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ResetPlayQueueRequest](../../Models/Requests/ResetPlayQueueRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ResetPlayQueueResponse](../../Models/Requests/ResetPlayQueueResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## Shuffle

Shuffle a play queue (or reshuffles if already shuffled). The currently selected item is maintained. Note that this is currently only supported for play queues *without* an Up Next area. Returns the modified play queue.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="shuffle" method="put" path="/playQueues/{playQueueId}/shuffle" -->
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

ShuffleRequest req = new ShuffleRequest() {
    PlayQueueId = 316150,
};

var res = await sdk.PlayQueue.ShuffleAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [ShuffleRequest](../../Models/Requests/ShuffleRequest.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[ShuffleResponse](../../Models/Requests/ShuffleResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## Unshuffle

Unshuffles a play queue and restores "natural order". Note that this is currently only supported for play queues *without* an Up Next area. Returns the modified play queue.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="unshuffle" method="put" path="/playQueues/{playQueueId}/unshuffle" -->
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

UnshuffleRequest req = new UnshuffleRequest() {
    PlayQueueId = 484388,
};

var res = await sdk.PlayQueue.UnshuffleAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [UnshuffleRequest](../../Models/Requests/UnshuffleRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[UnshuffleResponse](../../Models/Requests/UnshuffleResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeletePlayQueueItem

Deletes an item in a play queue. Increments the version of the play queue. Returns the modified play queue.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deletePlayQueueItem" method="delete" path="/playQueues/{playQueueId}/items/{playQueueItemId}" -->
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

DeletePlayQueueItemRequest req = new DeletePlayQueueItemRequest() {
    PlayQueueId = 285738,
    PlayQueueItemId = 464354,
};

var res = await sdk.PlayQueue.DeletePlayQueueItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [DeletePlayQueueItemRequest](../../Models/Requests/DeletePlayQueueItemRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[DeletePlayQueueItemResponse](../../Models/Requests/DeletePlayQueueItemResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## MovePlayQueueItem

Moves an item in a play queue, and increases the version of the play queue. Returns the modified play queue.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="movePlayQueueItem" method="put" path="/playQueues/{playQueueId}/items/{playQueueItemId}/move" -->
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

MovePlayQueueItemRequest req = new MovePlayQueueItemRequest() {
    PlayQueueId = 31341,
    PlayQueueItemId = 495865,
};

var res = await sdk.PlayQueue.MovePlayQueueItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [MovePlayQueueItemRequest](../../Models/Requests/MovePlayQueueItemRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[MovePlayQueueItemResponse](../../Models/Requests/MovePlayQueueItemResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |