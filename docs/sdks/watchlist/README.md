# Watchlist
(*Watchlist*)

## Overview

API Calls that perform operations with Plex Media Server Watchlists


### Available Operations

* [GetWatchList](#getwatchlist) - Get User Watchlist

## GetWatchList

Get User Watchlist

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

GetWatchListRequest req = new GetWatchListRequest() {
    Filter = LukeHagar.PlexAPI.SDK.Models.Requests.Filter.Available,
    XPlexToken = "CV5xoxjTpFKUzBTShsaf",
    XPlexContainerStart = 0,
    XPlexContainerSize = 50,
};

var res = await sdk.Watchlist.GetWatchListAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetWatchListRequest](../../Models/Requests/GetWatchListRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `serverURL`                                                         | *string*                                                            | :heavy_minus_sign:                                                  | An optional server URL to use.                                      |

### Response

**[GetWatchListResponse](../../Models/Requests/GetWatchListResponse.md)**

### Errors

| Error Object                                                          | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetWatchListResponseBody          | 400                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetWatchListWatchlistResponseBody | 401                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                      | 4xx-5xx                                                               | */*                                                                   |
