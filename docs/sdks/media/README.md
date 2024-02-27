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
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(AccessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Media.MarkPlayedAsync(key: 59398D);

// handle response
```

### Parameters

| Parameter                       | Type                            | Required                        | Description                     | Example                         |
| ------------------------------- | ------------------------------- | ------------------------------- | ------------------------------- | ------------------------------- |
| `Key`                           | *double*                        | :heavy_check_mark:              | The media key to mark as played | 59398                           |


### Response

**[MarkPlayedResponse](../../Models/Requests/MarkPlayedResponse.md)**


## MarkUnplayed

This will mark the provided media key as Unplayed.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(AccessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Media.MarkUnplayedAsync(key: 59398D);

// handle response
```

### Parameters

| Parameter                         | Type                              | Required                          | Description                       | Example                           |
| --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- | --------------------------------- |
| `Key`                             | *double*                          | :heavy_check_mark:                | The media key to mark as Unplayed | 59398                             |


### Response

**[MarkUnplayedResponse](../../Models/Requests/MarkUnplayedResponse.md)**


## UpdatePlayProgress

This API command can be used to update the play progress of a media item.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(AccessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Media.UpdatePlayProgressAsync(
    key: "<value>",
    time: 6900.91D,
    state: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Key`                                                               | *string*                                                            | :heavy_check_mark:                                                  | the media key                                                       |
| `Time`                                                              | *double*                                                            | :heavy_check_mark:                                                  | The time, in milliseconds, used to set the media playback progress. |
| `State`                                                             | *string*                                                            | :heavy_check_mark:                                                  | The playback state of the media item.                               |


### Response

**[UpdatePlayProgressResponse](../../Models/Requests/UpdatePlayProgressResponse.md)**

