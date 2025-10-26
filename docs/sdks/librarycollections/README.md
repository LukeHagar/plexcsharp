# LibraryCollections
(*LibraryCollections*)

## Overview

Endpoints for manipulating collections.  In addition to these endpoints, `/library/collections/:collectionId/X` will be rerouted to `/library/metadata/:collectionId/X` and respond to those endpoints as well.

### Available Operations

* [AddCollectionItems](#addcollectionitems) - Add items to a collection
* [DeleteCollectionItem](#deletecollectionitem) - Delete an item from a collection
* [MoveCollectionItem](#movecollectionitem) - Reorder an item in the collection

## AddCollectionItems

Add items to a collection by uri

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addCollectionItems" method="put" path="/library/collections/{collectionId}/items" -->
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

AddCollectionItemsRequest req = new AddCollectionItemsRequest() {
    CollectionId = 338144,
    Uri = "https://expensive-bakeware.com",
};

var res = await sdk.LibraryCollections.AddCollectionItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [AddCollectionItemsRequest](../../Models/Requests/AddCollectionItemsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[AddCollectionItemsResponse](../../Models/Requests/AddCollectionItemsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeleteCollectionItem

Delete an item from a collection

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteCollectionItem" method="put" path="/library/collections/{collectionId}/items/{itemId}" -->
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

DeleteCollectionItemRequest req = new DeleteCollectionItemRequest() {
    CollectionId = 320928,
    ItemId = 406983,
};

var res = await sdk.LibraryCollections.DeleteCollectionItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [DeleteCollectionItemRequest](../../Models/Requests/DeleteCollectionItemRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[DeleteCollectionItemResponse](../../Models/Requests/DeleteCollectionItemResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## MoveCollectionItem

Reorder items in a collection with one item after another

### Example Usage

<!-- UsageSnippet language="csharp" operationID="moveCollectionItem" method="put" path="/library/collections/{collectionId}/items/{itemId}/move" -->
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

MoveCollectionItemRequest req = new MoveCollectionItemRequest() {
    CollectionId = 239532,
    ItemId = 513864,
};

var res = await sdk.LibraryCollections.MoveCollectionItemAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [MoveCollectionItemRequest](../../Models/Requests/MoveCollectionItemRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[MoveCollectionItemResponse](../../Models/Requests/MoveCollectionItemResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |