# Media
(*Media*)

## Overview

API Calls interacting with Plex Media Server Media


### Available Operations

* [MarkPlayed](#markplayed) - Mark Media Played
* [MarkUnplayed](#markunplayed) - Mark Media Unplayed
* [UpdatePlayProgress](#updateplayprogress) - Update Media Play Progress

## MarkPlayed

This will mark the provided media key as Played.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| PlexAPI.Models.Errors.MarkPlayedResponseBody | 401                                          | application/json                             |
| PlexAPI.Models.Errors.SDKException           | 4xx-5xx                                      | */*                                          |


## MarkUnplayed

This will mark the provided media key as Unplayed.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
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

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| PlexAPI.Models.Errors.MarkUnplayedResponseBody | 401                                            | application/json                               |
| PlexAPI.Models.Errors.SDKException             | 4xx-5xx                                        | */*                                            |


## UpdatePlayProgress

This API command can be used to update the play progress of a media item.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Media.UpdatePlayProgressAsync(
    key: "<value>",
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

| Error Object                                         | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| PlexAPI.Models.Errors.UpdatePlayProgressResponseBody | 401                                                  | application/json                                     |
| PlexAPI.Models.Errors.SDKException                   | 4xx-5xx                                              | */*                                                  |
