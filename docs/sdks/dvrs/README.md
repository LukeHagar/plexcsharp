# DVRs
(*DVRs*)

## Overview

The DVR provides means to watch and record live TV.  This section of endpoints describes how to setup the DVR itself


### Available Operations

* [ListDVRs](#listdvrs) - Get DVRs
* [CreateDVR](#createdvr) - Create a DVR
* [DeleteDVR](#deletedvr) - Delete a single DVR
* [GetDVR](#getdvr) - Get a single DVR
* [DeleteLineup](#deletelineup) - Delete a DVR Lineup
* [AddLineup](#addlineup) - Add a DVR Lineup
* [SetDVRPreferences](#setdvrpreferences) - Set DVR preferences
* [StopDVRReload](#stopdvrreload) - Tell a DVR to stop reloading program guide
* [ReloadGuide](#reloadguide) - Tell a DVR to reload program guide
* [TuneChannel](#tunechannel) - Tune a channel on a DVR
* [RemoveDeviceFromDVR](#removedevicefromdvr) - Remove a device from an existing DVR
* [AddDeviceToDVR](#adddevicetodvr) - Add a device to an existing DVR

## ListDVRs

Get the list of all available DVRs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listDVRs" method="get" path="/livetv/dvrs" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.DVRs.ListDVRsAsync();

// handle response
```

### Response

**[ListDVRsResponse](../../Models/Requests/ListDVRsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## CreateDVR

Creation of a DVR, after creation of a devcie and a lineup is selected

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createDVR" method="post" path="/livetv/dvrs" -->
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

CreateDVRRequest req = new CreateDVRRequest() {
    Lineup = "lineup://tv.plex.providers.epg.onconnect/USA-HI51418-DEFAULT",
    DeviceQueryParameter = new List<string>() {
        "d",
        "e",
        "v",
        "i",
        "c",
        "e",
        "[",
        "]",
        "=",
        "d",
        "e",
        "v",
        "i",
        "c",
        "e",
        ":",
        "/",
        "/",
        "t",
        "v",
        ".",
        "p",
        "l",
        "e",
        "x",
        ".",
        "g",
        "r",
        "a",
        "b",
        "b",
        "e",
        "r",
        "s",
        ".",
        "h",
        "d",
        "h",
        "o",
        "m",
        "e",
        "r",
        "u",
        "n",
        "/",
        "1",
        "0",
        "5",
        "3",
        "C",
        "0",
        "C",
        "A",
    },
    Language = "eng",
};

var res = await sdk.DVRs.CreateDVRAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [CreateDVRRequest](../../Models/Requests/CreateDVRRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[CreateDVRResponse](../../Models/Requests/CreateDVRResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeleteDVR

Delete a single DVR by its id (key)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteDVR" method="delete" path="/livetv/dvrs/{dvrId}" -->
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

DeleteDVRRequest req = new DeleteDVRRequest() {
    DvrId = 855088,
};

var res = await sdk.DVRs.DeleteDVRAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [DeleteDVRRequest](../../Models/Requests/DeleteDVRRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[DeleteDVRResponse](../../Models/Requests/DeleteDVRResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetDVR

Get a single DVR by its id (key)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDVR" method="get" path="/livetv/dvrs/{dvrId}" -->
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

GetDVRRequest req = new GetDVRRequest() {
    DvrId = 973518,
};

var res = await sdk.DVRs.GetDVRAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [GetDVRRequest](../../Models/Requests/GetDVRRequest.md) | :heavy_check_mark:                                      | The request object to use for the request.              |

### Response

**[GetDVRResponse](../../Models/Requests/GetDVRResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeleteLineup

Deletes a DVR device's lineup.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteLineup" method="delete" path="/livetv/dvrs/{dvrId}/lineups" -->
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

DeleteLineupRequest req = new DeleteLineupRequest() {
    DvrId = 454470,
    Lineup = "<value>",
};

var res = await sdk.DVRs.DeleteLineupAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [DeleteLineupRequest](../../Models/Requests/DeleteLineupRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[DeleteLineupResponse](../../Models/Requests/DeleteLineupResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## AddLineup

Add a lineup to a DVR device's set of lineups.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addLineup" method="put" path="/livetv/dvrs/{dvrId}/lineups" -->
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

AddLineupRequest req = new AddLineupRequest() {
    DvrId = 945235,
    Lineup = "<value>",
};

var res = await sdk.DVRs.AddLineupAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [AddLineupRequest](../../Models/Requests/AddLineupRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[AddLineupResponse](../../Models/Requests/AddLineupResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## SetDVRPreferences

Set DVR preferences by name avd value

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setDVRPreferences" method="put" path="/livetv/dvrs/{dvrId}/prefs" -->
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

SetDVRPreferencesRequest req = new SetDVRPreferencesRequest() {
    DvrId = 116357,
};

var res = await sdk.DVRs.SetDVRPreferencesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [SetDVRPreferencesRequest](../../Models/Requests/SetDVRPreferencesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[SetDVRPreferencesResponse](../../Models/Requests/SetDVRPreferencesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## StopDVRReload

Tell a DVR to stop reloading program guide

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stopDVRReload" method="delete" path="/livetv/dvrs/{dvrId}/reloadGuide" -->
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

StopDVRReloadRequest req = new StopDVRReloadRequest() {
    DvrId = 348053,
};

var res = await sdk.DVRs.StopDVRReloadAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [StopDVRReloadRequest](../../Models/Requests/StopDVRReloadRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[StopDVRReloadResponse](../../Models/Requests/StopDVRReloadResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ReloadGuide

Tell a DVR to reload program guide

### Example Usage

<!-- UsageSnippet language="csharp" operationID="reloadGuide" method="post" path="/livetv/dvrs/{dvrId}/reloadGuide" -->
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

ReloadGuideRequest req = new ReloadGuideRequest() {
    DvrId = 140753,
};

var res = await sdk.DVRs.ReloadGuideAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ReloadGuideRequest](../../Models/Requests/ReloadGuideRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ReloadGuideResponse](../../Models/Requests/ReloadGuideResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## TuneChannel

Tune a channel on a DVR to the provided channel

### Example Usage

<!-- UsageSnippet language="csharp" operationID="tuneChannel" method="post" path="/livetv/dvrs/{dvrId}/channels/{channel}/tune" -->
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

TuneChannelRequest req = new TuneChannelRequest() {
    DvrId = 834281,
    Channel = "2.1",
};

var res = await sdk.DVRs.TuneChannelAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [TuneChannelRequest](../../Models/Requests/TuneChannelRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[TuneChannelResponse](../../Models/Requests/TuneChannelResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## RemoveDeviceFromDVR

Remove a device from an existing DVR

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeDeviceFromDVR" method="delete" path="/livetv/dvrs/{dvrId}/devices/{deviceId}" -->
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

RemoveDeviceFromDVRRequest req = new RemoveDeviceFromDVRRequest() {
    DvrId = 945416,
    DeviceId = 260761,
};

var res = await sdk.DVRs.RemoveDeviceFromDVRAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [RemoveDeviceFromDVRRequest](../../Models/Requests/RemoveDeviceFromDVRRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[RemoveDeviceFromDVRResponse](../../Models/Requests/RemoveDeviceFromDVRResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## AddDeviceToDVR

Add a device to an existing DVR

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addDeviceToDVR" method="put" path="/livetv/dvrs/{dvrId}/devices/{deviceId}" -->
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

AddDeviceToDVRRequest req = new AddDeviceToDVRRequest() {
    DvrId = 334755,
    DeviceId = 852930,
};

var res = await sdk.DVRs.AddDeviceToDVRAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [AddDeviceToDVRRequest](../../Models/Requests/AddDeviceToDVRRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[AddDeviceToDVRResponse](../../Models/Requests/AddDeviceToDVRResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |