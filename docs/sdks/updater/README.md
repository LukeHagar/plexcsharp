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

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Updater.GetUpdateStatusAsync();

// handle response
```

### Response

**[GetUpdateStatusResponse](../../Models/Requests/GetUpdateStatusResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| PlexAPI.Models.Errors.GetUpdateStatusResponseBody | 401                                               | application/json                                  |
| PlexAPI.Models.Errors.SDKException                | 4xx-5xx                                           | */*                                               |


## CheckForUpdates

Checking for updates

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Updater.CheckForUpdatesAsync(download: PlexAPI.Models.Requests.Download.One);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Download`                                                  | [Download](../../Models/Requests/Download.md)               | :heavy_minus_sign:                                          | Indicate that you want to start download any updates found. | 1                                                           |

### Response

**[CheckForUpdatesResponse](../../Models/Requests/CheckForUpdatesResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| PlexAPI.Models.Errors.CheckForUpdatesResponseBody | 401                                               | application/json                                  |
| PlexAPI.Models.Errors.SDKException                | 4xx-5xx                                           | */*                                               |


## ApplyUpdates

Note that these two parameters are effectively mutually exclusive. The `tonight` parameter takes precedence and `skip` will be ignored if `tonight` is also passed


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Updater.ApplyUpdatesAsync(
    tonight: PlexAPI.Models.Requests.Tonight.One,
    skip: PlexAPI.Models.Requests.Skip.One
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                | Type                                                                                                                                                     | Required                                                                                                                                                 | Description                                                                                                                                              | Example                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Tonight`                                                                                                                                                | [Tonight](../../Models/Requests/Tonight.md)                                                                                                              | :heavy_minus_sign:                                                                                                                                       | Indicate that you want the update to run during the next Butler execution. Omitting this or setting it to false indicates that the update should install | 1                                                                                                                                                        |
| `Skip`                                                                                                                                                   | [Skip](../../Models/Requests/Skip.md)                                                                                                                    | :heavy_minus_sign:                                                                                                                                       | Indicate that the latest version should be marked as skipped. The <Release> entry for this version will have the `state` set to `skipped`.               | 1                                                                                                                                                        |

### Response

**[ApplyUpdatesResponse](../../Models/Requests/ApplyUpdatesResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| PlexAPI.Models.Errors.ApplyUpdatesResponseBody | 401                                            | application/json                               |
| PlexAPI.Models.Errors.SDKException             | 4xx-5xx                                        | */*                                            |
