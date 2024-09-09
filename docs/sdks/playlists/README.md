# Playlists
(*Playlists*)

## Overview

Playlists are ordered collections of media. They can be dumb (just a list of media) or smart (based on a media query, such as "all albums from 2017"). 
They can be organized in (optionally nesting) folders.
Retrieving a playlist, or its items, will trigger a refresh of its metadata. 
This may cause the duration and number of items to change.


### Available Operations

* [CreatePlaylist](#createplaylist) - Create a Playlist
* [GetPlaylists](#getplaylists) - Get All Playlists
* [GetPlaylist](#getplaylist) - Retrieve Playlist
* [DeletePlaylist](#deleteplaylist) - Deletes a Playlist
* [UpdatePlaylist](#updateplaylist) - Update a Playlist
* [GetPlaylistContents](#getplaylistcontents) - Retrieve Playlist Contents
* [ClearPlaylistContents](#clearplaylistcontents) - Delete Playlist Contents
* [AddPlaylistContents](#addplaylistcontents) - Adding to a Playlist
* [UploadPlaylist](#uploadplaylist) - Upload Playlist

## CreatePlaylist

Create a new playlist. By default the playlist is blank. To create a playlist along with a first item, pass:
- `uri` - The content URI for what we're playing (e.g. `server://1234/com.plexapp.plugins.library/library/metadata/1`).
- `playQueueID` - To create a playlist from an existing play queue.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

CreatePlaylistRequest req = new CreatePlaylistRequest() {
    Title = "<value>",
    Type = LukeHagar.PlexAPI.SDK.Models.Requests.CreatePlaylistQueryParamType.Photo,
    Smart = LukeHagar.PlexAPI.SDK.Models.Requests.Smart.One,
    Uri = "https://inborn-brochure.biz",
};

var res = await sdk.Playlists.CreatePlaylistAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreatePlaylistRequest](../../Models/Requests/CreatePlaylistRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CreatePlaylistResponse](../../Models/Requests/CreatePlaylistResponse.md)**

### Errors

| Error Object                                                            | Status Code                                                             | Content Type                                                            |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.CreatePlaylistResponseBody          | 400                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.CreatePlaylistPlaylistsResponseBody | 401                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                        | 4xx-5xx                                                                 | */*                                                                     |


## GetPlaylists

Get All Playlists given the specified filters.

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Playlists.GetPlaylistsAsync(
    playlistType: LukeHagar.PlexAPI.SDK.Models.Requests.PlaylistType.Audio,
    smart: LukeHagar.PlexAPI.SDK.Models.Requests.QueryParamSmart.Zero
);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `PlaylistType`                                              | [PlaylistType](../../Models/Requests/PlaylistType.md)       | :heavy_minus_sign:                                          | limit to a type of playlist.                                |
| `Smart`                                                     | [QueryParamSmart](../../Models/Requests/QueryParamSmart.md) | :heavy_minus_sign:                                          | type of playlists to return (default is all).               |

### Response

**[GetPlaylistsResponse](../../Models/Requests/GetPlaylistsResponse.md)**

### Errors

| Error Object                                                          | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetPlaylistsResponseBody          | 400                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetPlaylistsPlaylistsResponseBody | 401                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                      | 4xx-5xx                                                               | */*                                                                   |


## GetPlaylist

Gets detailed metadata for a playlist. A playlist for many purposes (rating, editing metadata, tagging), can be treated like a regular metadata item:
Smart playlist details contain the `content` attribute. This is the content URI for the generator. This can then be parsed by a client to provide smart playlist editing.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Playlists.GetPlaylistAsync(playlistID: 4109.48D);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `PlaylistID`           | *double*               | :heavy_check_mark:     | the ID of the playlist |

### Response

**[GetPlaylistResponse](../../Models/Requests/GetPlaylistResponse.md)**

### Errors

| Error Object                                                         | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetPlaylistResponseBody          | 400                                                                  | application/json                                                     |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetPlaylistPlaylistsResponseBody | 401                                                                  | application/json                                                     |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                     | 4xx-5xx                                                              | */*                                                                  |


## DeletePlaylist

This endpoint will delete a playlist


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Playlists.DeletePlaylistAsync(playlistID: 216.22D);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `PlaylistID`           | *double*               | :heavy_check_mark:     | the ID of the playlist |

### Response

**[DeletePlaylistResponse](../../Models/Requests/DeletePlaylistResponse.md)**

### Errors

| Error Object                                                            | Status Code                                                             | Content Type                                                            |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.DeletePlaylistResponseBody          | 400                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.DeletePlaylistPlaylistsResponseBody | 401                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                        | 4xx-5xx                                                                 | */*                                                                     |


## UpdatePlaylist

From PMS version 1.9.1 clients can also edit playlist metadata using this endpoint as they would via `PUT /library/metadata/{playlistID}`


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Playlists.UpdatePlaylistAsync(
    playlistID: 3915D,
    title: "<value>",
    summary: "<value>"
);

// handle response
```

### Parameters

| Parameter                           | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `PlaylistID`                        | *double*                            | :heavy_check_mark:                  | the ID of the playlist              |
| `Title`                             | *string*                            | :heavy_minus_sign:                  | name of the playlist                |
| `Summary`                           | *string*                            | :heavy_minus_sign:                  | summary description of the playlist |

### Response

**[UpdatePlaylistResponse](../../Models/Requests/UpdatePlaylistResponse.md)**

### Errors

| Error Object                                                            | Status Code                                                             | Content Type                                                            |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.UpdatePlaylistResponseBody          | 400                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.UpdatePlaylistPlaylistsResponseBody | 401                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                        | 4xx-5xx                                                                 | */*                                                                     |


## GetPlaylistContents

Gets the contents of a playlist. Should be paged by clients via standard mechanisms. 
By default leaves are returned (e.g. episodes, movies). In order to return other types you can use the `type` parameter. 
For example, you could use this to display a list of recently added albums vis a smart playlist. 
Note that for dumb playlists, items have a `playlistItemID` attribute which is used for deleting or moving items.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Playlists.GetPlaylistContentsAsync(
    playlistID: 5004.46D,
    type: LukeHagar.PlexAPI.SDK.Models.Requests.GetPlaylistContentsQueryParamType.Two
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                       | Type                                                                                                                                                                            | Required                                                                                                                                                                        | Description                                                                                                                                                                     | Example                                                                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PlaylistID`                                                                                                                                                                    | *double*                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                              | the ID of the playlist                                                                                                                                                          |                                                                                                                                                                                 |
| `Type`                                                                                                                                                                          | [GetPlaylistContentsQueryParamType](../../Models/Requests/GetPlaylistContentsQueryParamType.md)                                                                                 | :heavy_check_mark:                                                                                                                                                              | The type of media to retrieve.<br/>1 = movie<br/>2 = show<br/>3 = season<br/>4 = episode<br/>E.g. A movie library will not return anything with type 3 as there are no seasons for movie libraries<br/> | 2                                                                                                                                                                               |

### Response

**[GetPlaylistContentsResponse](../../Models/Requests/GetPlaylistContentsResponse.md)**

### Errors

| Error Object                                                                 | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetPlaylistContentsResponseBody          | 400                                                                          | application/json                                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetPlaylistContentsPlaylistsResponseBody | 401                                                                          | application/json                                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                             | 4xx-5xx                                                                      | */*                                                                          |


## ClearPlaylistContents

Clears a playlist, only works with dumb playlists. Returns the playlist.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Playlists.ClearPlaylistContentsAsync(playlistID: 1893.18D);

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `PlaylistID`           | *double*               | :heavy_check_mark:     | the ID of the playlist |

### Response

**[ClearPlaylistContentsResponse](../../Models/Requests/ClearPlaylistContentsResponse.md)**

### Errors

| Error Object                                                                   | Status Code                                                                    | Content Type                                                                   |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.ClearPlaylistContentsResponseBody          | 400                                                                            | application/json                                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.ClearPlaylistContentsPlaylistsResponseBody | 401                                                                            | application/json                                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                               | 4xx-5xx                                                                        | */*                                                                            |


## AddPlaylistContents

Adds a generator to a playlist, same parameters as the POST to create. With a dumb playlist, this adds the specified items to the playlist.
With a smart playlist, passing a new `uri` parameter replaces the rules for the playlist. Returns the playlist.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Playlists.AddPlaylistContentsAsync(
    playlistID: 8502.01D,
    uri: "server://12345/com.plexapp.plugins.library/library/metadata/1",
    playQueueID: 123D
);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   | Example                                                       |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `PlaylistID`                                                  | *double*                                                      | :heavy_check_mark:                                            | the ID of the playlist                                        |                                                               |
| `Uri`                                                         | *string*                                                      | :heavy_check_mark:                                            | the content URI for the playlist                              | server://12345/com.plexapp.plugins.library/library/metadata/1 |
| `PlayQueueID`                                                 | *double*                                                      | :heavy_minus_sign:                                            | the play queue to add to a playlist                           | 123                                                           |

### Response

**[AddPlaylistContentsResponse](../../Models/Requests/AddPlaylistContentsResponse.md)**

### Errors

| Error Object                                                                 | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.AddPlaylistContentsResponseBody          | 400                                                                          | application/json                                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.AddPlaylistContentsPlaylistsResponseBody | 401                                                                          | application/json                                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                             | 4xx-5xx                                                                      | */*                                                                          |


## UploadPlaylist

Imports m3u playlists by passing a path on the server to scan for m3u-formatted playlist files, or a path to a single playlist file.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Playlists.UploadPlaylistAsync(
    path: "/home/barkley/playlist.m3u",
    force: LukeHagar.PlexAPI.SDK.Models.Requests.QueryParamForce.Zero
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    | Type                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Required                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | Example                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Path`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | absolute path to a directory on the server where m3u files are stored, or the absolute path to a playlist file on the server. <br/>If the `path` argument is a directory, that path will be scanned for playlist files to be processed. <br/>Each file in that directory creates a separate playlist, with a name based on the filename of the file that created it. <br/>The GUID of each playlist is based on the filename. <br/>If the `path` argument is a file, that file will be used to create a new playlist, with the name based on the filename of the file that created it. <br/>The GUID of each playlist is based on the filename.<br/> | /home/barkley/playlist.m3u                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| `Force`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      | [QueryParamForce](../../Models/Requests/QueryParamForce.md)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | Force overwriting of duplicate playlists.  <br/>By default, a playlist file uploaded with the same path will overwrite the existing playlist. <br/>The `force` argument is used to disable overwriting.  <br/>If the `force` argument is set to 0, a new playlist will be created suffixed with the date and time that the duplicate was uploaded.<br/>                                                                                                                                                                                                                                                                      |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |

### Response

**[UploadPlaylistResponse](../../Models/Requests/UploadPlaylistResponse.md)**

### Errors

| Error Object                                                            | Status Code                                                             | Content Type                                                            |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.UploadPlaylistResponseBody          | 400                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.UploadPlaylistPlaylistsResponseBody | 401                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                        | 4xx-5xx                                                                 | */*                                                                     |
