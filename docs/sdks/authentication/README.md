# Authentication
(*Authentication*)

## Overview

API Calls regarding authentication for Plex Media Server


### Available Operations

* [GetTransientToken](#gettransienttoken) - Get a Transient Token
* [GetSourceConnectionInformation](#getsourceconnectioninformation) - Get Source Connection Information
* [GetTokenDetails](#gettokendetails) - Get Token Details
* [PostUsersSignInData](#postuserssignindata) - Get User Sign In Data

## GetTransientToken

This endpoint provides the caller with a temporary token with the same access level as the caller's token. These tokens are valid for up to 48 hours and are destroyed if the server instance is restarted.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Authentication.GetTransientTokenAsync(
    type: GetTransientTokenQueryParamType.Delegation,
    scope: Scope.All
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

| Error Type                                                        | Status Code                                                       | Content Type                                                      |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetTransientTokenBadRequest   | 400                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetTransientTokenUnauthorized | 401                                                               | application/json                                                  |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                  | 4XX, 5XX                                                          | \*/\*                                                             |

## GetSourceConnectionInformation

If a caller requires connection details and a transient token for a source that is known to the server, for example a cloud media provider or shared PMS, then this endpoint can be called. This endpoint is only accessible with either an admin token or a valid transient token generated from an admin token.
Note: requires Plex Media Server >= 1.15.4.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

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

| Error Type                                                                     | Status Code                                                                    | Content Type                                                                   |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetSourceConnectionInformationBadRequest   | 400                                                                            | application/json                                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetSourceConnectionInformationUnauthorized | 401                                                                            | application/json                                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                               | 4XX, 5XX                                                                       | \*/\*                                                                          |

## GetTokenDetails

Get the User data from the provided X-Plex-Token

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Authentication.GetTokenDetailsAsync();

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `serverURL`                    | *string*                       | :heavy_minus_sign:             | An optional server URL to use. |

### Response

**[GetTokenDetailsResponse](../../Models/Requests/GetTokenDetailsResponse.md)**

### Errors

| Error Type                                                      | Status Code                                                     | Content Type                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetTokenDetailsBadRequest   | 400                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetTokenDetailsUnauthorized | 401                                                             | application/json                                                |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                | 4XX, 5XX                                                        | \*/\*                                                           |

## PostUsersSignInData

Sign in user with username and password and return user data with Plex authentication token

### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI();

PostUsersSignInDataRequest req = new PostUsersSignInDataRequest() {
    ClientID = "3381b62b-9ab7-4e37-827b-203e9809eb58",
    ClientName = "Plex for Roku",
    DeviceNickname = "Roku 3",
    ClientVersion = "2.4.1",
    Platform = "Roku",
    RequestBody = new PostUsersSignInDataRequestBody() {
        Login = "username@email.com",
        Password = "password123",
        VerificationCode = "123456",
    },
};

var res = await sdk.Authentication.PostUsersSignInDataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [PostUsersSignInDataRequest](../../Models/Requests/PostUsersSignInDataRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |
| `serverURL`                                                                       | *string*                                                                          | :heavy_minus_sign:                                                                | An optional server URL to use.                                                    |

### Response

**[PostUsersSignInDataResponse](../../Models/Requests/PostUsersSignInDataResponse.md)**

### Errors

| Error Type                                                          | Status Code                                                         | Content Type                                                        |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.PostUsersSignInDataBadRequest   | 400                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.PostUsersSignInDataUnauthorized | 401                                                                 | application/json                                                    |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                    | 4XX, 5XX                                                            | \*/\*                                                               |