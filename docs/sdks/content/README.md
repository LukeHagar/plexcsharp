# Content
(*Content*)

## Overview

The actual content of the media provider

### Available Operations

* [GetCollectionItems](#getcollectionitems) - Get items in a collection
* [GetMetadataItem](#getmetadataitem) - Get a metadata item
* [GetAlbums](#getalbums) - Set section albums
* [ListContent](#listcontent) - Get items in the section
* [GetAllLeaves](#getallleaves) - Set section leaves
* [GetArts](#getarts) - Set section artwork
* [GetCategories](#getcategories) - Set section categories
* [GetCluster](#getcluster) - Set section clusters
* [GetSonicPath](#getsonicpath) - Similar tracks to transition from one to another
* [GetFolders](#getfolders) - Get all folder locations
* [ListMoments](#listmoments) - Set section moments
* [GetSonicallySimilar](#getsonicallysimilar) - The nearest audio tracks
* [GetCollectionImage](#getcollectionimage) - Get a collection's image

## GetCollectionItems

Get items in a collection.  Note if this collection contains more than 100 items, paging must be used.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCollectionItems" method="get" path="/library/collections/{collectionId}/items" -->
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

GetCollectionItemsRequest req = new GetCollectionItemsRequest() {
    CollectionId = 314585,
};

var res = await sdk.Content.GetCollectionItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetCollectionItemsRequest](../../Models/Requests/GetCollectionItemsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetCollectionItemsResponse](../../Models/Requests/GetCollectionItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetMetadataItem

Get one or more metadata items.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMetadataItem" method="get" path="/library/metadata/{ids}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

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

GetMetadataItemRequest req = new GetMetadataItemRequest() {
    Ids = new List<string>() {},
    AsyncCheckFiles = BoolInt.True,
    AsyncRefreshLocalMediaAgent = BoolInt.True,
    AsyncRefreshAnalysis = BoolInt.True,
    CheckFiles = BoolInt.True,
    SkipRefresh = BoolInt.True,
    CheckFileAvailability = BoolInt.True,
    AsyncAugmentMetadata = BoolInt.True,
    AugmentCount = BoolInt.True,
};

var res = await sdk.Content.GetMetadataItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetMetadataItemRequest](../../Models/Requests/GetMetadataItemRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetMetadataItemResponse](../../Models/Requests/GetMetadataItemResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetAlbums

Get all albums in a music section

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAlbums" method="get" path="/library/sections/{sectionId}/albums" -->
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

GetAlbumsRequest req = new GetAlbumsRequest() {
    SectionId = 817133,
};

var res = await sdk.Content.GetAlbumsAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [GetAlbumsRequest](../../Models/Requests/GetAlbumsRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[GetAlbumsResponse](../../Models/Requests/GetAlbumsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ListContent

Get the items in a section, potentially filtering them

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listContent" method="get" path="/library/sections/{sectionId}/all" -->
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

ListContentRequest req = new ListContentRequest() {
    MediaQuery = new MediaQuery() {
        Type = MediaType.Episode,
        SourceType = 2,
        Sort = "duration:desc,index",
    },
    IncludeMeta = BoolInt.True,
    IncludeGuids = BoolInt.True,
    SectionId = "<id>",
};

var res = await sdk.Content.ListContentAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListContentRequest](../../Models/Requests/ListContentRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ListContentResponse](../../Models/Requests/ListContentResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetAllLeaves

Get all leaves in a section (such as episodes in a show section)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAllLeaves" method="get" path="/library/sections/{sectionId}/allLeaves" -->
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

GetAllLeavesRequest req = new GetAllLeavesRequest() {
    SectionId = 633197,
};

var res = await sdk.Content.GetAllLeavesAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetAllLeavesRequest](../../Models/Requests/GetAllLeavesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[GetAllLeavesResponse](../../Models/Requests/GetAllLeavesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetArts

Get artwork for a library section

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getArts" method="get" path="/library/sections/{sectionId}/arts" -->
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

GetArtsRequest req = new GetArtsRequest() {
    SectionId = 859200,
};

var res = await sdk.Content.GetArtsAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [GetArtsRequest](../../Models/Requests/GetArtsRequest.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[GetArtsResponse](../../Models/Requests/GetArtsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetCategories

Get categories in a library section

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCategories" method="get" path="/library/sections/{sectionId}/categories" -->
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

GetCategoriesRequest req = new GetCategoriesRequest() {
    SectionId = 21841,
};

var res = await sdk.Content.GetCategoriesAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetCategoriesRequest](../../Models/Requests/GetCategoriesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GetCategoriesResponse](../../Models/Requests/GetCategoriesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetCluster

Get clusters in a library section (typically for photos)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCluster" method="get" path="/library/sections/{sectionId}/cluster" -->
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

GetClusterRequest req = new GetClusterRequest() {
    SectionId = 138560,
};

var res = await sdk.Content.GetClusterAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetClusterRequest](../../Models/Requests/GetClusterRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetClusterResponse](../../Models/Requests/GetClusterResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetSonicPath

Get a list of audio tracks starting at one and ending at another which are similar across the path

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSonicPath" method="get" path="/library/sections/{sectionId}/computePath" -->
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

GetSonicPathRequest req = new GetSonicPathRequest() {
    SectionId = 914549,
    StartID = 629990,
    EndID = 687740,
};

var res = await sdk.Content.GetSonicPathAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetSonicPathRequest](../../Models/Requests/GetSonicPathRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[GetSonicPathResponse](../../Models/Requests/GetSonicPathResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetFolders

Get all folder locations of the media in a section

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getFolders" method="get" path="/library/sections/{sectionId}/location" -->
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

GetFoldersRequest req = new GetFoldersRequest() {
    SectionId = 892532,
};

var res = await sdk.Content.GetFoldersAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetFoldersRequest](../../Models/Requests/GetFoldersRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetFoldersResponse](../../Models/Requests/GetFoldersResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ListMoments

Get moments in a library section (typically for photos)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listMoments" method="get" path="/library/sections/{sectionId}/moment" -->
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

ListMomentsRequest req = new ListMomentsRequest() {
    SectionId = 403239,
};

var res = await sdk.Content.ListMomentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListMomentsRequest](../../Models/Requests/ListMomentsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ListMomentsResponse](../../Models/Requests/ListMomentsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetSonicallySimilar

Get the nearest audio tracks to a particular analysis

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSonicallySimilar" method="get" path="/library/sections/{sectionId}/nearest" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

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

GetSonicallySimilarRequest req = new GetSonicallySimilarRequest() {
    SectionId = 525956,
    Values = new List<long>() {},
};

var res = await sdk.Content.GetSonicallySimilarAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetSonicallySimilarRequest](../../Models/Requests/GetSonicallySimilarRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetSonicallySimilarResponse](../../Models/Requests/GetSonicallySimilarResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetCollectionImage

Get an image for the collection based on the items within

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCollectionImage" method="get" path="/library/collections/{collectionId}/composite/{updatedAt}" -->
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

GetCollectionImageRequest req = new GetCollectionImageRequest() {
    CollectionId = 474227,
    UpdatedAt = 759379,
};

var res = await sdk.Content.GetCollectionImageAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetCollectionImageRequest](../../Models/Requests/GetCollectionImageRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetCollectionImageResponse](../../Models/Requests/GetCollectionImageResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |