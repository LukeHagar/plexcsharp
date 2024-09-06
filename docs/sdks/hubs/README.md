# Hubs
(*Hubs*)

## Overview

Hubs are a structured two-dimensional container for media, generally represented by multiple horizontal rows.


### Available Operations

* [GetGlobalHubs](#getglobalhubs) - Get Global Hubs
* [GetLibraryHubs](#getlibraryhubs) - Get library specific hubs

## GetGlobalHubs

Get Global Hubs filtered by the parameters provided.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Hubs.GetGlobalHubsAsync(
    count: 1262.49D,
    onlyTransient: PlexAPI.Models.Requests.OnlyTransient.One
);

// handle response
```

### Parameters

| Parameter                                                                                                                                             | Type                                                                                                                                                  | Required                                                                                                                                              | Description                                                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Count`                                                                                                                                               | *double*                                                                                                                                              | :heavy_minus_sign:                                                                                                                                    | The number of items to return with each hub.                                                                                                          |
| `OnlyTransient`                                                                                                                                       | [OnlyTransient](../../Models/Requests/OnlyTransient.md)                                                                                               | :heavy_minus_sign:                                                                                                                                    | Only return hubs which are "transient", meaning those which are prone to changing after media playback or addition (e.g. On Deck, or Recently Added). |

### Response

**[GetGlobalHubsResponse](../../Models/Requests/GetGlobalHubsResponse.md)**

### Errors

| Error Object                                    | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| PlexAPI.Models.Errors.GetGlobalHubsResponseBody | 401                                             | application/json                                |
| PlexAPI.Models.Errors.SDKException              | 4xx-5xx                                         | */*                                             |


## GetLibraryHubs

This endpoint will return a list of library specific hubs


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Hubs.GetLibraryHubsAsync(
    sectionId: 6728.76D,
    count: 9010.22D,
    onlyTransient: PlexAPI.Models.Requests.QueryParamOnlyTransient.Zero
);

// handle response
```

### Parameters

| Parameter                                                                                                                                             | Type                                                                                                                                                  | Required                                                                                                                                              | Description                                                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| `SectionId`                                                                                                                                           | *double*                                                                                                                                              | :heavy_check_mark:                                                                                                                                    | the Id of the library to query                                                                                                                        |
| `Count`                                                                                                                                               | *double*                                                                                                                                              | :heavy_minus_sign:                                                                                                                                    | The number of items to return with each hub.                                                                                                          |
| `OnlyTransient`                                                                                                                                       | [QueryParamOnlyTransient](../../Models/Requests/QueryParamOnlyTransient.md)                                                                           | :heavy_minus_sign:                                                                                                                                    | Only return hubs which are "transient", meaning those which are prone to changing after media playback or addition (e.g. On Deck, or Recently Added). |

### Response

**[GetLibraryHubsResponse](../../Models/Requests/GetLibraryHubsResponse.md)**

### Errors

| Error Object                                     | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| PlexAPI.Models.Errors.GetLibraryHubsResponseBody | 401                                              | application/json                                 |
| PlexAPI.Models.Errors.SDKException               | 4xx-5xx                                          | */*                                              |
