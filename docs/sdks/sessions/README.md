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

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Sessions.GetSessionsAsync();

// handle response
```

### Response

**[GetSessionsResponse](../../Models/Requests/GetSessionsResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| PlexAPI.Models.Errors.GetSessionsResponseBody | 401                                           | application/json                              |
| PlexAPI.Models.Errors.SDKException            | 4xx-5xx                                       | */*                                           |


## GetSessionHistory

This will Retrieve a listing of all history views.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Sessions.GetSessionHistoryAsync(
    sort: "<value>",
    accountId: 1,
    filter: new Filter() {},
    librarySectionID: 12
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                                                     | Type                                                                                                                                                                                          | Required                                                                                                                                                                                      | Description                                                                                                                                                                                   | Example                                                                                                                                                                                       |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Sort`                                                                                                                                                                                        | *string*                                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                            | Sorts the results by the specified field followed by the direction (asc, desc)<br/>                                                                                                           |                                                                                                                                                                                               |
| `AccountId`                                                                                                                                                                                   | *long*                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                            | Filter results by those that are related to a specific users id<br/>                                                                                                                          | 1                                                                                                                                                                                             |
| `Filter`                                                                                                                                                                                      | [Filter](../../Models/Requests/Filter.md)                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                            | Filters content by field and direction/equality<br/>(Unknown if viewedAt is the only supported column)<br/>                                                                                   | {<br/>"viewed-at-greater-than": {<br/>"value": "viewedAt\u003e"<br/>},<br/>"viewed-at-greater-than-or-equal-to": {<br/>"value": "viewedAt\u003e=\u003e"<br/>},<br/>"viewed-at-less-than": {<br/>"value": "viewedAt\u003c"<br/>}<br/>} |
| `LibrarySectionID`                                                                                                                                                                            | *long*                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                            | Filters the results based on the id of a valid library section<br/>                                                                                                                           | 12                                                                                                                                                                                            |

### Response

**[GetSessionHistoryResponse](../../Models/Requests/GetSessionHistoryResponse.md)**

### Errors

| Error Object                                        | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| PlexAPI.Models.Errors.GetSessionHistoryResponseBody | 401                                                 | application/json                                    |
| PlexAPI.Models.Errors.SDKException                  | 4xx-5xx                                             | */*                                                 |


## GetTranscodeSessions

Get Transcode Sessions

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Sessions.GetTranscodeSessionsAsync();

// handle response
```

### Response

**[GetTranscodeSessionsResponse](../../Models/Requests/GetTranscodeSessionsResponse.md)**

### Errors

| Error Object                                           | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| PlexAPI.Models.Errors.GetTranscodeSessionsResponseBody | 401                                                    | application/json                                       |
| PlexAPI.Models.Errors.SDKException                     | 4xx-5xx                                                | */*                                                    |


## StopTranscodeSession

Stop a Transcode Session

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Sessions.StopTranscodeSessionAsync(sessionKey: "zz7llzqlx8w9vnrsbnwhbmep");

// handle response
```

### Parameters

| Parameter                                | Type                                     | Required                                 | Description                              | Example                                  |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| `SessionKey`                             | *string*                                 | :heavy_check_mark:                       | the Key of the transcode session to stop | zz7llzqlx8w9vnrsbnwhbmep                 |

### Response

**[StopTranscodeSessionResponse](../../Models/Requests/StopTranscodeSessionResponse.md)**

### Errors

| Error Object                                           | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| PlexAPI.Models.Errors.StopTranscodeSessionResponseBody | 401                                                    | application/json                                       |
| PlexAPI.Models.Errors.SDKException                     | 4xx-5xx                                                | */*                                                    |
