# Media
(*Media*)

## Overview

API Calls interacting with Plex Media Server Media


### Available Operations

* [MarkPlayed](#markplayed) - Mark Media Played
* [MarkUnplayed](#markunplayed) - Mark Media Unplayed
* [UpdatePlayProgress](#updateplayprogress) - Update Media Play Progress
* [GetBannerImage](#getbannerimage) - Get Banner Image
* [GetThumbImage](#getthumbimage) - Get Thumb Image

## MarkPlayed

This will mark the provided media key as Played.

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

var res = await sdk.Media.MarkPlayedAsync(key: 59398D);

// handle response
```

### Parameters

| Parameter                       | Type                            | Required                        | Description                     | Example                         |
| ------------------------------- | ------------------------------- | ------------------------------- | ------------------------------- | ------------------------------- |
| `Key`                           | *double*                        | :heavy_check_mark:              | The media key to mark as played | 59398                           |

### Response

**[MarkPlayedResponse](../../Models/Requests/MarkPlayedResponse.md)**

### Errors

| Error Object                                               | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.MarkPlayedBadRequest   | 400                                                        | application/json                                           |
| LukeHagar.PlexAPI.SDK.Models.Errors.MarkPlayedUnauthorized | 401                                                        | application/json                                           |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException           | 4xx-5xx                                                    | */*                                                        |


## MarkUnplayed

This will mark the provided media key as Unplayed.

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

var res = await sdk.Media.MarkUnplayedAsync(key: 59398D);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       | Example                           |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Key`                             | *double*                          | :heavy_check_mark:                | The media key to mark as Unplayed | 59398                             |

### Response

**[MarkUnplayedResponse](../../Models/Requests/MarkUnplayedResponse.md)**

### Errors

| Error Object                                                 | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.MarkUnplayedBadRequest   | 400                                                          | application/json                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.MarkUnplayedUnauthorized | 401                                                          | application/json                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException             | 4xx-5xx                                                      | */*                                                          |


## UpdatePlayProgress

This API command can be used to update the play progress of a media item.


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

var res = await sdk.Media.UpdatePlayProgressAsync(
    key: "<key>",
    time: 90000D,
    state: "played"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Key`                                                               | *string*                                                            | :heavy_check_mark:                                                  | the media key                                                       |                                                                     |
| `Time`                                                              | *double*                                                            | :heavy_check_mark:                                                  | The time, in milliseconds, used to set the media playback progress. | 90000                                                               |
| `State`                                                             | *string*                                                            | :heavy_check_mark:                                                  | The playback state of the media item.                               | played                                                              |

### Response

**[UpdatePlayProgressResponse](../../Models/Requests/UpdatePlayProgressResponse.md)**

### Errors

| Error Object                                                       | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.UpdatePlayProgressBadRequest   | 400                                                                | application/json                                                   |
| LukeHagar.PlexAPI.SDK.Models.Errors.UpdatePlayProgressUnauthorized | 401                                                                | application/json                                                   |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                   | 4xx-5xx                                                            | */*                                                                |


## GetBannerImage

Gets the banner image of the media item

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

GetBannerImageRequest req = new GetBannerImageRequest() {
    RatingKey = 9518,
    Width = 396,
    Height = 396,
    MinSize = 1,
    Upscale = 1,
    XPlexToken = "CV5xoxjTpFKUzBTShsaf",
};

var res = await sdk.Media.GetBannerImageAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetBannerImageRequest](../../Models/Requests/GetBannerImageRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetBannerImageResponse](../../Models/Requests/GetBannerImageResponse.md)**

### Errors

| Error Object                                                   | Status Code                                                    | Content Type                                                   |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetBannerImageBadRequest   | 400                                                            | application/json                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetBannerImageUnauthorized | 401                                                            | application/json                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException               | 4xx-5xx                                                        | */*                                                            |


## GetThumbImage

Gets the thumbnail image of the media item

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

GetThumbImageRequest req = new GetThumbImageRequest() {
    RatingKey = 9518,
    Width = 396,
    Height = 396,
    MinSize = 1,
    Upscale = 1,
    XPlexToken = "CV5xoxjTpFKUzBTShsaf",
};

var res = await sdk.Media.GetThumbImageAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetThumbImageRequest](../../Models/Requests/GetThumbImageRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GetThumbImageResponse](../../Models/Requests/GetThumbImageResponse.md)**

### Errors

| Error Object                                                  | Status Code                                                   | Content Type                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetThumbImageBadRequest   | 400                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetThumbImageUnauthorized | 401                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException              | 4xx-5xx                                                       | */*                                                           |
