# Plex
(*Plex*)

## Overview

API Calls that perform operations directly against https://Plex.tv


### Available Operations

* [GetCompanionsData](#getcompanionsdata) - Get Companions Data
* [GetUserFriends](#getuserfriends) - Get list of friends of the user logged in
* [GetGeoData](#getgeodata) - Get Geo Data
* [GetHomeData](#gethomedata) - Get Plex Home Data
* [GetResources](#getresources) - Get Resources
* [GetPin](#getpin) - Get a Pin
* [GetTokenByPinId](#gettokenbypinid) - Get Access Token by PinId
* [GetUserDetails](#getuserdetails) - Get UserData By Token

## GetCompanionsData

Get Companions Data

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

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

| Error Object                                        | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| PlexAPI.Models.Errors.GetCompanionsDataResponseBody | 401                                                 | application/json                                    |
| PlexAPI.Models.Errors.SDKException                  | 4xx-5xx                                             | */*                                                 |


## GetUserFriends

Get friends of provided auth token.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

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

| Error Object                                     | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| PlexAPI.Models.Errors.GetUserFriendsResponseBody | 401                                              | application/json                                 |
| PlexAPI.Models.Errors.SDKException               | 4xx-5xx                                          | */*                                              |


## GetGeoData

Returns the geolocation and locale data of the caller

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(xPlexClientIdentifier: "Postman");

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

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| PlexAPI.Models.Errors.GetGeoDataResponseBody | 401                                          | application/json                             |
| PlexAPI.Models.Errors.SDKException           | 4xx-5xx                                      | */*                                          |


## GetHomeData

Retrieves the home data for the authenticated user, including details like home ID, name, guest access information, and subscription status.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Plex.GetHomeDataAsync();

// handle response
```

### Response

**[GetHomeDataResponse](../../Models/Requests/GetHomeDataResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| PlexAPI.Models.Errors.GetHomeDataResponseBody | 401                                           | application/json                              |
| PlexAPI.Models.Errors.SDKException            | 4xx-5xx                                       | */*                                           |


## GetResources

Get Resources

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(xPlexClientIdentifier: "Postman");

var res = await sdk.Plex.GetResourcesAsync(
    xPlexClientIdentifier: "Postman",
    includeHttps: PlexAPI.Models.Requests.IncludeHttps.Zero,
    includeRelay: PlexAPI.Models.Requests.IncludeRelay.Zero,
    includeIPv6: PlexAPI.Models.Requests.IncludeIPv6.One
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                             | Type                                                                                                                                                                  | Required                                                                                                                                                              | Description                                                                                                                                                           | Example                                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `XPlexClientIdentifier`                                                                                                                                               | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | The unique identifier for the client application<br/>This is used to track the client application and its usage<br/>(UUID, serial number, or other number unique per device)<br/> | Postman                                                                                                                                                               |
| `IncludeHttps`                                                                                                                                                        | [IncludeHttps](../../Models/Requests/IncludeHttps.md)                                                                                                                 | :heavy_minus_sign:                                                                                                                                                    | Include Https entries in the results                                                                                                                                  |                                                                                                                                                                       |
| `IncludeRelay`                                                                                                                                                        | [IncludeRelay](../../Models/Requests/IncludeRelay.md)                                                                                                                 | :heavy_minus_sign:                                                                                                                                                    | Include Relay addresses in the results                                                                                                                                |                                                                                                                                                                       |
| `IncludeIPv6`                                                                                                                                                         | [IncludeIPv6](../../Models/Requests/IncludeIPv6.md)                                                                                                                   | :heavy_minus_sign:                                                                                                                                                    | Include IPv6 entries in the results                                                                                                                                   |                                                                                                                                                                       |
| `serverURL`                                                                                                                                                           | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | An optional server URL to use.                                                                                                                                        | http://localhost:8080                                                                                                                                                 |

### Response

**[GetResourcesResponse](../../Models/Requests/GetResourcesResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| PlexAPI.Models.Errors.GetResourcesResponseBody | 401                                            | application/json                               |
| PlexAPI.Models.Errors.SDKException             | 4xx-5xx                                        | */*                                            |


## GetPin

Retrieve a Pin from Plex.tv for authentication flows

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(xPlexClientIdentifier: "Postman");

var res = await sdk.Plex.GetPinAsync(
    xPlexProduct: "Postman",
    strong: false,
    xPlexClientIdentifier: "Postman"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                             | Type                                                                                                                                                                  | Required                                                                                                                                                              | Description                                                                                                                                                           | Example                                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `XPlexProduct`                                                                                                                                                        | *string*                                                                                                                                                              | :heavy_check_mark:                                                                                                                                                    | Product name of the application shown in the list of devices<br/>                                                                                                     | Postman                                                                                                                                                               |
| `Strong`                                                                                                                                                              | *bool*                                                                                                                                                                | :heavy_minus_sign:                                                                                                                                                    | Determines the kind of code returned by the API call<br/>Strong codes are used for Pin authentication flows<br/>Non-Strong codes are used for `Plex.tv/link`<br/>     |                                                                                                                                                                       |
| `XPlexClientIdentifier`                                                                                                                                               | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | The unique identifier for the client application<br/>This is used to track the client application and its usage<br/>(UUID, serial number, or other number unique per device)<br/> | Postman                                                                                                                                                               |
| `serverURL`                                                                                                                                                           | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | An optional server URL to use.                                                                                                                                        | http://localhost:8080                                                                                                                                                 |

### Response

**[GetPinResponse](../../Models/Requests/GetPinResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| PlexAPI.Models.Errors.GetPinResponseBody | 400                                      | application/json                         |
| PlexAPI.Models.Errors.SDKException       | 4xx-5xx                                  | */*                                      |


## GetTokenByPinId

Retrieve an Access Token from Plex.tv after the Pin has been authenticated

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(xPlexClientIdentifier: "Postman");

var res = await sdk.Plex.GetTokenByPinIdAsync(
    pinID: 408895,
    xPlexClientIdentifier: "Postman"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                             | Type                                                                                                                                                                  | Required                                                                                                                                                              | Description                                                                                                                                                           | Example                                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PinID`                                                                                                                                                               | *long*                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                    | The PinID to retrieve an access token for                                                                                                                             |                                                                                                                                                                       |
| `XPlexClientIdentifier`                                                                                                                                               | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | The unique identifier for the client application<br/>This is used to track the client application and its usage<br/>(UUID, serial number, or other number unique per device)<br/> | Postman                                                                                                                                                               |
| `serverURL`                                                                                                                                                           | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | An optional server URL to use.                                                                                                                                        | http://localhost:8080                                                                                                                                                 |

### Response

**[GetTokenByPinIdResponse](../../Models/Requests/GetTokenByPinIdResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| PlexAPI.Models.Errors.GetTokenByPinIdResponseBody | 404                                               | application/json                                  |
| PlexAPI.Models.Errors.SDKException                | 4xx-5xx                                           | */*                                               |


## GetUserDetails

Get the User data from the provided X-Plex-Token

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Plex.GetUserDetailsAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[GetUserDetailsResponse](../../Models/Requests/GetUserDetailsResponse.md)**

### Errors

| Error Object                                     | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| PlexAPI.Models.Errors.GetUserDetailsResponseBody | 401                                              | application/json                                 |
| PlexAPI.Models.Errors.SDKException               | 4xx-5xx                                          | */*                                              |
