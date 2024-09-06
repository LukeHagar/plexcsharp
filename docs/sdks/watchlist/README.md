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
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

GetWatchListRequest req = new GetWatchListRequest() {
    Filter = PlexAPI.Models.Requests.Filter.Available,
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

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| PlexAPI.Models.Errors.GetWatchListResponseBody | 401                                            | application/json                               |
| PlexAPI.Models.Errors.SDKException             | 4xx-5xx                                        | */*                                            |
