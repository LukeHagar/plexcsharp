# UltraBlur

## Overview

Service provided to compute UltraBlur colors and images.

### Available Operations

* [GetColors](#getcolors) - Get UltraBlur Colors
* [GetImage](#getimage) - Get UltraBlur Image

## GetColors

Retrieves the four colors extracted from an image for clients to use to generate an ultrablur image.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getColors" method="get" path="/services/ultrablur/colors" -->
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

GetColorsRequest req = new GetColorsRequest() {
    Url = "/library/metadata/217745/art/1718931408",
};

var res = await sdk.UltraBlur.GetColorsAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [GetColorsRequest](../../Models/Requests/GetColorsRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[GetColorsResponse](../../Models/Requests/GetColorsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetImage

Retrieves a server-side generated UltraBlur image based on the provided color inputs. Clients should always call this via the photo transcoder endpoint.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getImage" method="get" path="/services/ultrablur/image" -->
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

GetImageRequest req = new GetImageRequest() {
    TopLeft = "3f280a",
    TopRight = "6b4713",
    BottomRight = "0f2a43",
    BottomLeft = "1c425d",
    Width = 1920,
    Height = 1080,
    Noise = BoolInt.True,
};

var res = await sdk.UltraBlur.GetImageAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetImageRequest](../../Models/Requests/GetImageRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[GetImageResponse](../../Models/Requests/GetImageResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |