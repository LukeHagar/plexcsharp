# Users
(*Users*)

## Overview

### Available Operations

* [GetUsers](#getusers) - Get list of all connected users

## GetUsers

Get list of all users that are friends and have library access with the provided Plex authentication token

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-users" method="get" path="/users" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI();

GetUsersRequest req = new GetUsersRequest() {
    ClientID = "3381b62b-9ab7-4e37-827b-203e9809eb58",
    ClientName = "Plex for Roku",
    DeviceNickname = "Roku 3",
    DeviceName = "Chrome",
    DeviceScreenResolution = "1487x1165,2560x1440",
    ClientVersion = "2.4.1",
    Platform = "Roku",
    ClientFeatures = "external-media,indirect-media,hub-style-list",
    Model = "4200X",
    XPlexSessionId = "97e136ef-4ddd-4ff3-89a7-a5820c96c2ca",
    XPlexLanguage = "en",
    PlatformVersion = "4.3 build 1057",
    XPlexToken = "CV5xoxjTpFKUzBTShsaf",
};

var res = await sdk.Users.GetUsersAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetUsersRequest](../../Models/Requests/GetUsersRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |
| `serverURL`                                                 | *string*                                                    | :heavy_minus_sign:                                          | An optional server URL to use.                              |

### Response

**[GetUsersResponse](../../Models/Requests/GetUsersResponse.md)**

### Errors

| Error Type                                               | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetUsersBadRequest   | 400                                                      | application/json                                         |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetUsersUnauthorized | 401                                                      | application/json                                         |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException         | 4XX, 5XX                                                 | \*/\*                                                    |