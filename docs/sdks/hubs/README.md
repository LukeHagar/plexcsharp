# Hubs

## Overview

The hubs within a media provider

### Available Operations

* [GetAllHubs](#getallhubs) - Get global hubs
* [GetContinueWatching](#getcontinuewatching) - Get the continue watching hub
* [GetHubItems](#gethubitems) - Get a hub's items
* [GetPromotedHubs](#getpromotedhubs) - Get the hubs which are promoted
* [GetMetadataHubs](#getmetadatahubs) - Get hubs for section by metadata item
* [GetPostplayHubs](#getpostplayhubs) - Get postplay hubs
* [GetRelatedHubs](#getrelatedhubs) - Get related hubs
* [GetSectionHubs](#getsectionhubs) - Get section hubs
* [ResetSectionDefaults](#resetsectiondefaults) - Reset hubs to defaults
* [ListHubs](#listhubs) - Get hubs
* [CreateCustomHub](#createcustomhub) - Create a custom hub
* [MoveHub](#movehub) - Move Hub
* [DeleteCustomHub](#deletecustomhub) - Delete a custom hub
* [UpdateHubVisibility](#updatehubvisibility) - Change hub visibility

## GetAllHubs

Get the global hubs in this PMS

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAllHubs" method="get" path="/hubs" -->
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

GetAllHubsRequest req = new GetAllHubsRequest() {
    OnlyTransient = BoolInt.True,
};

var res = await sdk.Hubs.GetAllHubsAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetAllHubsRequest](../../Models/Requests/GetAllHubsRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetAllHubsResponse](../../Models/Requests/GetAllHubsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetContinueWatching

Get the global continue watching hub

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getContinueWatching" method="get" path="/hubs/continueWatching" -->
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

GetContinueWatchingRequest req = new GetContinueWatchingRequest() {};

var res = await sdk.Hubs.GetContinueWatchingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetContinueWatchingRequest](../../Models/Requests/GetContinueWatchingRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetContinueWatchingResponse](../../Models/Requests/GetContinueWatchingResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetHubItems

Get the items within a single hub specified by identifier

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHubItems" method="get" path="/hubs/items" -->
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

GetHubItemsRequest req = new GetHubItemsRequest() {
    Identifier = new List<string>() {
        "<value 1>",
        "<value 2>",
        "<value 3>",
    },
};

var res = await sdk.Hubs.GetHubItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetHubItemsRequest](../../Models/Requests/GetHubItemsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetHubItemsResponse](../../Models/Requests/GetHubItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetPromotedHubs

Get the global hubs which are promoted (should be displayed on the home screen)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPromotedHubs" method="get" path="/hubs/promoted" -->
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

GetPromotedHubsRequest req = new GetPromotedHubsRequest() {};

var res = await sdk.Hubs.GetPromotedHubsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetPromotedHubsRequest](../../Models/Requests/GetPromotedHubsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetPromotedHubsResponse](../../Models/Requests/GetPromotedHubsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetMetadataHubs

Get the hubs for a section by metadata item.  Currently only for music sections

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getMetadataHubs" method="get" path="/hubs/metadata/{metadataId}" -->
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

GetMetadataHubsRequest req = new GetMetadataHubsRequest() {
    MetadataId = 605482,
    OnlyTransient = BoolInt.True,
};

var res = await sdk.Hubs.GetMetadataHubsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetMetadataHubsRequest](../../Models/Requests/GetMetadataHubsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetMetadataHubsResponse](../../Models/Requests/GetMetadataHubsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetPostplayHubs

Get the hubs for a metadata to be displayed in post play

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPostplayHubs" method="get" path="/hubs/metadata/{metadataId}/postplay" -->
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

GetPostplayHubsRequest req = new GetPostplayHubsRequest() {
    MetadataId = 441419,
    OnlyTransient = BoolInt.True,
};

var res = await sdk.Hubs.GetPostplayHubsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetPostplayHubsRequest](../../Models/Requests/GetPostplayHubsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetPostplayHubsResponse](../../Models/Requests/GetPostplayHubsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetRelatedHubs

Get the hubs for a metadata related to the provided metadata item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getRelatedHubs" method="get" path="/hubs/metadata/{metadataId}/related" -->
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

GetRelatedHubsRequest req = new GetRelatedHubsRequest() {
    MetadataId = 8858,
    OnlyTransient = BoolInt.True,
};

var res = await sdk.Hubs.GetRelatedHubsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetRelatedHubsRequest](../../Models/Requests/GetRelatedHubsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetRelatedHubsResponse](../../Models/Requests/GetRelatedHubsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetSectionHubs

Get the hubs for a single section

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSectionHubs" method="get" path="/hubs/sections/{sectionId}" -->
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

GetSectionHubsRequest req = new GetSectionHubsRequest() {
    SectionId = 336924,
    OnlyTransient = BoolInt.True,
};

var res = await sdk.Hubs.GetSectionHubsAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetSectionHubsRequest](../../Models/Requests/GetSectionHubsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetSectionHubsResponse](../../Models/Requests/GetSectionHubsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ResetSectionDefaults

Reset hubs for this section to defaults and delete custom hubs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="resetSectionDefaults" method="delete" path="/hubs/sections/{sectionId}/manage" -->
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

ResetSectionDefaultsRequest req = new ResetSectionDefaultsRequest() {
    SectionId = 383022,
};

var res = await sdk.Hubs.ResetSectionDefaultsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ResetSectionDefaultsRequest](../../Models/Requests/ResetSectionDefaultsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ResetSectionDefaultsResponse](../../Models/Requests/ResetSectionDefaultsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ListHubs

Get the list of hubs including both built-in and custom

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listHubs" method="get" path="/hubs/sections/{sectionId}/manage" -->
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

ListHubsRequest req = new ListHubsRequest() {
    SectionId = 442546,
};

var res = await sdk.Hubs.ListHubsAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [ListHubsRequest](../../Models/Requests/ListHubsRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[ListHubsResponse](../../Models/Requests/ListHubsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## CreateCustomHub

Create a custom hub based on a metadata item

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createCustomHub" method="post" path="/hubs/sections/{sectionId}/manage" -->
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

CreateCustomHubRequest req = new CreateCustomHubRequest() {
    SectionId = 869922,
    MetadataItemId = 703843,
    PromotedToRecommended = BoolInt.True,
    PromotedToOwnHome = BoolInt.True,
    PromotedToSharedHome = BoolInt.True,
};

var res = await sdk.Hubs.CreateCustomHubAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateCustomHubRequest](../../Models/Requests/CreateCustomHubRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[CreateCustomHubResponse](../../Models/Requests/CreateCustomHubResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## MoveHub

Changed the ordering of a hub among others hubs

### Example Usage

<!-- UsageSnippet language="csharp" operationID="moveHub" method="put" path="/hubs/sections/{sectionId}/manage/move" -->
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

MoveHubRequest req = new MoveHubRequest() {
    SectionId = 755710,
    Identifier = "<value>",
};

var res = await sdk.Hubs.MoveHubAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [MoveHubRequest](../../Models/Requests/MoveHubRequest.md) | :heavy_check_mark:                                        | The request object to use for the request.                |

### Response

**[MoveHubResponse](../../Models/Requests/MoveHubResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeleteCustomHub

Delete a custom hub from the server

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteCustomHub" method="delete" path="/hubs/sections/{sectionId}/manage/{identifier}" -->
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

DeleteCustomHubRequest req = new DeleteCustomHubRequest() {
    SectionId = 625677,
    Identifier = "<value>",
};

var res = await sdk.Hubs.DeleteCustomHubAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [DeleteCustomHubRequest](../../Models/Requests/DeleteCustomHubRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[DeleteCustomHubResponse](../../Models/Requests/DeleteCustomHubResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## UpdateHubVisibility

Changed the visibility of a hub for both the admin and shared users

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateHubVisibility" method="put" path="/hubs/sections/{sectionId}/manage/{identifier}" -->
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

UpdateHubVisibilityRequest req = new UpdateHubVisibilityRequest() {
    SectionId = 341650,
    Identifier = "<value>",
    PromotedToRecommended = BoolInt.True,
    PromotedToOwnHome = BoolInt.True,
    PromotedToSharedHome = BoolInt.True,
};

var res = await sdk.Hubs.UpdateHubVisibilityAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [UpdateHubVisibilityRequest](../../Models/Requests/UpdateHubVisibilityRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[UpdateHubVisibilityResponse](../../Models/Requests/UpdateHubVisibilityResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |