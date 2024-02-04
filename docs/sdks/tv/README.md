# Tv
(*Plex.Tv*)

### Available Operations

* [GetPin](#getpin) - Get a Pin
* [GetToken](#gettoken) - Get Access Token

## GetPin

Retrieve a Pin from Plex.tv for authentication flows

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Plex.Tv.GetPinAsync(
    xPlexClientIdentifier: "string",
    strong: false);

// handle response
```

### Parameters

| Parameter                                                                                                                                             | Type                                                                                                                                                  | Required                                                                                                                                              | Description                                                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| `XPlexClientIdentifier`                                                                                                                               | *string*                                                                                                                                              | :heavy_check_mark:                                                                                                                                    | Plex Authentication Token                                                                                                                             |
| `Strong`                                                                                                                                              | *bool*                                                                                                                                                | :heavy_minus_sign:                                                                                                                                    | Determines the kind of code returned by the API call<br/>Strong codes are used for Pin authentication flows<br/>Non-Strong codes are used for `Plex.tv/link`<br/> |
| `serverURL`                                                                                                                                           | *string*                                                                                                                                              | :heavy_minus_sign:                                                                                                                                    | An optional server URL to use.                                                                                                                        |


### Response

**[GetPinResponse](../../Models/Requests/GetPinResponse.md)**


## GetToken

Retrieve an Access Token from Plex.tv after the Pin has already been authenticated

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Plex.Tv.GetTokenAsync(
    pinID: "string",
    xPlexClientIdentifier: "string");

// handle response
```

### Parameters

| Parameter                                 | Type                                      | Required                                  | Description                               |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| `PinID`                                   | *string*                                  | :heavy_check_mark:                        | The PinID to retrieve an access token for |
| `XPlexClientIdentifier`                   | *string*                                  | :heavy_check_mark:                        | Plex Authentication Token                 |
| `serverURL`                               | *string*                                  | :heavy_minus_sign:                        | An optional server URL to use.            |


### Response

**[GetTokenResponse](../../Models/Requests/GetTokenResponse.md)**

