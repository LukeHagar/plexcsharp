# Watchlist
(*Watchlist*)

## Overview

API Calls that perform operations with Plex Media Server Watchlists


### Available Operations

* [GetWatchlist](#getwatchlist) - Get User Watchlist

## GetWatchlist

Get User Watchlist

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

GetWatchlistRequest req = new GetWatchlistRequest() {
    Filter = PlexAPI.Models.Requests.PathParamFilter.Released,
    XPlexToken = "<value>",
};

var res = await sdk.Watchlist.GetWatchlistAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetWatchlistRequest](../../Models/Requests/GetWatchlistRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |
| `serverURL`                                                         | *string*                                                            | :heavy_minus_sign:                                                  | An optional server URL to use.                                      |

### Response

**[GetWatchlistResponse](../../Models/Requests/GetWatchlistResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| PlexAPI.Models.Errors.GetWatchlistResponseBody | 401                                            | application/json                               |
| PlexAPI.Models.Errors.SDKException             | 4xx-5xx                                        | */*                                            |
