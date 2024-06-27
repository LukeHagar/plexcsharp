# Activities
(*Activities*)

## Overview

Activities are awesome. They provide a way to monitor and control asynchronous operations on the server. In order to receive real-time updates for activities, a client would normally subscribe via either EventSource or Websocket endpoints.
Activities are associated with HTTP replies via a special `X-Plex-Activity` header which contains the UUID of the activity.
Activities are optional cancellable. If cancellable, they may be cancelled via the `DELETE` endpoint. Other details:
- They can contain a `progress` (from 0 to 100) marking the percent completion of the activity.
- They must contain an `type` which is used by clients to distinguish the specific activity.
- They may contain a `Context` object with attributes which associate the activity with various specific entities (items, libraries, etc.)
- The may contain a `Response` object which attributes which represent the result of the asynchronous operation.


### Available Operations

* [GetServerActivities](#getserveractivities) - Get Server Activities
* [CancelServerActivities](#cancelserveractivities) - Cancel Server Activities

## GetServerActivities

Get Server Activities

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman");

var res = await sdk.Activities.GetServerActivitiesAsync();

// handle response
```


### Response

**[GetServerActivitiesResponse](../../Models/Requests/GetServerActivitiesResponse.md)**
### Errors

| Error Object                                          | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| PlexAPI.Models.Errors.GetServerActivitiesResponseBody | 401                                                   | application/json                                      |
| PlexAPI.Models.Errors.SDKException                    | 4xx-5xx                                               | */*                                                   |

## CancelServerActivities

Cancel Server Activities

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman");

var res = await sdk.Activities.CancelServerActivitiesAsync(activityUUID: "25b71ed5-0f9d-461c-baa7-d404e9e10d3e");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `ActivityUUID`                       | *string*                             | :heavy_check_mark:                   | The UUID of the activity to cancel.  | 25b71ed5-0f9d-461c-baa7-d404e9e10d3e |


### Response

**[CancelServerActivitiesResponse](../../Models/Requests/CancelServerActivitiesResponse.md)**
### Errors

| Error Object                                             | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| PlexAPI.Models.Errors.CancelServerActivitiesResponseBody | 401                                                      | application/json                                         |
| PlexAPI.Models.Errors.SDKException                       | 4xx-5xx                                                  | */*                                                      |
