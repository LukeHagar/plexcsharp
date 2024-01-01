# Log
(*Log*)

## Overview

Submit logs to the Log Handler for Plex Media Server


### Available Operations

* [LogLine](#logline) - Logging a single line message.
* [LogMultiLine](#logmultiline) - Logging a multi-line message
* [EnablePaperTrail](#enablepapertrail) - Enabling Papertrail

## LogLine

This endpoint will write a single-line log message, including a level and source to the main Plex Media Server log.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Log.LogLineAsync(Level: Level.Three, Message: "string", Source: "string");

// handle response
```

### Parameters

| Parameter                                                                                                    | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  | Example                                                                                                      |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `Level`                                                                                                      | [Level](../../Models/Requests/Level.md)                                                                      | :heavy_check_mark:                                                                                           | An integer log level to write to the PMS log with.  <br/>0: Error  <br/>1: Warning  <br/>2: Info <br/>3: Debug  <br/>4: Verbose<br/> |                                                                                                              |
| `Message`                                                                                                    | *string*                                                                                                     | :heavy_check_mark:                                                                                           | The text of the message to write to the log.                                                                 |                                                                                                              |
| `Source`                                                                                                     | *string*                                                                                                     | :heavy_check_mark:                                                                                           | a string indicating the source of the message.                                                               |                                                                                                              |


### Response

**[LogLineResponse](../../Models/Requests/LogLineResponse.md)**


## LogMultiLine

This endpoint will write multiple lines to the main Plex Media Server log in a single request. It takes a set of query strings as would normally sent to the above GET endpoint as a linefeed-separated block of POST data. The parameters for each query string match as above.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Log.LogMultiLineAsync();

// handle response
```


### Response

**[LogMultiLineResponse](../../Models/Requests/LogMultiLineResponse.md)**


## EnablePaperTrail

This endpoint will enable all Plex Media Serverlogs to be sent to the Papertrail networked logging site for a period of time.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Log.EnablePaperTrailAsync();

// handle response
```


### Response

**[EnablePaperTrailResponse](../../Models/Requests/EnablePaperTrailResponse.md)**

