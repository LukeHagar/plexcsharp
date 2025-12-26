# Authentication

## Overview

### Available Operations

* [GetTokenDetails](#gettokendetails) - Get Token Details
* [PostUsersSignInData](#postuserssignindata) - Get User Sign In Data

## GetTokenDetails

Get the User data from the provided X-Plex-Token

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTokenDetails" method="get" path="/user" -->
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

GetTokenDetailsRequest req = new GetTokenDetailsRequest() {};

var res = await sdk.Authentication.GetTokenDetailsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetTokenDetailsRequest](../../Models/Requests/GetTokenDetailsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |
| `serverURL`                                                               | *string*                                                                  | :heavy_minus_sign:                                                        | An optional server URL to use.                                            |

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

<!-- UsageSnippet language="csharp" operationID="post-users-sign-in-data" method="post" path="/users/signin" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    accepts: LukeHagar.PlexAPI.SDK.Models.Components.Accepts.ApplicationXml,
    clientIdentifier: "3381b62b-9ab7-4e37-827b-203e9809eb58",
    product: "Plex for Roku",
    version: "2.4.1",
    platform: "Roku",
    platformVersion: "4.3 build 1057",
    device: "Roku 3",
    model: "4200X",
    deviceVendor: "Roku",
    deviceName: "Living Room TV",
    marketplace: "googlePlay"
);

PostUsersSignInDataRequest req = new PostUsersSignInDataRequest() {
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