# Library
(*Library*)

## Overview

API Calls interacting with Plex Media Server Libraries


### Available Operations

* [GetFileHash](#getfilehash) - Get Hash Value
* [GetRecentlyAdded](#getrecentlyadded) - Get Recently Added
* [GetLibraries](#getlibraries) - Get All Libraries
* [GetLibrary](#getlibrary) - Get Library Details
* [DeleteLibrary](#deletelibrary) - Delete Library Section
* [GetLibraryItems](#getlibraryitems) - Get Library Items
* [RefreshLibrary](#refreshlibrary) - Refresh Library
* [GetLatestLibraryItems](#getlatestlibraryitems) - Get Latest Library Items
* [GetCommonLibraryItems](#getcommonlibraryitems) - Get Common Library Items
* [GetMetadata](#getmetadata) - Get Items Metadata
* [GetMetadataChildren](#getmetadatachildren) - Get Items Children
* [GetOnDeck](#getondeck) - Get On Deck

## GetFileHash

This resource returns hash values for local files

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetFileHashAsync(Url: "file://C:\Image.png&type=13", Type: 4462.17D);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Url`                                                             | *string*                                                          | :heavy_check_mark:                                                | This is the path to the local file, must be prefixed by `file://` | file://C:\Image.png&type=13                                       |
| `Type`                                                            | *double*                                                          | :heavy_minus_sign:                                                | Item type                                                         |                                                                   |


### Response

**[GetFileHashResponse](../../Models/Requests/GetFileHashResponse.md)**


## GetRecentlyAdded

This endpoint will return the recently added content.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetRecentlyAddedAsync();

// handle response
```


### Response

**[GetRecentlyAddedResponse](../../Models/Requests/GetRecentlyAddedResponse.md)**


## GetLibraries

A library section (commonly referred to as just a library) is a collection of media. 
Libraries are typed, and depending on their type provide either a flat or a hierarchical view of the media. 
For example, a music library has an artist > albums > tracks structure, whereas a movie library is flat.

Libraries have features beyond just being a collection of media; for starters, they include information about supported types, filters and sorts. 
This allows a client to provide a rich interface around the media (e.g. allow sorting movies by release year).


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetLibrariesAsync();

// handle response
```


### Response

**[GetLibrariesResponse](../../Models/Requests/GetLibrariesResponse.md)**


## GetLibrary

Returns details for the library. This can be thought of as an interstitial endpoint because it contains information about the library, rather than content itself. These details are:

- A list of `Directory` objects: These used to be used by clients to build a menuing system. There are four flavors of directory found here:
  - Primary: (e.g. all, On Deck) These are still used in some clients to provide "shortcuts" to subsets of media. However, with the exception of On Deck, all of them can be created by media queries, and the desire is to allow these to be customized by users.
  - Secondary: These are marked with `secondary="1"` and were used by old clients to provide nested menus allowing for primative (but structured) navigation.
  - Special: There is a By Folder entry which allows browsing the media by the underlying filesystem structure, and there's a completely obsolete entry marked `search="1"` which used to be used to allow clients to build search dialogs on the fly.
- A list of `Type` objects: These represent the types of things found in this library, and for each one, a list of `Filter` and `Sort` objects. These can be used to build rich controls around a grid of media to allow filtering and organizing. Note that these filters and sorts are optional, and without them, the client won't render any filtering controls. The `Type` object contains:
  - `key`: This provides the root endpoint returning the actual media list for the type.
  - `type`: This is the metadata type for the type (if a standard Plex type).
  - `title`: The title for for the content of this type (e.g. "Movies").
- Each `Filter` object contains a description of the filter. Note that it is not an exhaustive list of the full media query language, but an inportant subset useful for top-level API.
  - `filter`: This represents the filter name used for the filter, which can be used to construct complex media queries with.
  - `filterType`: This is either `string`, `integer`, or `boolean`, and describes the type of values used for the filter.
  - `key`: This provides the endpoint where the possible range of values for the filter can be retrieved (e.g. for a "Genre" filter, it returns a list of all the genres in the library). This will include a `type` argument that matches the metadata type of the Type element.
  - `title`: The title for the filter.
- Each `Sort` object contains a description of the sort field.
  - `defaultDirection`: Can be either `asc` or `desc`, and specifies the default direction for the sort field (e.g. titles default to alphabetically ascending).
  - `descKey` and `key`: Contains the parameters passed to the `sort=...` media query for each direction of the sort.
  - `title`: The title of the field.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetLibraryAsync(SectionId: 1000D, IncludeDetails: IncludeDetails.Zero);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                  | Type                                                                                                                                                                                       | Required                                                                                                                                                                                   | Description                                                                                                                                                                                | Example                                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `SectionId`                                                                                                                                                                                | *double*                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                         | the Id of the library to query                                                                                                                                                             | 1000                                                                                                                                                                                       |
| `IncludeDetails`                                                                                                                                                                           | [IncludeDetails](../../Models/Requests/IncludeDetails.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                         | Whether or not to include details for a section (types, filters, and sorts). <br/>Only exists for backwards compatibility, media providers other than the server libraries have it on always.<br/> |                                                                                                                                                                                            |


### Response

**[GetLibraryResponse](../../Models/Requests/GetLibraryResponse.md)**


## DeleteLibrary

Delate a library using a specific section

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.DeleteLibraryAsync(SectionId: 1000D);

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    | Example                        |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `SectionId`                    | *double*                       | :heavy_check_mark:             | the Id of the library to query | 1000                           |


### Response

**[DeleteLibraryResponse](../../Models/Requests/DeleteLibraryResponse.md)**


## GetLibraryItems

This endpoint will return a list of library items filtered by the filter and type provided


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetLibraryItemsAsync(SectionId: 4510.92D, Type: 760.66D, Filter: "string");

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `SectionId`                    | *double*                       | :heavy_check_mark:             | the Id of the library to query |
| `Type`                         | *double*                       | :heavy_minus_sign:             | item type                      |
| `Filter`                       | *string*                       | :heavy_minus_sign:             | the filter parameter           |


### Response

**[GetLibraryItemsResponse](../../Models/Requests/GetLibraryItemsResponse.md)**


## RefreshLibrary

This endpoint Refreshes the library.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.RefreshLibraryAsync(SectionId: 934.16D);

// handle response
```

### Parameters

| Parameter                        | Type                             | Required                         | Description                      |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `SectionId`                      | *double*                         | :heavy_check_mark:               | the Id of the library to refresh |


### Response

**[RefreshLibraryResponse](../../Models/Requests/RefreshLibraryResponse.md)**


## GetLatestLibraryItems

This endpoint will return a list of the latest library items filtered by the filter and type provided


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetLatestLibraryItemsAsync(SectionId: 7171.54D, Type: 8015.12D, Filter: "string");

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `SectionId`                    | *double*                       | :heavy_check_mark:             | the Id of the library to query |
| `Type`                         | *double*                       | :heavy_check_mark:             | item type                      |
| `Filter`                       | *string*                       | :heavy_minus_sign:             | the filter parameter           |


### Response

**[GetLatestLibraryItemsResponse](../../Models/Requests/GetLatestLibraryItemsResponse.md)**


## GetCommonLibraryItems

Represents a "Common" item. It contains only the common attributes of the items selected by the provided filter


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetCommonLibraryItemsAsync(SectionId: 2710.37D, Type: 2760.31D, Filter: "string");

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `SectionId`                    | *double*                       | :heavy_check_mark:             | the Id of the library to query |
| `Type`                         | *double*                       | :heavy_check_mark:             | item type                      |
| `Filter`                       | *string*                       | :heavy_minus_sign:             | the filter parameter           |


### Response

**[GetCommonLibraryItemsResponse](../../Models/Requests/GetCommonLibraryItemsResponse.md)**


## GetMetadata

This endpoint will return the metadata of a library item specified with the ratingKey.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetMetadataAsync(RatingKey: 8382.31D);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `RatingKey`                                           | *double*                                              | :heavy_check_mark:                                    | the id of the library item to return the children of. |


### Response

**[GetMetadataResponse](../../Models/Requests/GetMetadataResponse.md)**


## GetMetadataChildren

This endpoint will return the children of of a library item specified with the ratingKey.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetMetadataChildrenAsync(RatingKey: 1539.14D);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `RatingKey`                                           | *double*                                              | :heavy_check_mark:                                    | the id of the library item to return the children of. |


### Response

**[GetMetadataChildrenResponse](../../Models/Requests/GetMetadataChildrenResponse.md)**


## GetOnDeck

This endpoint will return the on deck content.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Library.GetOnDeckAsync();

// handle response
```


### Response

**[GetOnDeckResponse](../../Models/Requests/GetOnDeckResponse.md)**

