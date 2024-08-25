# User
(*User*)

## Overview

API Calls that perform operations with Plex Media Server Users


### Available Operations

* [PostSignIn](#postsignin) - Get User SignIn Data

## PostSignIn

Sign in user with username and password and return user data with Plex authentication token

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(xPlexClientIdentifier: "Postman");

var res = await sdk.User.PostSignInAsync(
    xPlexClientIdentifier: "Postman",
    requestBody: new PostSignInRequestBody() {
    Login = "username@email.com",
    Password = "password123",
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                             | Type                                                                                                                                                                  | Required                                                                                                                                                              | Description                                                                                                                                                           | Example                                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `XPlexClientIdentifier`                                                                                                                                               | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | The unique identifier for the client application<br/>This is used to track the client application and its usage<br/>(UUID, serial number, or other number unique per device)<br/> | Postman                                                                                                                                                               |
| `RequestBody`                                                                                                                                                         | [PostSignInRequestBody](../../Models/Requests/PostSignInRequestBody.md)                                                                                               | :heavy_minus_sign:                                                                                                                                                    | Login credentials                                                                                                                                                     |                                                                                                                                                                       |
| `serverURL`                                                                                                                                                           | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | An optional server URL to use.                                                                                                                                        | http://localhost:8080                                                                                                                                                 |

### Response

**[PostSignInResponse](../../Models/Requests/PostSignInResponse.md)**

### Errors

| Error Object                                 | Status Code                                  | Content Type                                 |
| -------------------------------------------- | -------------------------------------------- | -------------------------------------------- |
| PlexAPI.Models.Errors.PostSignInResponseBody | 401                                          | application/json                             |
| PlexAPI.Models.Errors.SDKException           | 4xx-5xx                                      | */*                                          |
