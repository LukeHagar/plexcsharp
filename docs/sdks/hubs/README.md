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
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Hubs.GetGlobalHubsAsync(
    count: 1262.49D,
    onlyTransient: LukeHagar.PlexAPI.SDK.Models.Requests.OnlyTransient.One
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

| Error Object                                                      | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetGlobalHubsResponseBody     | 400                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetGlobalHubsHubsResponseBody | 401                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                  | 4xx-5xx                                                           | */*                                                               |


## GetLibraryHubs

This endpoint will return a list of library specific hubs


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Hubs.GetLibraryHubsAsync(
    sectionId: 6728.76D,
    count: 9010.22D,
    onlyTransient: LukeHagar.PlexAPI.SDK.Models.Requests.QueryParamOnlyTransient.Zero
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

| Error Object                                                       | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetLibraryHubsResponseBody     | 400                                                                | application/json                                                   |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetLibraryHubsHubsResponseBody | 401                                                                | application/json                                                   |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                   | 4xx-5xx                                                            | */*                                                                |
