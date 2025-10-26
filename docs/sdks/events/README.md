# Events
(*Events*)

## Overview

The server can notify clients in real-time of a wide range of events, from library scanning, to preferences being modified, to changes to media, and many other things. This is also the mechanism by which activity progress is reported.

Two protocols for receiving the events are available: EventSource (also known as SSE), and WebSocket.


### Available Operations

* [GetNotifications](#getnotifications) - Connect to Eventsource
* [ConnectWebSocket](#connectwebsocket) - Connect to WebSocket

## GetNotifications

Connect to the event source to get a stream of events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getNotifications" method="get" path="/:/eventsource/notifications" -->
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

GetNotificationsRequest req = new GetNotificationsRequest() {};

var res = await sdk.Events.GetNotificationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetNotificationsRequest](../../Models/Requests/GetNotificationsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetNotificationsResponse](../../Models/Requests/GetNotificationsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ConnectWebSocket

Connect to the web socket to get a stream of events

### Example Usage

<!-- UsageSnippet language="csharp" operationID="connectWebSocket" method="get" path="/:/websocket/notifications" -->
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

ConnectWebSocketRequest req = new ConnectWebSocketRequest() {};

var res = await sdk.Events.ConnectWebSocketAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ConnectWebSocketRequest](../../Models/Requests/ConnectWebSocketRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ConnectWebSocketResponse](../../Models/Requests/ConnectWebSocketResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |