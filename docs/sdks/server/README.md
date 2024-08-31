# Server
(*Server*)

## Overview

Operations against the Plex Media Server System.


### Available Operations

* [GetServerCapabilities](#getservercapabilities) - Get Server Capabilities
* [GetServerPreferences](#getserverpreferences) - Get Server Preferences
* [GetAvailableClients](#getavailableclients) - Get Available Clients
* [GetDevices](#getdevices) - Get Devices
* [GetServerIdentity](#getserveridentity) - Get Server Identity
* [GetMyPlexAccount](#getmyplexaccount) - Get MyPlex Account
* [GetResizedPhoto](#getresizedphoto) - Get a Resized Photo
* [GetServerList](#getserverlist) - Get Server List

## GetServerCapabilities

Get Server Capabilities

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```

### Response

**[GetServerCapabilitiesResponse](../../Models/Requests/GetServerCapabilitiesResponse.md)**

### Errors

| Error Object                                            | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| PlexAPI.Models.Errors.GetServerCapabilitiesResponseBody | 401                                                     | application/json                                        |
| PlexAPI.Models.Errors.SDKException                      | 4xx-5xx                                                 | */*                                                     |


## GetServerPreferences

Get Server Preferences

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Server.GetServerPreferencesAsync();

// handle response
```

### Response

**[GetServerPreferencesResponse](../../Models/Requests/GetServerPreferencesResponse.md)**

### Errors

| Error Object                                           | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| PlexAPI.Models.Errors.GetServerPreferencesResponseBody | 401                                                    | application/json                                       |
| PlexAPI.Models.Errors.SDKException                     | 4xx-5xx                                                | */*                                                    |


## GetAvailableClients

Get Available Clients

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Server.GetAvailableClientsAsync();

// handle response
```

### Response

**[GetAvailableClientsResponse](../../Models/Requests/GetAvailableClientsResponse.md)**

### Errors

| Error Object                                          | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| PlexAPI.Models.Errors.GetAvailableClientsResponseBody | 401                                                   | application/json                                      |
| PlexAPI.Models.Errors.SDKException                    | 4xx-5xx                                               | */*                                                   |


## GetDevices

Get Devices

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Server.GetDevicesAsync();

// handle response
```

### Response

**[GetDevicesResponse](../../Models/Requests/GetDevicesResponse.md)**

### Errors

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| PlexAPI.Models.Errors.GetDevicesResponseBody | 401                                          | application/json                             |
| PlexAPI.Models.Errors.SDKException           | 4xx-5xx                                      | */*                                          |


## GetServerIdentity

Get Server Identity

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Server.GetServerIdentityAsync();

// handle response
```

### Response

**[GetServerIdentityResponse](../../Models/Requests/GetServerIdentityResponse.md)**

### Errors

| Error Object                                        | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| PlexAPI.Models.Errors.GetServerIdentityResponseBody | 401                                                 | application/json                                    |
| PlexAPI.Models.Errors.SDKException                  | 4xx-5xx                                             | */*                                                 |


## GetMyPlexAccount

Returns MyPlex Account Information

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Server.GetMyPlexAccountAsync();

// handle response
```

### Response

**[GetMyPlexAccountResponse](../../Models/Requests/GetMyPlexAccountResponse.md)**

### Errors

| Error Object                                       | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| PlexAPI.Models.Errors.GetMyPlexAccountResponseBody | 401                                                | application/json                                   |
| PlexAPI.Models.Errors.SDKException                 | 4xx-5xx                                            | */*                                                |


## GetResizedPhoto

Plex's Photo transcoder is used throughout the service to serve images at specified sizes.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

GetResizedPhotoRequest req = new GetResizedPhotoRequest() {
    Width = 110D,
    Height = 165D,
    Opacity = 100,
    Blur = 20D,
    MinSize = PlexAPI.Models.Requests.MinSize.One,
    Upscale = PlexAPI.Models.Requests.Upscale.Zero,
    Url = "/library/metadata/49564/thumb/1654258204",
};

var res = await sdk.Server.GetResizedPhotoAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetResizedPhotoRequest](../../Models/Requests/GetResizedPhotoRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetResizedPhotoResponse](../../Models/Requests/GetResizedPhotoResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| PlexAPI.Models.Errors.GetResizedPhotoResponseBody | 401                                               | application/json                                  |
| PlexAPI.Models.Errors.SDKException                | 4xx-5xx                                           | */*                                               |


## GetServerList

Get Server List

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Server.GetServerListAsync();

// handle response
```

### Response

**[GetServerListResponse](../../Models/Requests/GetServerListResponse.md)**

### Errors

| Error Object                                    | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| PlexAPI.Models.Errors.GetServerListResponseBody | 401                                             | application/json                                |
| PlexAPI.Models.Errors.SDKException              | 4xx-5xx                                         | */*                                             |
