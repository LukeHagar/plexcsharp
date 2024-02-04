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

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Updater.GetUpdateStatusAsync();

// handle response
```


### Response

**[GetUpdateStatusResponse](../../Models/Requests/GetUpdateStatusResponse.md)**


## CheckForUpdates

Checking for updates

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Updater.CheckForUpdatesAsync(download: Download.One);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Download`                                                  | [Download](../../Models/Requests/Download.md)               | :heavy_minus_sign:                                          | Indicate that you want to start download any updates found. |


### Response

**[CheckForUpdatesResponse](../../Models/Requests/CheckForUpdatesResponse.md)**


## ApplyUpdates

Note that these two parameters are effectively mutually exclusive. The `tonight` parameter takes precedence and `skip` will be ignored if `tonight` is also passed


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Updater.ApplyUpdatesAsync(
    tonight: Tonight.One,
    skip: Skip.Zero);

// handle response
```

### Parameters

| Parameter                                                                                                                                                | Type                                                                                                                                                     | Required                                                                                                                                                 | Description                                                                                                                                              |
| -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Tonight`                                                                                                                                                | [Tonight](../../Models/Requests/Tonight.md)                                                                                                              | :heavy_minus_sign:                                                                                                                                       | Indicate that you want the update to run during the next Butler execution. Omitting this or setting it to false indicates that the update should install |
| `Skip`                                                                                                                                                   | [Skip](../../Models/Requests/Skip.md)                                                                                                                    | :heavy_minus_sign:                                                                                                                                       | Indicate that the latest version should be marked as skipped. The <Release> entry for this version will have the `state` set to `skipped`.               |


### Response

**[ApplyUpdatesResponse](../../Models/Requests/ApplyUpdatesResponse.md)**

