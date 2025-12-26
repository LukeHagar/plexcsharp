# Activities

## Overview

Activities provide a way to monitor and control asynchronous operations on the server. In order to receive real-time updates for activities, a client would normally subscribe via either EventSource or Websocket endpoints.

Activities are associated with HTTP replies via a special `X-Plex-Activity` header which contains the UUID of the activity.

Activities are optional cancellable. If cancellable, they may be cancelled via the `DELETE` endpoint.


### Available Operations

* [ListActivities](#listactivities) - Get all activities
* [CancelActivity](#cancelactivity) - Cancel a running activity

## ListActivities

List all activities on the server.  Admins can see all activities but other users can only see their own

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listActivities" method="get" path="/activities" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Activities.ListActivitiesAsync();

// handle response
```

### Response

**[ListActivitiesResponse](../../Models/Requests/ListActivitiesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## CancelActivity

Cancel a running activity.  Admins can cancel all activities but other users can only cancel their own

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelActivity" method="delete" path="/activities/{activityId}" -->
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

CancelActivityRequest req = new CancelActivityRequest() {
    ActivityId = "d6199ba1-fb5e-4cae-bf17-1a5369c1cf1e",
};

var res = await sdk.Activities.CancelActivityAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CancelActivityRequest](../../Models/Requests/CancelActivityRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CancelActivityResponse](../../Models/Requests/CancelActivityResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |