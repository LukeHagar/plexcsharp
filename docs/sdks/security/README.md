# Security
(*Security*)

## Overview

API Calls against Security for Plex Media Server


### Available Operations

* [GetTransientToken](#gettransienttoken) - Get a Transient Token.
* [GetSourceConnectionInformation](#getsourceconnectioninformation) - Get Source Connection Information

## GetTransientToken

This endpoint provides the caller with a temporary token with the same access level as the caller's token. These tokens are valid for up to 48 hours and are destroyed if the server instance is restarted.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Security.GetTransientTokenAsync(Type: GetTransientTokenQueryParamType.Delegation, Scope: Scope.All);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Type`                                                                                      | [GetTransientTokenQueryParamType](../../Models/Requests/GetTransientTokenQueryParamType.md) | :heavy_check_mark:                                                                          | `delegation` - This is the only supported `type` parameter.                                 |
| `Scope`                                                                                     | [Scope](../../Models/Requests/Scope.md)                                                     | :heavy_check_mark:                                                                          | `all` - This is the only supported `scope` parameter.                                       |


### Response

**[GetTransientTokenResponse](../../Models/Requests/GetTransientTokenResponse.md)**


## GetSourceConnectionInformation

If a caller requires connection details and a transient token for a source that is known to the server, for example a cloud media provider or shared PMS, then this endpoint can be called. This endpoint is only accessible with either an admin token or a valid transient token generated from an admin token.
Note: requires Plex Media Server >= 1.15.4.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(
    security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Security.GetSourceConnectionInformationAsync(Source: "server://client-identifier");

// handle response
```

### Parameters

| Parameter                                      | Type                                           | Required                                       | Description                                    | Example                                        |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| `Source`                                       | *string*                                       | :heavy_check_mark:                             | The source identifier with an included prefix. | server://client-identifier                     |


### Response

**[GetSourceConnectionInformationResponse](../../Models/Requests/GetSourceConnectionInformationResponse.md)**

