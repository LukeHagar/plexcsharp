# LukeHagar.PlexAPI.SDK


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    clientID: "3381b62b-9ab7-4e37-827b-203e9809eb58",
    clientName: "Plex for Roku",
    clientVersion: "2.4.1",
    platform: "Roku",
    deviceNickname: "Roku 3"
);

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `LukeHagar.PlexAPI.SDK.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `StatusCode`  | *int*                 | The HTTP status code  |
| `RawResponse` | *HttpResponseMessage* | The raw HTTP response |
| `Body`        | *string*              | The response content  |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `GetServerCapabilitiesAsync` method throws the following exceptions:

| Error Type                                                            | Status Code                                                           | Content Type                                                          |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerCapabilitiesBadRequest   | 400                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerCapabilitiesUnauthorized | 401                                                                   | application/json                                                      |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                      | 4XX, 5XX                                                              | \*/\*                                                                 |

### Example

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using System;
using LukeHagar.PlexAPI.SDK.Models.Errors;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    clientID: "3381b62b-9ab7-4e37-827b-203e9809eb58",
    clientName: "Plex for Roku",
    clientVersion: "2.4.1",
    platform: "Roku",
    deviceNickname: "Roku 3"
);

try
{
    var res = await sdk.Server.GetServerCapabilitiesAsync();

    // handle response
}
catch (Exception ex)
{
    if (ex is GetServerCapabilitiesBadRequest)
    {
        // Handle exception data
        throw;
    }
    else if (ex is GetServerCapabilitiesUnauthorized)
    {
        // Handle exception data
        throw;
    }
    else if (ex is LukeHagar.PlexAPI.SDK.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `{protocol}://{ip}:{port}` | `protocol` (default is `https`), `ip` (default is `10.10.10.47`), `port` (default is `32400`) |



#### Variables

Some of the server options above contain variables. If you want to set the values of those variables, the following options are provided for doing so:
 * `protocol: ServerProtocol`
 * `ip: string`
 * `port: string`

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:


### Override Server URL Per-Operation

The server URL can also be overridden on a per-operation basis, provided a server list was specified for the operation. For example:
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    clientID: "3381b62b-9ab7-4e37-827b-203e9809eb58",
    clientName: "Plex for Roku",
    clientVersion: "2.4.1",
    platform: "Roku",
    deviceNickname: "Roku 3"
);

var res = await sdk.Plex.GetCompanionsDataAsync(serverUrl: "https://plex.tv/api/v2");

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name          | Type          | Scheme        |
| ------------- | ------------- | ------------- |
| `AccessToken` | apiKey        | API key       |

To authenticate with the API the `AccessToken` parameter must be set when initializing the SDK client instance. For example:
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    clientID: "3381b62b-9ab7-4e37-827b-203e9809eb58",
    clientName: "Plex for Roku",
    clientVersion: "2.4.1",
    platform: "Roku",
    deviceNickname: "Roku 3"
);

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->