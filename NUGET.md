# LukeHagar.PlexAPI.SDK


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name          | Type   | Scheme  |
| ------------- | ------ | ------- |
| `AccessToken` | apiKey | API key |

To authenticate with the API the `AccessToken` parameter must be set when initializing the SDK client instance. For example:
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End Authentication [security] -->

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

| Error Type                                                            | Status Code | Content Type     |
| --------------------------------------------------------------------- | ----------- | ---------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerCapabilitiesBadRequest   | 400         | application/json |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetServerCapabilitiesUnauthorized | 401         | application/json |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException                      | 4XX, 5XX    | \*/\*            |

### Example

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Errors;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

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

### Server Variables

The default server `{protocol}://{ip}:{port}` contains variables and is set to `https://10.10.10.47:32400` by default. To override default values, the following parameters are available when initializing the SDK client instance:

| Variable   | Parameter                                               | Supported Values           | Default         | Description                                    |
| ---------- | ------------------------------------------------------- | -------------------------- | --------------- | ---------------------------------------------- |
| `protocol` | `protocol: LukeHagar.PlexAPI.SDK.Models.ServerProtocol` | - `"http"`<br/>- `"https"` | `"https"`       | The protocol to use for the server connection  |
| `ip`       | `ip: string`                                            | string                     | `"10.10.10.47"` | The IP address or hostname of your Plex Server |
| `port`     | `port: string`                                          | string                     | `"32400"`       | The port of your Plex Server                   |

#### Example

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    protocol: "https",
    ip: "e0c3:bcc0:6bac:dccc:c4ec:34b1:ca98:4cb9",
    port: "40311",
    accessToken: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    serverUrl: "https://10.10.10.47:32400",
    accessToken: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```

### Override Server URL Per-Operation

The server URL can also be overridden on a per-operation basis, provided a server list was specified for the operation. For example:
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Plex.GetCompanionsDataAsync(serverUrl: "https://plex.tv/api/v2");

// handle response
```
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->