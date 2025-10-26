# Rate
(*Rate*)

## Overview

Operations for rating media items (thumbs up/down, star ratings, etc.)

### Available Operations

* [SetRating](#setrating) - Rate an item

## SetRating

Set the rating on an item.
This API does respond to the GET verb but applications should use PUT

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setRating" method="put" path="/:/rate" -->
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

SetRatingRequest req = new SetRatingRequest() {
    Identifier = "<value>",
    Key = "<key>",
    Rating = 8722.46D,
};

var res = await sdk.Rate.SetRatingAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [SetRatingRequest](../../Models/Requests/SetRatingRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[SetRatingResponse](../../Models/Requests/SetRatingResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |