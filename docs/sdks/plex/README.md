# Plex
(*Plex*)

## Overview

API Calls that perform operations directly against https://Plex.tv


### Available Operations

* [GetCompanionsData](#getcompanionsdata) - Get Companions Data
* [GetUserFriends](#getuserfriends) - Get list of friends of the user logged in
* [GetGeoData](#getgeodata) - Get Geo Data
* [GetHomeData](#gethomedata) - Get Plex Home Data
* [GetServerResources](#getserverresources) - Get Server Resources
* [GetPin](#getpin) - Get a Pin
* [GetTokenByPinId](#gettokenbypinid) - Get Access Token by PinId

## GetCompanionsData

Get Companions Data

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCompanionsData" method="get" path="/companions" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Plex.GetCompanionsDataAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[GetCompanionsDataResponse](../../Models/Requests/GetCompanionsDataResponse.md)**

### Errors

| Error Type                                                        | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetCompanionsDataBadRequest   | 400                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetCompanionsDataUnauthorized | 401                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                  | 4XX, 5XX                                                          | \*/\*                                                             |

## GetUserFriends

Get friends of provided auth token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getUserFriends" method="get" path="/friends" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Plex.GetUserFriendsAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[GetUserFriendsResponse](../../Models/Requests/GetUserFriendsResponse.md)**

### Errors

| Error Type                                                     | Status Code                                                    | Content Type                                                   |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetUserFriendsBadRequest   | 400                                                            | application/json                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetUserFriendsUnauthorized | 401                                                            | application/json                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException               | 4XX, 5XX                                                       | \*/\*                                                          |

## GetGeoData

Returns the geolocation and locale data of the caller

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getGeoData" method="get" path="/geoip" -->
```csharp
using LukeHagar.PlexAPI.SDK;

var sdk = new PlexAPI();

var res = await sdk.Plex.GetGeoDataAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[GetGeoDataResponse](../../Models/Requests/GetGeoDataResponse.md)**

### Errors

| Error Type                                                 | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetGeoDataBadRequest   | 400                                                        | application/json                                           |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetGeoDataUnauthorized | 401                                                        | application/json                                           |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException           | 4XX, 5XX                                                   | \*/\*                                                      |

## GetHomeData

Retrieves the home data for the authenticated user, including details like home ID, name, guest access information, and subscription status.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getHomeData" method="get" path="/home" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Plex.GetHomeDataAsync();

// handle response
```

### Response

**[GetHomeDataResponse](../../Models/Requests/GetHomeDataResponse.md)**

### Errors

| Error Type                                                  | Status Code                                                 | Content Type                                                |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetHomeDataBadRequest   | 400                                                         | application/json                                            |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetHomeDataUnauthorized | 401                                                         | application/json                                            |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException            | 4XX, 5XX                                                    | \*/\*                                                       |

## GetServerResources

Get Plex server access tokens and server connections

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-server-resources" method="get" path="/resources" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Plex.GetServerResourcesAsync(
    clientID: "3381b62b-9ab7-4e37-827b-203e9809eb58",
    includeHttps: IncludeHttps.Enable,
    includeRelay: IncludeRelay.Enable,
    includeIPv6: IncludeIPv6.Enable
);

// handle response
```

### Parameters

| Parameter                                                                                                          | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        | Example                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `ClientID`                                                                                                         | *string*                                                                                                           | :heavy_check_mark:                                                                                                 | An opaque identifier unique to the client (UUID, serial number, or other unique device ID)                         | 3381b62b-9ab7-4e37-827b-203e9809eb58                                                                               |
| `IncludeHttps`                                                                                                     | [IncludeHttps](../../Models/Requests/IncludeHttps.md)                                                              | :heavy_minus_sign:                                                                                                 | Include Https entries in the results                                                                               | 1                                                                                                                  |
| `IncludeRelay`                                                                                                     | [IncludeRelay](../../Models/Requests/IncludeRelay.md)                                                              | :heavy_minus_sign:                                                                                                 | Include Relay addresses in the results <br/>E.g: https://10-0-0-25.bbf8e10c7fa20447cacee74cd9914cde.plex.direct:32400<br/> | 1                                                                                                                  |
| `IncludeIPv6`                                                                                                      | [IncludeIPv6](../../Models/Requests/IncludeIPv6.md)                                                                | :heavy_minus_sign:                                                                                                 | Include IPv6 entries in the results                                                                                | 1                                                                                                                  |
| `serverURL`                                                                                                        | *string*                                                                                                           | :heavy_minus_sign:                                                                                                 | An optional server URL to use.                                                                                     | http://localhost:8080                                                                                              |

### Response

**[GetServerResourcesResponse](../../Models/Requests/GetServerResourcesResponse.md)**

### Errors

| Error Type                                                         | Status Code                                                        | Content Type                                                       |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerResourcesBadRequest   | 400                                                                | application/json                                                   |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerResourcesUnauthorized | 401                                                                | application/json                                                   |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                   | 4XX, 5XX                                                           | \*/\*                                                              |

## GetPin

Retrieve a Pin ID from Plex.tv to use for authentication flows

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPin" method="post" path="/pins" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI();

GetPinRequest req = new GetPinRequest() {
    ClientID = "3381b62b-9ab7-4e37-827b-203e9809eb58",
    ClientName = "Plex for Roku",
    DeviceNickname = "Roku 3",
    ClientVersion = "2.4.1",
    Platform = "Roku",
};

var res = await sdk.Plex.GetPinAsync(req);

// handle response
```

### Parameters

| Parameter                                               | Type                                                    | Required                                                | Description                                             |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| `request`                                               | [GetPinRequest](../../Models/Requests/GetPinRequest.md) | :heavy_check_mark:                                      | The request object to use for the request.              |
| `serverURL`                                             | *string*                                                | :heavy_minus_sign:                                      | An optional server URL to use.                          |

### Response

**[GetPinResponse](../../Models/Requests/GetPinResponse.md)**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetPinBadRequest | 400                                                  | application/json                                     |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException     | 4XX, 5XX                                             | \*/\*                                                |

## GetTokenByPinId

Retrieve an Access Token from Plex.tv after the Pin has been authenticated

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTokenByPinId" method="get" path="/pins/{pinID}" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI();

GetTokenByPinIdRequest req = new GetTokenByPinIdRequest() {
    PinID = 232248,
    ClientID = "3381b62b-9ab7-4e37-827b-203e9809eb58",
    ClientName = "Plex for Roku",
    DeviceNickname = "Roku 3",
    ClientVersion = "2.4.1",
    Platform = "Roku",
};

var res = await sdk.Plex.GetTokenByPinIdAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetTokenByPinIdRequest](../../Models/Requests/GetTokenByPinIdRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |
| `serverURL`                                                               | *string*                                                                  | :heavy_minus_sign:                                                        | An optional server URL to use.                                            |

### Response

**[GetTokenByPinIdResponse](../../Models/Requests/GetTokenByPinIdResponse.md)**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetTokenByPinIdBadRequest   | 400                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetTokenByPinIdResponseBody | 404                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                | 4XX, 5XX                                                        | \*/\*                                                           |