# User
(*User*)

## Overview

API Calls that perform operations with Plex Media Server Users


### Available Operations

* [PostUsersSigninData](#postuserssignindata) - Get User SignIn Data

## PostUsersSigninData

Sign in user with username and password and return user data with Plex authentication token

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(xPlexClientIdentifier: "Postman");

var res = await sdk.User.PostUsersSigninDataAsync(
    xPlexClientIdentifier: "Postman",
    requestBody: new PostUsersSigninDataRequestBody() {
    Login = "username@email.com",
    Password = "password123",
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                             | Type                                                                                                                                                                  | Required                                                                                                                                                              | Description                                                                                                                                                           | Example                                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `XPlexClientIdentifier`                                                                                                                                               | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | The unique identifier for the client application<br/>This is used to track the client application and its usage<br/>(UUID, serial number, or other number unique per device)<br/> | Postman                                                                                                                                                               |
| `RequestBody`                                                                                                                                                         | [PostUsersSigninDataRequestBody](../../Models/Requests/PostUsersSigninDataRequestBody.md)                                                                             | :heavy_minus_sign:                                                                                                                                                    | Login credentials                                                                                                                                                     |                                                                                                                                                                       |
| `serverURL`                                                                                                                                                           | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | An optional server URL to use.                                                                                                                                        | http://localhost:8080                                                                                                                                                 |

### Response

**[PostUsersSigninDataResponse](../../Models/Requests/PostUsersSigninDataResponse.md)**

### Errors

| Error Object                                          | Status Code                                           | Content Type                                          |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| PlexAPI.Models.Errors.PostUsersSigninDataResponseBody | 401                                                   | application/json                                      |
| PlexAPI.Models.Errors.SDKException                    | 4xx-5xx                                               | */*                                                   |
