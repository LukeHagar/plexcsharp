# Server
(*Server*)

## Overview

Operations against the Plex Media Server System.


### Available Operations

* [GetServerCapabilities](#getservercapabilities) - Server Capabilities
* [GetServerPreferences](#getserverpreferences) - Get Server Preferences
* [GetAvailableClients](#getavailableclients) - Get Available Clients
* [GetDevices](#getdevices) - Get Devices
* [GetServerIdentity](#getserveridentity) - Get Server Identity
* [GetMyPlexAccount](#getmyplexaccount) - Get MyPlex Account
* [GetResizedPhoto](#getresizedphoto) - Get a Resized Photo
* [GetServerList](#getserverlist) - Get Server List

## GetServerCapabilities

Server Capabilities

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```


### Response

**[GetServerCapabilitiesResponse](../../Models/Requests/GetServerCapabilitiesResponse.md)**


## GetServerPreferences

Get Server Preferences

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetServerPreferencesAsync();

// handle response
```


### Response

**[GetServerPreferencesResponse](../../Models/Requests/GetServerPreferencesResponse.md)**


## GetAvailableClients

Get Available Clients

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetAvailableClientsAsync();

// handle response
```


### Response

**[GetAvailableClientsResponse](../../Models/Requests/GetAvailableClientsResponse.md)**


## GetDevices

Get Devices

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetDevicesAsync();

// handle response
```


### Response

**[GetDevicesResponse](../../Models/Requests/GetDevicesResponse.md)**


## GetServerIdentity

Get Server Identity

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetServerIdentityAsync();

// handle response
```


### Response

**[GetServerIdentityResponse](../../Models/Requests/GetServerIdentityResponse.md)**


## GetMyPlexAccount

Returns MyPlex Account Information

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetMyPlexAccountAsync();

// handle response
```


### Response

**[GetMyPlexAccountResponse](../../Models/Requests/GetMyPlexAccountResponse.md)**


## GetResizedPhoto

Plex's Photo transcoder is used throughout the service to serve images at specified sizes.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

GetResizedPhotoRequest req = new GetResizedPhotoRequest() {
    Width = 110D,
    Height = 165D,
    Opacity = 643869,
    Blur = 4000D,
    MinSize = MinSize.Zero,
    Upscale = Upscale.Zero,
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


## GetServerList

Get Server List

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetServerListAsync();

// handle response
```


### Response

**[GetServerListResponse](../../Models/Requests/GetServerListResponse.md)**

