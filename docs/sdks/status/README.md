# Status
(*Status*)

## Overview

The status endpoints give you information about current playbacks, play history, and even terminating sessions.

### Available Operations

* [ListSessions](#listsessions) - List Sessions
* [GetBackgroundTasks](#getbackgroundtasks) - Get background tasks
* [ListPlaybackHistory](#listplaybackhistory) - List Playback History
* [TerminateSession](#terminatesession) - Terminate a session
* [DeleteHistory](#deletehistory) - Delete Single History Item
* [GetHistoryItem](#gethistoryitem) - Get Single History Item

## ListSessions

List all current playbacks on this server

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSessions" method="get" path="/status/sessions" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Status.ListSessionsAsync();

// handle response
```

### Response

**[ListSessionsResponse](../../Models/Requests/ListSessionsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetBackgroundTasks

Get the list of all background tasks

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getBackgroundTasks" method="get" path="/status/sessions/background" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Status.GetBackgroundTasksAsync();

// handle response
```

### Response

**[GetBackgroundTasksResponse](../../Models/Requests/GetBackgroundTasksResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ListPlaybackHistory

List all playback history (Admin can see all users, others can only see their own).
Pagination should be used on this endpoint.  Additionally this endpoint supports `includeFields`, `excludeFields`, `includeElements`, and `excludeElements` parameters.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPlaybackHistory" method="get" path="/status/sessions/history/all" -->
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

ListPlaybackHistoryRequest req = new ListPlaybackHistoryRequest() {
    Sort = new List<string>() {
        "v",
        "i",
        "e",
        "w",
        "e",
        "d",
        "A",
        "t",
        ":",
        "d",
        "e",
        "s",
        "c",
        ",",
        "a",
        "c",
        "c",
        "o",
        "u",
        "n",
        "t",
        "I",
        "D",
    },
};

var res = await sdk.Status.ListPlaybackHistoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListPlaybackHistoryRequest](../../Models/Requests/ListPlaybackHistoryRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListPlaybackHistoryResponse](../../Models/Requests/ListPlaybackHistoryResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## TerminateSession

Terminate a playback session kicking off the user

### Example Usage

<!-- UsageSnippet language="csharp" operationID="terminateSession" method="post" path="/status/sessions/terminate" -->
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

TerminateSessionRequest req = new TerminateSessionRequest() {
    SessionId = "cdefghijklmnopqrstuvwxyz",
    Reason = "Stop Playing",
};

var res = await sdk.Status.TerminateSessionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [TerminateSessionRequest](../../Models/Requests/TerminateSessionRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[TerminateSessionResponse](../../Models/Requests/TerminateSessionResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeleteHistory

Delete a single history item by id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteHistory" method="delete" path="/status/sessions/history/{historyId}" -->
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

DeleteHistoryRequest req = new DeleteHistoryRequest() {
    HistoryId = 953579,
};

var res = await sdk.Status.DeleteHistoryAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [DeleteHistoryRequest](../../Models/Requests/DeleteHistoryRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[DeleteHistoryResponse](../../Models/Requests/DeleteHistoryResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetHistoryItem

Get a single history item by id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHistoryItem" method="get" path="/status/sessions/history/{historyId}" -->
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

GetHistoryItemRequest req = new GetHistoryItemRequest() {
    HistoryId = 832213,
};

var res = await sdk.Status.GetHistoryItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetHistoryItemRequest](../../Models/Requests/GetHistoryItemRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetHistoryItemResponse](../../Models/Requests/GetHistoryItemResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |