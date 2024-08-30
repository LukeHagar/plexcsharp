# Library
(*Library*)

## Overview

API Calls interacting with Plex Media Server Libraries


### Available Operations

* [GetFileHash](#getfilehash) - Get Hash Value
* [GetRecentlyAdded](#getrecentlyadded) - Get Recently Added
* [GetAllLibraries](#getalllibraries) - Get All Libraries
* [GetLibraryDetails](#getlibrarydetails) - Get Library Details
* [DeleteLibrary](#deletelibrary) - Delete Library Section
* [GetLibraryItems](#getlibraryitems) - Get Library Items
* [GetRefreshLibraryMetadata](#getrefreshlibrarymetadata) - Refresh Metadata Of The Library
* [SearchLibrary](#searchlibrary) - Search Library
* [GetMetadata](#getmetadata) - Get Items Metadata
* [GetMetadataChildren](#getmetadatachildren) - Get Items Children
* [GetTopWatchedContent](#gettopwatchedcontent) - Get Top Watched Content
* [GetOnDeck](#getondeck) - Get On Deck

## GetFileHash

This resource returns hash values for local files

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

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

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| PlexAPI.Models.Errors.GetFileHashResponseBody | 401                                           | application/json                              |
| PlexAPI.Models.Errors.SDKException            | 4xx-5xx                                       | */*                                           |


## GetRecentlyAdded

This endpoint will return the recently added content.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.GetRecentlyAddedAsync();

// handle response
```

### Response

**[GetRecentlyAddedResponse](../../Models/Requests/GetRecentlyAddedResponse.md)**

### Errors

| Error Object                                       | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| PlexAPI.Models.Errors.GetRecentlyAddedResponseBody | 401                                                | application/json                                   |
| PlexAPI.Models.Errors.SDKException                 | 4xx-5xx                                            | */*                                                |


## GetAllLibraries

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
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.GetAllLibrariesAsync();

// handle response
```

### Response

**[GetAllLibrariesResponse](../../Models/Requests/GetAllLibrariesResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| PlexAPI.Models.Errors.GetAllLibrariesResponseBody | 401                                               | application/json                                  |
| PlexAPI.Models.Errors.SDKException                | 4xx-5xx                                           | */*                                               |


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
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.GetLibraryDetailsAsync(
    sectionId: 15D,
    includeDetails: PlexAPI.Models.Requests.IncludeDetails.Zero
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                  | Type                                                                                                                                                                                       | Required                                                                                                                                                                                   | Description                                                                                                                                                                                | Example                                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `SectionId`                                                                                                                                                                                | *double*                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                         | The id of the library                                                                                                                                                                      | 15                                                                                                                                                                                         |
| `IncludeDetails`                                                                                                                                                                           | [IncludeDetails](../../Models/Requests/IncludeDetails.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                         | Whether or not to include details for a section (types, filters, and sorts). <br/>Only exists for backwards compatibility, media providers other than the server libraries have it on always.<br/> |                                                                                                                                                                                            |

### Response

**[GetLibraryDetailsResponse](../../Models/Requests/GetLibraryDetailsResponse.md)**

### Errors

| Error Object                                        | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| PlexAPI.Models.Errors.GetLibraryDetailsResponseBody | 401                                                 | application/json                                    |
| PlexAPI.Models.Errors.SDKException                  | 4xx-5xx                                             | */*                                                 |


## DeleteLibrary

Delete a library using a specific section id

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.DeleteLibraryAsync(sectionId: 15D);

// handle response
```

### Parameters

| Parameter             | Type                  | Required              | Description           | Example               |
| --------------------- | --------------------- | --------------------- | --------------------- | --------------------- |
| `SectionId`           | *double*              | :heavy_check_mark:    | The id of the library | 15                    |

### Response

**[DeleteLibraryResponse](../../Models/Requests/DeleteLibraryResponse.md)**

### Errors

| Error Object                                    | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| PlexAPI.Models.Errors.DeleteLibraryResponseBody | 401                                             | application/json                                |
| PlexAPI.Models.Errors.SDKException              | 4xx-5xx                                         | */*                                             |


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


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.GetLibraryItemsAsync(
    sectionId: "<value>",
    tag: PlexAPI.Models.Requests.Tag.Genre,
    includeGuids: 1
);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `SectionId`                                           | *object*                                              | :heavy_check_mark:                                    | the Id of the library to query                        |                                                       |
| `Tag`                                                 | [Tag](../../Models/Requests/Tag.md)                   | :heavy_check_mark:                                    | A key representing a specific tag within the section. |                                                       |
| `IncludeGuids`                                        | *long*                                                | :heavy_minus_sign:                                    | Adds the Guids object to the response<br/>            | 1                                                     |

### Response

**[GetLibraryItemsResponse](../../Models/Requests/GetLibraryItemsResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| PlexAPI.Models.Errors.GetLibraryItemsResponseBody | 401                                               | application/json                                  |
| PlexAPI.Models.Errors.SDKException                | 4xx-5xx                                           | */*                                               |


## GetRefreshLibraryMetadata

This endpoint Refreshes all the Metadata of the library.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.GetRefreshLibraryMetadataAsync(
    sectionId: 15D,
    force: PlexAPI.Models.Requests.Force.One
);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `SectionId`                                                       | *double*                                                          | :heavy_check_mark:                                                | The id of the library                                             | 15                                                                |
| `Force`                                                           | [Force](../../Models/Requests/Force.md)                           | :heavy_minus_sign:                                                | Force the refresh even if the library is already being refreshed. | 0                                                                 |

### Response

**[GetRefreshLibraryMetadataResponse](../../Models/Requests/GetRefreshLibraryMetadataResponse.md)**

### Errors

| Error Object                                                | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| PlexAPI.Models.Errors.GetRefreshLibraryMetadataResponseBody | 401                                                         | application/json                                            |
| PlexAPI.Models.Errors.SDKException                          | 4xx-5xx                                                     | */*                                                         |


## SearchLibrary

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
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.SearchLibraryAsync(
    sectionId: 933505,
    type: PlexAPI.Models.Requests.Type.Four
);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `SectionId`                                           | *long*                                                | :heavy_check_mark:                                    | the Id of the library to query                        |
| `Type`                                                | [Models.Requests.Type](../../Models/Requests/Type.md) | :heavy_check_mark:                                    | Plex content type to search for                       |

### Response

**[SearchLibraryResponse](../../Models/Requests/SearchLibraryResponse.md)**

### Errors

| Error Object                                    | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| PlexAPI.Models.Errors.SearchLibraryResponseBody | 401                                             | application/json                                |
| PlexAPI.Models.Errors.SDKException              | 4xx-5xx                                         | */*                                             |


## GetMetadata

This endpoint will return the metadata of a library item specified with the ratingKey.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.GetMetadataAsync(ratingKey: 8382.31D);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `RatingKey`                                           | *double*                                              | :heavy_check_mark:                                    | the id of the library item to return the children of. |

### Response

**[GetMetadataResponse](../../Models/Requests/GetMetadataResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| PlexAPI.Models.Errors.GetMetadataResponseBody | 401                                           | application/json                              |
| PlexAPI.Models.Errors.SDKException            | 4xx-5xx                                       | */*                                           |


## GetMetadataChildren

This endpoint will return the children of of a library item specified with the ratingKey.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

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

| Error Object                                          | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| PlexAPI.Models.Errors.GetMetadataChildrenResponseBody | 401                                                   | application/json                                      |
| PlexAPI.Models.Errors.SDKException                    | 4xx-5xx                                               | */*                                                   |


## GetTopWatchedContent

This endpoint will return the top watched content from libraries of a certain type


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.GetTopWatchedContentAsync(
    type: 505531,
    includeGuids: 1
);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `Type`                                              | *long*                                              | :heavy_check_mark:                                  | the library type (1 - movies, 2 - shows, 3 - music) |                                                     |
| `IncludeGuids`                                      | *long*                                              | :heavy_minus_sign:                                  | Adds the Guids object to the response<br/>          | 1                                                   |

### Response

**[GetTopWatchedContentResponse](../../Models/Requests/GetTopWatchedContentResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| PlexAPI.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## GetOnDeck

This endpoint will return the on deck content.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Library.GetOnDeckAsync();

// handle response
```

### Response

**[GetOnDeckResponse](../../Models/Requests/GetOnDeckResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| PlexAPI.Models.Errors.GetOnDeckResponseBody | 401                                         | application/json                            |
| PlexAPI.Models.Errors.SDKException          | 4xx-5xx                                     | */*                                         |
