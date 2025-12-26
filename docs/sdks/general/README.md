# General

## Overview

General endpoints for basic PMS operation not specific to any media provider

### Available Operations

* [GetServerInfo](#getserverinfo) - Get PMS info
* [GetIdentity](#getidentity) - Get PMS identity
* [GetSourceConnectionInformation](#getsourceconnectioninformation) - Get Source Connection Information
* [GetTransientToken](#gettransienttoken) - Get Transient Tokens

## GetServerInfo

Information about this PMS setup and configuration

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getServerInfo" method="get" path="/" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

GetServerInfoRequest req = new GetServerInfoRequest() {};

var res = await sdk.General.GetServerInfoAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetServerInfoRequest](../../Models/Requests/GetServerInfoRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GetServerInfoResponse](../../Models/Requests/GetServerInfoResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetIdentity

Get details about this PMS's identity

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getIdentity" method="get" path="/identity" -->
```csharp
using LukeHagar.PlexAPI.SDK;

var sdk = new PlexAPI();

var res = await sdk.General.GetIdentityAsync();

// handle response
```

### Response

**[GetIdentityResponse](../../Models/Requests/GetIdentityResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetSourceConnectionInformation

If a caller requires connection details and a transient token for a source that is known to the server, for example a cloud media provider or shared PMS, then this endpoint can be called. This endpoint is only accessible with either an admin token or a valid transient token generated from an admin token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSourceConnectionInformation" method="get" path="/security/resources" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

GetSourceConnectionInformationRequest req = new GetSourceConnectionInformationRequest() {
    Source = "server://client-identifier",
    Refresh = BoolInt.True,
};

var res = await sdk.General.GetSourceConnectionInformationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetSourceConnectionInformationRequest](../../Models/Requests/GetSourceConnectionInformationRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetSourceConnectionInformationResponse](../../Models/Requests/GetSourceConnectionInformationResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetTransientToken

This endpoint provides the caller with a temporary token with the same access level as the caller's token. These tokens are valid for up to 48 hours and are destroyed if the server instance is restarted.
Note: This endpoint responds to all HTTP verbs but POST in preferred

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTransientToken" method="post" path="/security/token" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "abc123",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay",
    token: "<YOUR_API_KEY_HERE>"
);

GetTransientTokenRequest req = new GetTransientTokenRequest() {
    Type = QueryParamType.Delegation,
    Scope = Scope.All,
};

var res = await sdk.General.GetTransientTokenAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetTransientTokenRequest](../../Models/Requests/GetTransientTokenRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetTransientTokenResponse](../../Models/Requests/GetTransientTokenResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |