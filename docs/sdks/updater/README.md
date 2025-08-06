# Updater
(*Updater*)

## Overview

This describes the API for searching and applying updates to the Plex Media Server.
Updates to the status can be observed via the Event API.


### Available Operations

* [GetUpdateStatus](#getupdatestatus) - Querying status of updates
* [CheckForUpdates](#checkforupdates) - Checking for updates
* [ApplyUpdates](#applyupdates) - Apply Updates

## GetUpdateStatus

Querying status of updates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUpdateStatus" method="get" path="/updater/status" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Updater.GetUpdateStatusAsync();

// handle response
```

### Response

**[GetUpdateStatusResponse](../../Models/Requests/GetUpdateStatusResponse.md)**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetUpdateStatusBadRequest   | 400                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetUpdateStatusUnauthorized | 401                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                | 4XX, 5XX                                                        | \*/\*                                                           |

## CheckForUpdates

Checking for updates

### Example Usage

<!-- UsageSnippet language="csharp" operationID="checkForUpdates" method="put" path="/updater/check" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Updater.CheckForUpdatesAsync(download: Download.One);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Download`                                                  | [Download](../../Models/Requests/Download.md)               | :heavy_minus_sign:                                          | Indicate that you want to start download any updates found. | 1                                                           |

### Response

**[CheckForUpdatesResponse](../../Models/Requests/CheckForUpdatesResponse.md)**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.CheckForUpdatesBadRequest   | 400                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.CheckForUpdatesUnauthorized | 401                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                | 4XX, 5XX                                                        | \*/\*                                                           |

## ApplyUpdates

Note that these two parameters are effectively mutually exclusive. The `tonight` parameter takes precedence and `skip` will be ignored if `tonight` is also passed


### Example Usage

<!-- UsageSnippet language="csharp" operationID="applyUpdates" method="put" path="/updater/apply" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Updater.ApplyUpdatesAsync(
    tonight: Tonight.One,
    skip: Skip.One
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                | Type                                                                                                                                                     | Required                                                                                                                                                 | Description                                                                                                                                              | Example                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Tonight`                                                                                                                                                | [Tonight](../../Models/Requests/Tonight.md)                                                                                                              | :heavy_minus_sign:                                                                                                                                       | Indicate that you want the update to run during the next Butler execution. Omitting this or setting it to false indicates that the update should install | 1                                                                                                                                                        |
| `Skip`                                                                                                                                                   | [Skip](../../Models/Requests/Skip.md)                                                                                                                    | :heavy_minus_sign:                                                                                                                                       | Indicate that the latest version should be marked as skipped. The [Release] entry for this version will have the `state` set to `skipped`.               | 1                                                                                                                                                        |

### Response

**[ApplyUpdatesResponse](../../Models/Requests/ApplyUpdatesResponse.md)**

### Errors

| Error Type                                                   | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.ApplyUpdatesBadRequest   | 400                                                          | application/json                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.ApplyUpdatesUnauthorized | 401                                                          | application/json                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException             | 4XX, 5XX                                                     | \*/\*                                                        |