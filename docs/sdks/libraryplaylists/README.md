# LibraryPlaylists

## Overview

Endpoints for manipulating playlists.

### Available Operations

* [CreatePlaylist](#createplaylist) - Create a Playlist
* [UploadPlaylist](#uploadplaylist) - Upload
* [DeletePlaylist](#deleteplaylist) - Delete a Playlist
* [UpdatePlaylist](#updateplaylist) - Editing a Playlist
* [GetPlaylistGenerators](#getplaylistgenerators) - Get a playlist's generators
* [ClearPlaylistItems](#clearplaylistitems) - Clearing a playlist
* [AddPlaylistItems](#addplaylistitems) - Adding to  a Playlist
* [DeletePlaylistItem](#deleteplaylistitem) - Delete a Generator
* [GetPlaylistGenerator](#getplaylistgenerator) - Get a playlist generator
* [GetPlaylistGeneratorItems](#getplaylistgeneratoritems) - Get a playlist generator's items
* [MovePlaylistItem](#moveplaylistitem) - Moving items in a playlist
* [RefreshPlaylist](#refreshplaylist) - Reprocess a generator

## CreatePlaylist

Create a new playlist. By default the playlist is blank.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPlaylist" method="post" path="/playlists" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

CreatePlaylistRequest req = new CreatePlaylistRequest() {
    Uri = "https://short-term-disconnection.name/",
};

var res = await sdk.LibraryPlaylists.CreatePlaylistAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreatePlaylistRequest](../../Models/Requests/CreatePlaylistRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CreatePlaylistResponse](../../Models/Requests/CreatePlaylistResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## UploadPlaylist

Imports m3u playlists by passing a path on the server to scan for m3u-formatted playlist files, or a path to a single playlist file.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uploadPlaylist" method="post" path="/playlists/upload" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

UploadPlaylistRequest req = new UploadPlaylistRequest() {
    Path = "/home/barkley/playlist.m3u",
    Force = BoolInt.True,
};

var res = await sdk.LibraryPlaylists.UploadPlaylistAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UploadPlaylistRequest](../../Models/Requests/UploadPlaylistRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UploadPlaylistResponse](../../Models/Requests/UploadPlaylistResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeletePlaylist

Deletes a playlist by provided id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deletePlaylist" method="delete" path="/playlists/{playlistId}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

DeletePlaylistRequest req = new DeletePlaylistRequest() {
    PlaylistId = 343293,
};

var res = await sdk.LibraryPlaylists.DeletePlaylistAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [DeletePlaylistRequest](../../Models/Requests/DeletePlaylistRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[DeletePlaylistResponse](../../Models/Requests/DeletePlaylistResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## UpdatePlaylist

Edits a playlist in the same manner as [editing metadata](#tag/Provider/operation/metadataPutItem)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePlaylist" method="put" path="/playlists/{playlistId}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

UpdatePlaylistRequest req = new UpdatePlaylistRequest() {
    PlaylistId = 157966,
};

var res = await sdk.LibraryPlaylists.UpdatePlaylistAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdatePlaylistRequest](../../Models/Requests/UpdatePlaylistRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[UpdatePlaylistResponse](../../Models/Requests/UpdatePlaylistResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetPlaylistGenerators

Get all the generators in a playlist

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPlaylistGenerators" method="get" path="/playlists/{playlistId}/generators" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

GetPlaylistGeneratorsRequest req = new GetPlaylistGeneratorsRequest() {
    PlaylistId = 162342,
};

var res = await sdk.LibraryPlaylists.GetPlaylistGeneratorsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetPlaylistGeneratorsRequest](../../Models/Requests/GetPlaylistGeneratorsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetPlaylistGeneratorsResponse](../../Models/Requests/GetPlaylistGeneratorsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ClearPlaylistItems

Clears a playlist, only works with dumb playlists. Returns the playlist.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="clearPlaylistItems" method="delete" path="/playlists/{playlistId}/items" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

ClearPlaylistItemsRequest req = new ClearPlaylistItemsRequest() {
    PlaylistId = 552140,
};

var res = await sdk.LibraryPlaylists.ClearPlaylistItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ClearPlaylistItemsRequest](../../Models/Requests/ClearPlaylistItemsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ClearPlaylistItemsResponse](../../Models/Requests/ClearPlaylistItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## AddPlaylistItems

Adds a generator to a playlist, same parameters as the POST above. With a dumb playlist, this adds the specified items to the playlist. With a smart playlist, passing a new `uri` parameter replaces the rules for the playlist. Returns the playlist.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addPlaylistItems" method="put" path="/playlists/{playlistId}/items" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

AddPlaylistItemsRequest req = new AddPlaylistItemsRequest() {
    PlaylistId = 533723,
};

var res = await sdk.LibraryPlaylists.AddPlaylistItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [AddPlaylistItemsRequest](../../Models/Requests/AddPlaylistItemsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[AddPlaylistItemsResponse](../../Models/Requests/AddPlaylistItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeletePlaylistItem

Deletes an item from a playlist. Only works with dumb playlists.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deletePlaylistItem" method="delete" path="/playlists/{playlistId}/items/{generatorId}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

DeletePlaylistItemRequest req = new DeletePlaylistItemRequest() {
    PlaylistId = 981646,
    GeneratorId = 194010,
};

var res = await sdk.LibraryPlaylists.DeletePlaylistItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [DeletePlaylistItemRequest](../../Models/Requests/DeletePlaylistItemRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[DeletePlaylistItemResponse](../../Models/Requests/DeletePlaylistItemResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetPlaylistGenerator

Get a playlist's generator.  Only used for optimized versions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPlaylistGenerator" method="get" path="/playlists/{playlistId}/items/{generatorId}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

GetPlaylistGeneratorRequest req = new GetPlaylistGeneratorRequest() {
    PlaylistId = 744880,
    GeneratorId = 322168,
};

var res = await sdk.LibraryPlaylists.GetPlaylistGeneratorAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetPlaylistGeneratorRequest](../../Models/Requests/GetPlaylistGeneratorRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetPlaylistGeneratorResponse](../../Models/Requests/GetPlaylistGeneratorResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetPlaylistGeneratorItems

Get a playlist generator's items

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPlaylistGeneratorItems" method="get" path="/playlists/{playlistId}/items/{generatorId}/items" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

GetPlaylistGeneratorItemsRequest req = new GetPlaylistGeneratorItemsRequest() {
    PlaylistId = 77230,
    GeneratorId = 979714,
};

var res = await sdk.LibraryPlaylists.GetPlaylistGeneratorItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetPlaylistGeneratorItemsRequest](../../Models/Requests/GetPlaylistGeneratorItemsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetPlaylistGeneratorItemsResponse](../../Models/Requests/GetPlaylistGeneratorItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## MovePlaylistItem

Moves an item in a playlist. Only works with dumb playlists.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="movePlaylistItem" method="put" path="/playlists/{playlistId}/items/{playlistItemId}/move" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

MovePlaylistItemRequest req = new MovePlaylistItemRequest() {
    PlaylistId = 940298,
    PlaylistItemId = 375626,
};

var res = await sdk.LibraryPlaylists.MovePlaylistItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [MovePlaylistItemRequest](../../Models/Requests/MovePlaylistItemRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[MovePlaylistItemResponse](../../Models/Requests/MovePlaylistItemResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## RefreshPlaylist

Make a generator reprocess (refresh)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="refreshPlaylist" method="put" path="/playlists/{playlistId}/items/{generatorId}/{metadataId}/{action}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

RefreshPlaylistRequest req = new RefreshPlaylistRequest() {
    PlaylistId = 895314,
    GeneratorId = 629742,
    MetadataId = 724422,
    Action = Action.Disable,
};

var res = await sdk.LibraryPlaylists.RefreshPlaylistAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RefreshPlaylistRequest](../../Models/Requests/RefreshPlaylistRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[RefreshPlaylistResponse](../../Models/Requests/RefreshPlaylistResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |