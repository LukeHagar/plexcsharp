# Log

## Overview

Logging mechanism to allow clients to log to the server

### Available Operations

* [WriteLog](#writelog) - Logging a multi-line message to the Plex Media Server log
* [WriteMessage](#writemessage) - Logging a single-line message to the Plex Media Server log
* [EnablePapertrail](#enablepapertrail) - Enabling Papertrail

## WriteLog

This endpoint will write multiple lines to the main Plex Media Server log in a single request. It takes a set of query strings as would normally sent to the above PUT endpoint as a linefeed-separated block of POST data. The parameters for each query string match as above.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="writeLog" method="post" path="/log" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using System;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

byte[] req = System.Text.Encoding.UTF8.GetBytes("0x0Ce2fFcEBF");

var res = await sdk.Log.WriteLogAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *byte[]*                                   | :heavy_check_mark:                         | The request object to use for the request. |

### Response

**[WriteLogResponse](../../Models/Requests/WriteLogResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## WriteMessage

This endpoint will write a single-line log message, including a level and source to the main Plex Media Server log.

Note: This endpoint responds to all HTTP verbs **except POST** but PUT is preferred


### Example Usage

<!-- UsageSnippet language="csharp" operationID="writeMessage" method="put" path="/log" -->
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

WriteMessageRequest req = new WriteMessageRequest() {};

var res = await sdk.Log.WriteMessageAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [WriteMessageRequest](../../Models/Requests/WriteMessageRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[WriteMessageResponse](../../Models/Requests/WriteMessageResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## EnablePapertrail

This endpoint will enable all Plex Media Server logs to be sent to the Papertrail networked logging site for a period of time

Note: This endpoint responds to all HTTP verbs but POST is preferred


### Example Usage

<!-- UsageSnippet language="csharp" operationID="enablePapertrail" method="post" path="/log/networked" -->
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

EnablePapertrailRequest req = new EnablePapertrailRequest() {};

var res = await sdk.Log.EnablePapertrailAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [EnablePapertrailRequest](../../Models/Requests/EnablePapertrailRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[EnablePapertrailResponse](../../Models/Requests/EnablePapertrailResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |