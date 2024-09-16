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
* [GetMediaProviders](#getmediaproviders) - Get Media Providers
* [GetServerList](#getserverlist) - Get Server List

## GetServerCapabilities

Get Server Capabilities

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```

### Response

**[GetServerCapabilitiesResponse](../../Models/Requests/GetServerCapabilitiesResponse.md)**

### Errors

| Error Object                                                          | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerCapabilitiesBadRequest   | 400                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerCapabilitiesUnauthorized | 401                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                      | 4xx-5xx                                                               | */*                                                                   |


## GetServerPreferences

Get Server Preferences

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Server.GetServerPreferencesAsync();

// handle response
```

### Response

**[GetServerPreferencesResponse](../../Models/Requests/GetServerPreferencesResponse.md)**

### Errors

| Error Object                                                         | Status Code                                                          | Content Type                                                         |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerPreferencesBadRequest   | 400                                                                  | application/json                                                     |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerPreferencesUnauthorized | 401                                                                  | application/json                                                     |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                     | 4xx-5xx                                                              | */*                                                                  |


## GetAvailableClients

Get Available Clients

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Server.GetAvailableClientsAsync();

// handle response
```

### Response

**[GetAvailableClientsResponse](../../Models/Requests/GetAvailableClientsResponse.md)**

### Errors

| Error Object                                                        | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetAvailableClientsBadRequest   | 400                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetAvailableClientsUnauthorized | 401                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                    | 4xx-5xx                                                             | */*                                                                 |


## GetDevices

Get Devices

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Server.GetDevicesAsync();

// handle response
```

### Response

**[GetDevicesResponse](../../Models/Requests/GetDevicesResponse.md)**

### Errors

| Error Object                                               | Status Code                                                | Content Type                                               |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetDevicesBadRequest   | 400                                                        | application/json                                           |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetDevicesUnauthorized | 401                                                        | application/json                                           |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException           | 4xx-5xx                                                    | */*                                                        |


## GetServerIdentity

This request is useful to determine if the server is online or offline

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40");

var res = await sdk.Server.GetServerIdentityAsync();

// handle response
```

### Response

**[GetServerIdentityResponse](../../Models/Requests/GetServerIdentityResponse.md)**

### Errors

| Error Object                                                        | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerIdentityRequestTimeout | 408                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                    | 4xx-5xx                                                             | */*                                                                 |


## GetMyPlexAccount

Returns MyPlex Account Information

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Server.GetMyPlexAccountAsync();

// handle response
```

### Response

**[GetMyPlexAccountResponse](../../Models/Requests/GetMyPlexAccountResponse.md)**

### Errors

| Error Object                                                     | Status Code                                                      | Content Type                                                     |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetMyPlexAccountBadRequest   | 400                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetMyPlexAccountUnauthorized | 401                                                              | application/json                                                 |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                 | 4xx-5xx                                                          | */*                                                              |


## GetResizedPhoto

Plex's Photo transcoder is used throughout the service to serve images at specified sizes.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

GetResizedPhotoRequest req = new GetResizedPhotoRequest() {
    Width = 110D,
    Height = 165D,
    Opacity = 100,
    Blur = 4000D,
    MinSize = LukeHagar.PlexAPI.SDK.Models.Requests.MinSize.Zero,
    Upscale = LukeHagar.PlexAPI.SDK.Models.Requests.Upscale.Zero,
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

| Error Object                                                    | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetResizedPhotoBadRequest   | 400                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetResizedPhotoUnauthorized | 401                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                | 4xx-5xx                                                         | */*                                                             |


## GetMediaProviders

Retrieves media providers and their features from the Plex server.

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Server.GetMediaProvidersAsync(xPlexToken: "CV5xoxjTpFKUzBTShsaf");

// handle response
```

### Parameters

| Parameter                 | Type                      | Required                  | Description               | Example                   |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `XPlexToken`              | *string*                  | :heavy_check_mark:        | Plex Authentication Token | CV5xoxjTpFKUzBTShsaf      |

### Response

**[GetMediaProvidersResponse](../../Models/Requests/GetMediaProvidersResponse.md)**

### Errors

| Error Object                                                      | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetMediaProvidersBadRequest   | 400                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetMediaProvidersUnauthorized | 401                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                  | 4xx-5xx                                                           | */*                                                               |


## GetServerList

Get Server List

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Server.GetServerListAsync();

// handle response
```

### Response

**[GetServerListResponse](../../Models/Requests/GetServerListResponse.md)**

### Errors

| Error Object                                                  | Status Code                                                   | Content Type                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerListBadRequest   | 400                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerListUnauthorized | 401                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException              | 4xx-5xx                                                       | */*                                                           |
