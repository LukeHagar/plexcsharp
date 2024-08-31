# Authentication
(*Authentication*)

## Overview

API Calls regarding authentication for Plex Media Server


### Available Operations

* [GetTransientToken](#gettransienttoken) - Get a Transient Token.
* [GetSourceConnectionInformation](#getsourceconnectioninformation) - Get Source Connection Information
* [PostUsersSignInData](#postuserssignindata) - Get User SignIn Data

## GetTransientToken

This endpoint provides the caller with a temporary token with the same access level as the caller's token. These tokens are valid for up to 48 hours and are destroyed if the server instance is restarted.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Authentication.GetTransientTokenAsync(
    type: PlexAPI.Models.Requests.GetTransientTokenQueryParamType.Delegation,
    scope: PlexAPI.Models.Requests.Scope.All
);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Type`                                                                                      | [GetTransientTokenQueryParamType](../../Models/Requests/GetTransientTokenQueryParamType.md) | :heavy_check_mark:                                                                          | `delegation` - This is the only supported `type` parameter.                                 |
| `Scope`                                                                                     | [Scope](../../Models/Requests/Scope.md)                                                     | :heavy_check_mark:                                                                          | `all` - This is the only supported `scope` parameter.                                       |

### Response

**[GetTransientTokenResponse](../../Models/Requests/GetTransientTokenResponse.md)**

### Errors

| Error Object                                        | Status Code                                         | Content Type                                        |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| PlexAPI.Models.Errors.GetTransientTokenResponseBody | 401                                                 | application/json                                    |
| PlexAPI.Models.Errors.SDKException                  | 4xx-5xx                                             | */*                                                 |


## GetSourceConnectionInformation

If a caller requires connection details and a transient token for a source that is known to the server, for example a cloud media provider or shared PMS, then this endpoint can be called. This endpoint is only accessible with either an admin token or a valid transient token generated from an admin token.
Note: requires Plex Media Server >= 1.15.4.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Authentication.GetSourceConnectionInformationAsync(source: "server://client-identifier");

// handle response
```

### Parameters

| Parameter                                      | Type                                           | Required                                       | Description                                    | Example                                        |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| `Source`                                       | *string*                                       | :heavy_check_mark:                             | The source identifier with an included prefix. | server://client-identifier                     |

### Response

**[GetSourceConnectionInformationResponse](../../Models/Requests/GetSourceConnectionInformationResponse.md)**

### Errors

| Error Object                                                     | Status Code                                                      | Content Type                                                     |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| PlexAPI.Models.Errors.GetSourceConnectionInformationResponseBody | 401                                                              | application/json                                                 |
| PlexAPI.Models.Errors.SDKException                               | 4xx-5xx                                                          | */*                                                              |


## PostUsersSignInData

Sign in user with username and password and return user data with Plex authentication token

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(xPlexClientIdentifier: "Postman");

var res = await sdk.Authentication.PostUsersSignInDataAsync(
    xPlexClientIdentifier: "Postman",
    requestBody: new PostUsersSignInDataRequestBody() {
        Login = "username@email.com",
        Password = "password123",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                             | Type                                                                                                                                                                  | Required                                                                                                                                                              | Description                                                                                                                                                           | Example                                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `XPlexClientIdentifier`                                                                                                                                               | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | The unique identifier for the client application<br/>This is used to track the client application and its usage<br/>(UUID, serial number, or other number unique per device)<br/> | Postman                                                                                                                                                               |
| `RequestBody`                                                                                                                                                         | [PostUsersSignInDataRequestBody](../../Models/Requests/PostUsersSignInDataRequestBody.md)                                                                             | :heavy_minus_sign:                                                                                                                                                    | Login credentials                                                                                                                                                     |                                                                                                                                                                       |
| `serverURL`                                                                                                                                                           | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | An optional server URL to use.                                                                                                                                        | http://localhost:8080                                                                                                                                                 |

### Response

**[PostUsersSignInDataResponse](../../Models/Requests/PostUsersSignInDataResponse.md)**

### Errors

| Error Object                                          | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| PlexAPI.Models.Errors.PostUsersSignInDataResponseBody | 401                                                   | application/json                                      |
| PlexAPI.Models.Errors.SDKException                    | 4xx-5xx                                               | */*                                                   |
