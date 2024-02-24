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

var sdk = new PlexAPISDK(AccessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Log.LogLineAsync(
    level: Level.Three,
    message: "Test log message",
    source: "Postman");

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   | Example                                                                                                       |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `Level`                                                                                                       | [Level](../../Models/Requests/Level.md)                                                                       | :heavy_check_mark:                                                                                            | An integer log level to write to the PMS log with.  <br/>0: Error  <br/>1: Warning  <br/>2: Info  <br/>3: Debug  <br/>4: Verbose<br/> |                                                                                                               |
| `Message`                                                                                                     | *string*                                                                                                      | :heavy_check_mark:                                                                                            | The text of the message to write to the log.                                                                  | Test log message                                                                                              |
| `Source`                                                                                                      | *string*                                                                                                      | :heavy_check_mark:                                                                                            | a string indicating the source of the message.                                                                | Postman                                                                                                       |


### Response

**[LogLineResponse](../../Models/Requests/LogLineResponse.md)**


## LogMultiLine

This endpoint allows for the batch addition of log entries to the main Plex Media Server log.  
It accepts a text/plain request body, where each line represents a distinct log entry.  
Each log entry consists of URL-encoded key-value pairs, specifying log attributes such as 'level', 'message', and 'source'.  

Log entries are separated by a newline character (`\n`).  
Each entry's parameters should be URL-encoded to ensure accurate parsing and handling of special characters.  
This method is efficient for logging multiple entries in a single API call, reducing the overhead of multiple individual requests.  

The 'level' parameter specifies the log entry's severity or importance, with the following integer values:
- `0`: Error - Critical issues that require immediate attention.
- `1`: Warning - Important events that are not critical but may indicate potential issues.
- `2`: Info - General informational messages about system operation.
- `3`: Debug - Detailed information useful for debugging purposes.
- `4`: Verbose - Highly detailed diagnostic information for in-depth analysis.

The 'message' parameter contains the log text, and 'source' identifies the log message's origin (e.g., an application name or module).

Example of a single log entry format:
`level=4&message=Sample%20log%20entry&source=applicationName`

Ensure each parameter is properly URL-encoded to avoid interpretation issues.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(AccessToken: "<YOUR_API_KEY_HERE>");

string req = "level=4&message=Test%20message%201&source=postman
level=3&message=Test%20message%202&source=postman
level=1&message=Test%20message%203&source=postman";

var res = await sdk.Log.LogMultiLineAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *string*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[LogMultiLineResponse](../../Models/Requests/LogMultiLineResponse.md)**


## EnablePaperTrail

This endpoint will enable all Plex Media Serverlogs to be sent to the Papertrail networked logging site for a period of time.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(AccessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Log.EnablePaperTrailAsync();

// handle response
```


### Response

**[EnablePaperTrailResponse](../../Models/Requests/EnablePaperTrailResponse.md)**

