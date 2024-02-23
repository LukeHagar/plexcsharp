# Sessions
(*Sessions*)

## Overview

API Calls that perform search operations with Plex Media Server Sessions


### Available Operations

* [GetSessions](#getsessions) - Get Active Sessions
* [GetSessionHistory](#getsessionhistory) - Get Session History
* [GetTranscodeSessions](#gettranscodesessions) - Get Transcode Sessions
* [StopTranscodeSession](#stoptranscodesession) - Stop a Transcode Session

## GetSessions

This will retrieve the "Now Playing" Information of the PMS.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Sessions.GetSessionsAsync();

// handle response
```


### Response

**[GetSessionsResponse](../../Models/Requests/GetSessionsResponse.md)**


## GetSessionHistory

This will Retrieve a listing of all history views.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Sessions.GetSessionHistoryAsync();

// handle response
```


### Response

**[GetSessionHistoryResponse](../../Models/Requests/GetSessionHistoryResponse.md)**


## GetTranscodeSessions

Get Transcode Sessions

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Sessions.GetTranscodeSessionsAsync();

// handle response
```


### Response

**[GetTranscodeSessionsResponse](../../Models/Requests/GetTranscodeSessionsResponse.md)**


## StopTranscodeSession

Stop a Transcode Session

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Sessions.StopTranscodeSessionAsync(sessionKey: "zz7llzqlx8w9vnrsbnwhbmep");

// handle response
```

### Parameters

| Parameter                                | Type                                     | Required                                 | Description                              | Example                                  |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| `SessionKey`                             | *string*                                 | :heavy_check_mark:                       | the Key of the transcode session to stop | zz7llzqlx8w9vnrsbnwhbmep                 |


### Response

**[StopTranscodeSessionResponse](../../Models/Requests/StopTranscodeSessionResponse.md)**

