# Updater
(*Updater*)

## Overview

This describes the API for searching and applying updates to the Plex Media Server.
Updates to the status can be observed via the Event API.


### Available Operations

* [ApplyUpdates](#applyupdates) - Applying updates
* [CheckUpdates](#checkupdates) - Checking for updates
* [GetUpdatesStatus](#getupdatesstatus) - Querying status of updates

## ApplyUpdates

Apply any downloaded updates.  Note that the two parameters `tonight` and `skip` are effectively mutually exclusive. The `tonight` parameter takes precedence and `skip` will be ignored if `tonight` is also passed.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="applyUpdates" method="put" path="/updater/apply" -->
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

ApplyUpdatesRequest req = new ApplyUpdatesRequest() {
    Tonight = BoolInt.One,
    Skip = BoolInt.One,
};

var res = await sdk.Updater.ApplyUpdatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ApplyUpdatesRequest](../../Models/Requests/ApplyUpdatesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ApplyUpdatesResponse](../../Models/Requests/ApplyUpdatesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## CheckUpdates

Perform an update check and potentially download

### Example Usage

<!-- UsageSnippet language="csharp" operationID="checkUpdates" method="put" path="/updater/check" -->
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

CheckUpdatesRequest req = new CheckUpdatesRequest() {
    Download = BoolInt.One,
};

var res = await sdk.Updater.CheckUpdatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [CheckUpdatesRequest](../../Models/Requests/CheckUpdatesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[CheckUpdatesResponse](../../Models/Requests/CheckUpdatesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetUpdatesStatus

Get the status of updating the server

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUpdatesStatus" method="get" path="/updater/status" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Updater.GetUpdatesStatusAsync();

// handle response
```

### Response

**[GetUpdatesStatusResponse](../../Models/Requests/GetUpdatesStatusResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |