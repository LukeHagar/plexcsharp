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
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman");

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

| Error Object                                    | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| PlexAPI.Models.Errors.GetStatisticsResponseBody | 401                                             | application/json                                |
| PlexAPI.Models.Errors.SDKException              | 4xx-5xx                                         | */*                                             |


## GetResourcesStatistics

This will return the resources for the server

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman");

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

| Error Object                                             | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| PlexAPI.Models.Errors.GetResourcesStatisticsResponseBody | 401                                                      | application/json                                         |
| PlexAPI.Models.Errors.SDKException                       | 4xx-5xx                                                  | */*                                                      |


## GetBandwidthStatistics

This will return the bandwidth statistics for the server

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman");

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

| Error Object                                             | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| PlexAPI.Models.Errors.GetBandwidthStatisticsResponseBody | 401                                                      | application/json                                         |
| PlexAPI.Models.Errors.SDKException                       | 4xx-5xx                                                  | */*                                                      |
