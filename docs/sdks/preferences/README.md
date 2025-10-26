# Preferences
(*Preferences*)

## Overview

API Operations against the Preferences

### Available Operations

* [GetAllPreferences](#getallpreferences) - Get all preferences
* [SetPreferences](#setpreferences) - Set preferences
* [GetPreference](#getpreference) - Get a preferences

## GetAllPreferences

Get the list of all preferences

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAllPreferences" method="get" path="/:/prefs" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Preferences.GetAllPreferencesAsync();

// handle response
```

### Response

**[GetAllPreferencesResponse](../../Models/Requests/GetAllPreferencesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## SetPreferences

Set a set of preferences in query parameters

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setPreferences" method="put" path="/:/prefs" -->
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

SetPreferencesRequest req = new SetPreferencesRequest() {
    Prefs = new Prefs() {},
};

var res = await sdk.Preferences.SetPreferencesAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [SetPreferencesRequest](../../Models/Requests/SetPreferencesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[SetPreferencesResponse](../../Models/Requests/SetPreferencesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetPreference

Get a single preference and value

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPreference" method="get" path="/:/prefs/get" -->
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

GetPreferenceRequest req = new GetPreferenceRequest() {};

var res = await sdk.Preferences.GetPreferenceAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetPreferenceRequest](../../Models/Requests/GetPreferenceRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GetPreferenceResponse](../../Models/Requests/GetPreferenceResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |