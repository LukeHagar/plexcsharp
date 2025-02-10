# Library
(*Library*)

## Overview

API Calls interacting with Plex Media Server Libraries


### Available Operations

* [GetFileHash](#getfilehash) - Get Hash Value
* [GetRecentlyAddedLibrary](#getrecentlyaddedlibrary) - Get Recently Added
* [GetAllLibraries](#getalllibraries) - Get All Libraries
* [GetLibraryDetails](#getlibrarydetails) - Get Library Details
* [DeleteLibrary](#deletelibrary) - Delete Library Section
* [GetLibraryItems](#getlibraryitems) - Get Library Items
* [GetAllMediaLibrary](#getallmedialibrary) - Get all media of library
* [GetRefreshLibraryMetadata](#getrefreshlibrarymetadata) - Refresh Metadata Of The Library
* [GetSearchLibrary](#getsearchlibrary) - Search Library
* [GetGenresLibrary](#getgenreslibrary) - Get Genres of library media
* [GetCountriesLibrary](#getcountrieslibrary) - Get Countries of library media
* [GetActorsLibrary](#getactorslibrary) - Get Actors of library media
* [GetSearchAllLibraries](#getsearchalllibraries) - Search All Libraries
* [GetMediaMetaData](#getmediametadata) - Get Media Metadata
* [GetMetadataChildren](#getmetadatachildren) - Get Items Children
* [GetTopWatchedContent](#gettopwatchedcontent) - Get Top Watched Content
* [GetOnDeck](#getondeck) - Get On Deck

## GetFileHash

This resource returns hash values for local files

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetFileHashAsync(
    url: "file://C:\Image.png&type=13",
    type: 4462.17D
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Url`                                                             | *string*                                                          | :heavy_check_mark:                                                | This is the path to the local file, must be prefixed by `file://` | file://C:\Image.png&type=13                                       |
| `Type`                                                            | *double*                                                          | :heavy_minus_sign:                                                | Item type                                                         |                                                                   |

### Response

**[GetFileHashResponse](../../Models/Requests/GetFileHashResponse.md)**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetFileHashBadRequest   | 400                                                         | application/json                                            |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetFileHashUnauthorized | 401                                                         | application/json                                            |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException            | 4XX, 5XX                                                    | \*/\*                                                       |

## GetRecentlyAddedLibrary

This endpoint will return the recently added content.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

GetRecentlyAddedLibraryRequest req = new GetRecentlyAddedLibraryRequest() {
    ContentDirectoryID = 2,
    PinnedContentDirectoryID = new List<long>() {
        3,
        5,
        7,
        13,
        12,
        1,
        6,
        14,
        2,
        10,
        16,
        17,
    },
    SectionID = 2,
    Type = QueryParamType.TvShow,
};

var res = await sdk.Library.GetRecentlyAddedLibraryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetRecentlyAddedLibraryRequest](../../Models/Requests/GetRecentlyAddedLibraryRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetRecentlyAddedLibraryResponse](../../Models/Requests/GetRecentlyAddedLibraryResponse.md)**

### Errors

| Error Type                                                              | Status Code                                                             | Content Type                                                            |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetRecentlyAddedLibraryBadRequest   | 400                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetRecentlyAddedLibraryUnauthorized | 401                                                                     | application/json                                                        |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                        | 4XX, 5XX                                                                | \*/\*                                                                   |

## GetAllLibraries

A library section (commonly referred to as just a library) is a collection of media. 
Libraries are typed, and depending on their type provide either a flat or a hierarchical view of the media. 
For example, a music library has an artist > albums > tracks structure, whereas a movie library is flat.

Libraries have features beyond just being a collection of media; for starters, they include information about supported types, filters and sorts. 
This allows a client to provide a rich interface around the media (e.g. allow sorting movies by release year).


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetAllLibrariesAsync();

// handle response
```

### Response

**[GetAllLibrariesResponse](../../Models/Requests/GetAllLibrariesResponse.md)**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetAllLibrariesBadRequest   | 400                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetAllLibrariesUnauthorized | 401                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                | 4XX, 5XX                                                        | \*/\*                                                           |

## GetLibraryDetails

## Library Details Endpoint

This endpoint provides comprehensive details about the library, focusing on organizational aspects rather than the content itself.   

The details include:

### Directories
Organized into three categories:

- **Primary Directories**: 
  - Used in some clients for quick access to media subsets (e.g., "All", "On Deck").
  - Most can be replicated via media queries.
  - Customizable by users.

- **Secondary Directories**:
  - Marked with `secondary="1"`.
  - Used in older clients for structured navigation.

- **Special Directories**:
  - Includes a "By Folder" entry for filesystem-based browsing.
  - Contains an obsolete `search="1"` entry for on-the-fly search dialog creation.

### Types
Each type in the library comes with a set of filters and sorts, aiding in building dynamic media controls:

- **Type Object Attributes**:
  - `key`: Endpoint for the media list of this type.
  - `type`: Metadata type (if standard Plex type).
  - `title`: Title for this content type (e.g., "Movies").

- **Filter Objects**:
  - Subset of the media query language.
  - Attributes include `filter` (name), `filterType` (data type), `key` (endpoint for value range), and `title`.

- **Sort Objects**:
  - Description of sort fields.
  - Attributes include `defaultDirection` (asc/desc), `descKey` and `key` (sort parameters), and `title`.

> **Note**: Filters and sorts are optional; without them, no filtering controls are rendered.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetLibraryDetailsAsync(
    sectionKey: 9518,
    includeDetails: IncludeDetails.Zero
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                  | Type                                                                                                                                                                                       | Required                                                                                                                                                                                   | Description                                                                                                                                                                                | Example                                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `SectionKey`                                                                                                                                                                               | *int*                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                         | The unique key of the Plex library. <br/>Note: This is unique in the context of the Plex server.<br/>                                                                                      | 9518                                                                                                                                                                                       |
| `IncludeDetails`                                                                                                                                                                           | [IncludeDetails](../../Models/Requests/IncludeDetails.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                         | Whether or not to include details for a section (types, filters, and sorts). <br/>Only exists for backwards compatibility, media providers other than the server libraries have it on always.<br/> |                                                                                                                                                                                            |

### Response

**[GetLibraryDetailsResponse](../../Models/Requests/GetLibraryDetailsResponse.md)**

### Errors

| Error Type                                                        | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetLibraryDetailsBadRequest   | 400                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetLibraryDetailsUnauthorized | 401                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                  | 4XX, 5XX                                                          | \*/\*                                                             |

## DeleteLibrary

Delete a library using a specific section id

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.DeleteLibraryAsync(sectionKey: 9518);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `SectionKey`                                                                                  | *int*                                                                                         | :heavy_check_mark:                                                                            | The unique key of the Plex library. <br/>Note: This is unique in the context of the Plex server.<br/> | 9518                                                                                          |

### Response

**[DeleteLibraryResponse](../../Models/Requests/DeleteLibraryResponse.md)**

### Errors

| Error Type                                                    | Status Code                                                   | Content Type                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.DeleteLibraryBadRequest   | 400                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.DeleteLibraryUnauthorized | 401                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException              | 4XX, 5XX                                                      | \*/\*                                                         |

## GetLibraryItems

Fetches details from a specific section of the library identified by a section key and a tag. The tag parameter accepts the following values:
- `all`: All items in the section.
- `unwatched`: Items that have not been played.
- `newest`: Items that are recently released.
- `recentlyAdded`: Items that are recently added to the library.
- `recentlyViewed`: Items that were recently viewed.
- `onDeck`: Items to continue watching.
- `collection`: Items categorized by collection.
- `edition`: Items categorized by edition.
- `genre`: Items categorized by genre.
- `year`: Items categorized by year of release.
- `decade`: Items categorized by decade.
- `director`: Items categorized by director.
- `actor`: Items categorized by starring actor.
- `country`: Items categorized by country of origin.
- `contentRating`: Items categorized by content rating.
- `rating`: Items categorized by rating.
- `resolution`: Items categorized by resolution.
- `firstCharacter`: Items categorized by the first letter.
- `folder`: Items categorized by folder.
- `albums`: Items categorized by album.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

GetLibraryItemsRequest req = new GetLibraryItemsRequest() {
    Tag = Tag.Edition,
    Type = GetLibraryItemsQueryParamType.TvShow,
    SectionKey = 9518,
};

var res = await sdk.Library.GetLibraryItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetLibraryItemsRequest](../../Models/Requests/GetLibraryItemsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetLibraryItemsResponse](../../Models/Requests/GetLibraryItemsResponse.md)**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetLibraryItemsBadRequest   | 400                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetLibraryItemsUnauthorized | 401                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                | 4XX, 5XX                                                        | \*/\*                                                           |

## GetAllMediaLibrary

Retrieves a list of all general media data for this library.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

GetAllMediaLibraryRequest req = new GetAllMediaLibraryRequest() {
    SectionKey = 9518,
    Type = GetAllMediaLibraryQueryParamType.TvShow,
};

var res = await sdk.Library.GetAllMediaLibraryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetAllMediaLibraryRequest](../../Models/Requests/GetAllMediaLibraryRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetAllMediaLibraryResponse](../../Models/Requests/GetAllMediaLibraryResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetAllMediaLibraryBadRequest   | 400                                                                | application/json                                                   |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetAllMediaLibraryUnauthorized | 401                                                                | application/json                                                   |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                   | 4XX, 5XX                                                           | \*/\*                                                              |

## GetRefreshLibraryMetadata

This endpoint Refreshes all the Metadata of the library.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetRefreshLibraryMetadataAsync(
    sectionKey: 9518,
    force: Force.One
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `SectionKey`                                                                                  | *int*                                                                                         | :heavy_check_mark:                                                                            | The unique key of the Plex library. <br/>Note: This is unique in the context of the Plex server.<br/> | 9518                                                                                          |
| `Force`                                                                                       | [Force](../../Models/Requests/Force.md)                                                       | :heavy_minus_sign:                                                                            | Force the refresh even if the library is already being refreshed.                             | 0                                                                                             |

### Response

**[GetRefreshLibraryMetadataResponse](../../Models/Requests/GetRefreshLibraryMetadataResponse.md)**

### Errors

| Error Type                                                                | Status Code                                                               | Content Type                                                              |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetRefreshLibraryMetadataBadRequest   | 400                                                                       | application/json                                                          |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetRefreshLibraryMetadataUnauthorized | 401                                                                       | application/json                                                          |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                          | 4XX, 5XX                                                                  | \*/\*                                                                     |

## GetSearchLibrary

Search for content within a specific section of the library.

### Types
Each type in the library comes with a set of filters and sorts, aiding in building dynamic media controls:

- **Type Object Attributes**:
  - `type`: Metadata type (if standard Plex type).  
  - `title`: Title for this content type (e.g., "Movies").

- **Filter Objects**:
  - Subset of the media query language.
  - Attributes include `filter` (name), `filterType` (data type), `key` (endpoint for value range), and `title`.

- **Sort Objects**:
  - Description of sort fields.
  - Attributes include `defaultDirection` (asc/desc), `descKey` and `key` (sort parameters), and `title`.

> **Note**: Filters and sorts are optional; without them, no filtering controls are rendered.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetSearchLibraryAsync(
    sectionKey: 9518,
    type: GetSearchLibraryQueryParamType.TvShow
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                    | Type                                                                                                                                                                                         | Required                                                                                                                                                                                     | Description                                                                                                                                                                                  | Example                                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `SectionKey`                                                                                                                                                                                 | *int*                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                           | The unique key of the Plex library. <br/>Note: This is unique in the context of the Plex server.<br/>                                                                                        | 9518                                                                                                                                                                                         |
| `Type`                                                                                                                                                                                       | [GetSearchLibraryQueryParamType](../../Models/Requests/GetSearchLibraryQueryParamType.md)                                                                                                    | :heavy_check_mark:                                                                                                                                                                           | The type of media to retrieve or filter by.<br/>1 = movie<br/>2 = show<br/>3 = season<br/>4 = episode<br/>E.g. A movie library will not return anything with type 3 as there are no seasons for movie libraries<br/> | 2                                                                                                                                                                                            |

### Response

**[GetSearchLibraryResponse](../../Models/Requests/GetSearchLibraryResponse.md)**

### Errors

| Error Type                                                       | Status Code                                                      | Content Type                                                     |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetSearchLibraryBadRequest   | 400                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetSearchLibraryUnauthorized | 401                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                 | 4XX, 5XX                                                         | \*/\*                                                            |

## GetGenresLibrary

Retrieves a list of all the genres that are found for the media in this library.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetGenresLibraryAsync(
    sectionKey: 9518,
    type: GetGenresLibraryQueryParamType.TvShow
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                    | Type                                                                                                                                                                                         | Required                                                                                                                                                                                     | Description                                                                                                                                                                                  | Example                                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `SectionKey`                                                                                                                                                                                 | *int*                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                           | The unique key of the Plex library. <br/>Note: This is unique in the context of the Plex server.<br/>                                                                                        | 9518                                                                                                                                                                                         |
| `Type`                                                                                                                                                                                       | [GetGenresLibraryQueryParamType](../../Models/Requests/GetGenresLibraryQueryParamType.md)                                                                                                    | :heavy_check_mark:                                                                                                                                                                           | The type of media to retrieve or filter by.<br/>1 = movie<br/>2 = show<br/>3 = season<br/>4 = episode<br/>E.g. A movie library will not return anything with type 3 as there are no seasons for movie libraries<br/> | 2                                                                                                                                                                                            |

### Response

**[GetGenresLibraryResponse](../../Models/Requests/GetGenresLibraryResponse.md)**

### Errors

| Error Type                                                       | Status Code                                                      | Content Type                                                     |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetGenresLibraryBadRequest   | 400                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetGenresLibraryUnauthorized | 401                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                 | 4XX, 5XX                                                         | \*/\*                                                            |

## GetCountriesLibrary

Retrieves a list of all the countries that are found for the media in this library.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetCountriesLibraryAsync(
    sectionKey: 9518,
    type: GetCountriesLibraryQueryParamType.TvShow
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                    | Type                                                                                                                                                                                         | Required                                                                                                                                                                                     | Description                                                                                                                                                                                  | Example                                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `SectionKey`                                                                                                                                                                                 | *int*                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                           | The unique key of the Plex library. <br/>Note: This is unique in the context of the Plex server.<br/>                                                                                        | 9518                                                                                                                                                                                         |
| `Type`                                                                                                                                                                                       | [GetCountriesLibraryQueryParamType](../../Models/Requests/GetCountriesLibraryQueryParamType.md)                                                                                              | :heavy_check_mark:                                                                                                                                                                           | The type of media to retrieve or filter by.<br/>1 = movie<br/>2 = show<br/>3 = season<br/>4 = episode<br/>E.g. A movie library will not return anything with type 3 as there are no seasons for movie libraries<br/> | 2                                                                                                                                                                                            |

### Response

**[GetCountriesLibraryResponse](../../Models/Requests/GetCountriesLibraryResponse.md)**

### Errors

| Error Type                                                          | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetCountriesLibraryBadRequest   | 400                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetCountriesLibraryUnauthorized | 401                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                    | 4XX, 5XX                                                            | \*/\*                                                               |

## GetActorsLibrary

Retrieves a list of all the actors that are found for the media in this library.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetActorsLibraryAsync(
    sectionKey: 9518,
    type: GetActorsLibraryQueryParamType.TvShow
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                    | Type                                                                                                                                                                                         | Required                                                                                                                                                                                     | Description                                                                                                                                                                                  | Example                                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `SectionKey`                                                                                                                                                                                 | *int*                                                                                                                                                                                        | :heavy_check_mark:                                                                                                                                                                           | The unique key of the Plex library. <br/>Note: This is unique in the context of the Plex server.<br/>                                                                                        | 9518                                                                                                                                                                                         |
| `Type`                                                                                                                                                                                       | [GetActorsLibraryQueryParamType](../../Models/Requests/GetActorsLibraryQueryParamType.md)                                                                                                    | :heavy_check_mark:                                                                                                                                                                           | The type of media to retrieve or filter by.<br/>1 = movie<br/>2 = show<br/>3 = season<br/>4 = episode<br/>E.g. A movie library will not return anything with type 3 as there are no seasons for movie libraries<br/> | 2                                                                                                                                                                                            |

### Response

**[GetActorsLibraryResponse](../../Models/Requests/GetActorsLibraryResponse.md)**

### Errors

| Error Type                                                       | Status Code                                                      | Content Type                                                     |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetActorsLibraryBadRequest   | 400                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetActorsLibraryUnauthorized | 401                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                 | 4XX, 5XX                                                         | \*/\*                                                            |

## GetSearchAllLibraries

Search the provided query across all library sections, or a single section, and return matches as hubs, split up by type.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

GetSearchAllLibrariesRequest req = new GetSearchAllLibrariesRequest() {
    Query = "<value>",
    ClientID = "3381b62b-9ab7-4e37-827b-203e9809eb58",
    SearchTypes = new List<SearchTypes>() {
        SearchTypes.People,
    },
};

var res = await sdk.Library.GetSearchAllLibrariesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetSearchAllLibrariesRequest](../../Models/Requests/GetSearchAllLibrariesRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetSearchAllLibrariesResponse](../../Models/Requests/GetSearchAllLibrariesResponse.md)**

### Errors

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetSearchAllLibrariesBadRequest   | 400                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetSearchAllLibrariesUnauthorized | 401                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                      | 4XX, 5XX                                                              | \*/\*                                                                 |

## GetMediaMetaData

This endpoint will return all the (meta)data of a library item specified with by the ratingKey.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

GetMediaMetaDataRequest req = new GetMediaMetaDataRequest() {
    RatingKey = 9518,
    IncludeConcerts = true,
    IncludeExtras = true,
    IncludeOnDeck = true,
    IncludePopularLeaves = true,
    IncludePreferences = true,
    IncludeReviews = true,
    IncludeChapters = true,
    IncludeStations = true,
    IncludeExternalMedia = true,
    AsyncAugmentMetadata = true,
    AsyncCheckFiles = true,
    AsyncRefreshAnalysis = true,
    AsyncRefreshLocalMediaAgent = true,
};

var res = await sdk.Library.GetMediaMetaDataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetMediaMetaDataRequest](../../Models/Requests/GetMediaMetaDataRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetMediaMetaDataResponse](../../Models/Requests/GetMediaMetaDataResponse.md)**

### Errors

| Error Type                                                       | Status Code                                                      | Content Type                                                     |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetMediaMetaDataBadRequest   | 400                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetMediaMetaDataUnauthorized | 401                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                 | 4XX, 5XX                                                         | \*/\*                                                            |

## GetMetadataChildren

This endpoint will return the children of of a library item specified with the ratingKey.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetMetadataChildrenAsync(
    ratingKey: 1539.14D,
    includeElements: "<value>"
);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `RatingKey`                                                             | *double*                                                                | :heavy_check_mark:                                                      | the id of the library item to return the children of.                   |
| `IncludeElements`                                                       | *string*                                                                | :heavy_minus_sign:                                                      | Adds additional elements to the response. Supported types are (Stream)<br/> |

### Response

**[GetMetadataChildrenResponse](../../Models/Requests/GetMetadataChildrenResponse.md)**

### Errors

| Error Type                                                          | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetMetadataChildrenBadRequest   | 400                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetMetadataChildrenUnauthorized | 401                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                    | 4XX, 5XX                                                            | \*/\*                                                               |

## GetTopWatchedContent

This endpoint will return the top watched content from libraries of a certain type


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetTopWatchedContentAsync(
    type: GetTopWatchedContentQueryParamType.TvShow,
    includeGuids: 1
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                    | Type                                                                                                                                                                                         | Required                                                                                                                                                                                     | Description                                                                                                                                                                                  | Example                                                                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Type`                                                                                                                                                                                       | [GetTopWatchedContentQueryParamType](../../Models/Requests/GetTopWatchedContentQueryParamType.md)                                                                                            | :heavy_check_mark:                                                                                                                                                                           | The type of media to retrieve or filter by.<br/>1 = movie<br/>2 = show<br/>3 = season<br/>4 = episode<br/>E.g. A movie library will not return anything with type 3 as there are no seasons for movie libraries<br/> | 2                                                                                                                                                                                            |
| `IncludeGuids`                                                                                                                                                                               | *long*                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                           | Adds the Guids object to the response<br/>                                                                                                                                                   | 1                                                                                                                                                                                            |

### Response

**[GetTopWatchedContentResponse](../../Models/Requests/GetTopWatchedContentResponse.md)**

### Errors

| Error Type                                                           | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetTopWatchedContentBadRequest   | 400                                                                  | application/json                                                     |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetTopWatchedContentUnauthorized | 401                                                                  | application/json                                                     |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                     | 4XX, 5XX                                                             | \*/\*                                                                |

## GetOnDeck

This endpoint will return the on deck content.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Library.GetOnDeckAsync();

// handle response
```

### Response

**[GetOnDeckResponse](../../Models/Requests/GetOnDeckResponse.md)**

### Errors

| Error Type                                                | Status Code                                               | Content Type                                              |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetOnDeckBadRequest   | 400                                                       | application/json                                          |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetOnDeckUnauthorized | 401                                                       | application/json                                          |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException          | 4XX, 5XX                                                  | \*/\*                                                     |