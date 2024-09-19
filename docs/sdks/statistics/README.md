# Statistics
(*Statistics*)

## Overview

API Calls that perform operations with Plex Media Server Statistics


### Available Operations

* [GetStatistics](#getstatistics) - Get Media Statistics
* [GetResourcesStatistics](#getresourcesstatistics) - Get Resources Statistics
* [GetBandwidthStatistics](#getbandwidthstatistics) - Get Bandwidth Statistics

## GetStatistics

This will return the media statistics for the server

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    clientID: "gcgzw5rz2xovp84b4vha3a40",
    clientName: "Plex Web",
    clientVersion: "4.133.0",
    clientPlatform: "Chrome",
    deviceName: "Linux"
);

var res = await sdk.Statistics.GetStatisticsAsync(timespan: 4);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               | Example                                                                                   |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Timespan`                                                                                | *long*                                                                                    | :heavy_minus_sign:                                                                        | The timespan to retrieve statistics for<br/>the exact meaning of this parameter is not known<br/> | 4                                                                                         |

### Response

**[GetStatisticsResponse](../../Models/Requests/GetStatisticsResponse.md)**

### Errors

| Error Object                                                  | Status Code                                                   | Content Type                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetStatisticsBadRequest   | 400                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetStatisticsUnauthorized | 401                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException              | 4xx-5xx                                                       | */*                                                           |


## GetResourcesStatistics

This will return the resources for the server

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    clientID: "gcgzw5rz2xovp84b4vha3a40",
    clientName: "Plex Web",
    clientVersion: "4.133.0",
    clientPlatform: "Chrome",
    deviceName: "Linux"
);

var res = await sdk.Statistics.GetResourcesStatisticsAsync(timespan: 4);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               | Example                                                                                   |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Timespan`                                                                                | *long*                                                                                    | :heavy_minus_sign:                                                                        | The timespan to retrieve statistics for<br/>the exact meaning of this parameter is not known<br/> | 4                                                                                         |

### Response

**[GetResourcesStatisticsResponse](../../Models/Requests/GetResourcesStatisticsResponse.md)**

### Errors

| Error Object                                                           | Status Code                                                            | Content Type                                                           |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetResourcesStatisticsBadRequest   | 400                                                                    | application/json                                                       |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetResourcesStatisticsUnauthorized | 401                                                                    | application/json                                                       |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                       | 4xx-5xx                                                                | */*                                                                    |


## GetBandwidthStatistics

This will return the bandwidth statistics for the server

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    clientID: "gcgzw5rz2xovp84b4vha3a40",
    clientName: "Plex Web",
    clientVersion: "4.133.0",
    clientPlatform: "Chrome",
    deviceName: "Linux"
);

var res = await sdk.Statistics.GetBandwidthStatisticsAsync(timespan: 4);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               | Example                                                                                   |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Timespan`                                                                                | *long*                                                                                    | :heavy_minus_sign:                                                                        | The timespan to retrieve statistics for<br/>the exact meaning of this parameter is not known<br/> | 4                                                                                         |

### Response

**[GetBandwidthStatisticsResponse](../../Models/Requests/GetBandwidthStatisticsResponse.md)**

### Errors

| Error Object                                                           | Status Code                                                            | Content Type                                                           |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetBandwidthStatisticsBadRequest   | 400                                                                    | application/json                                                       |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetBandwidthStatisticsUnauthorized | 401                                                                    | application/json                                                       |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                       | 4xx-5xx                                                                | */*                                                                    |
