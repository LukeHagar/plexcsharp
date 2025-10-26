# Epg
(*Epg*)

## Overview

The EPG (Electronic Program Guide) is responsible for obtaining metadata for what is airing on each channel and when


### Available Operations

* [ComputeChannelMap](#computechannelmap) - Compute the best channel map
* [GetChannels](#getchannels) - Get channels for a lineup
* [GetCountries](#getcountries) - Get all countries
* [GetAllLanguages](#getalllanguages) - Get all languages
* [GetLineup](#getlineup) - Compute the best lineup
* [GetLineupChannels](#getlineupchannels) - Get the channels for mulitple lineups
* [GetCountriesLineups](#getcountrieslineups) - Get lineups for a country via postal code
* [GetCountryRegions](#getcountryregions) - Get regions for a country
* [ListLineups](#listlineups) - Get lineups for a region

## ComputeChannelMap

Compute the best channel map, given device and lineup

### Example Usage

<!-- UsageSnippet language="csharp" operationID="computeChannelMap" method="get" path="/livetv/epg/channelmap" -->
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

ComputeChannelMapRequest req = new ComputeChannelMapRequest() {
    DeviceQueryParameter = "<value>",
    Lineup = "<value>",
};

var res = await sdk.Epg.ComputeChannelMapAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ComputeChannelMapRequest](../../Models/Requests/ComputeChannelMapRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ComputeChannelMapResponse](../../Models/Requests/ComputeChannelMapResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetChannels

Get channels for a lineup within an EPG provider

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getChannels" method="get" path="/livetv/epg/channels" -->
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

GetChannelsRequest req = new GetChannelsRequest() {
    Lineup = "<value>",
};

var res = await sdk.Epg.GetChannelsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetChannelsRequest](../../Models/Requests/GetChannelsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetChannelsResponse](../../Models/Requests/GetChannelsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetCountries

This endpoint returns a list of countries which EPG data is available for. There are three flavors, as specfied by the `flavor` attribute

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCountries" method="get" path="/livetv/epg/countries" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Epg.GetCountriesAsync();

// handle response
```

### Response

**[GetCountriesResponse](../../Models/Requests/GetCountriesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetAllLanguages

Returns a list of all possible languages for EPG data.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAllLanguages" method="get" path="/livetv/epg/languages" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Epg.GetAllLanguagesAsync();

// handle response
```

### Response

**[GetAllLanguagesResponse](../../Models/Requests/GetAllLanguagesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetLineup

Compute the best lineup, given lineup group and device

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLineup" method="get" path="/livetv/epg/lineup" -->
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

GetLineupRequest req = new GetLineupRequest() {
    DeviceQueryParameter = "<value>",
    LineupGroup = "<value>",
};

var res = await sdk.Epg.GetLineupAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [GetLineupRequest](../../Models/Requests/GetLineupRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[GetLineupResponse](../../Models/Requests/GetLineupResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetLineupChannels

Get the channels across multiple lineups

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getLineupChannels" method="get" path="/livetv/epg/lineupchannels" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using System.Collections.Generic;

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

GetLineupChannelsRequest req = new GetLineupChannelsRequest() {
    Lineup = new List<string>() {
        "<value 1>",
        "<value 2>",
    },
};

var res = await sdk.Epg.GetLineupChannelsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetLineupChannelsRequest](../../Models/Requests/GetLineupChannelsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetLineupChannelsResponse](../../Models/Requests/GetLineupChannelsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetCountriesLineups

Returns a list of lineups for a given country, EPG provider and postal code

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCountriesLineups" method="get" path="/livetv/epg/countries/{country}/{epgId}/lineups" -->
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

GetCountriesLineupsRequest req = new GetCountriesLineupsRequest() {
    Country = "Malawi",
    EpgId = "<id>",
};

var res = await sdk.Epg.GetCountriesLineupsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetCountriesLineupsRequest](../../Models/Requests/GetCountriesLineupsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetCountriesLineupsResponse](../../Models/Requests/GetCountriesLineupsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetCountryRegions

Get regions for a country within an EPG provider

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getCountryRegions" method="get" path="/livetv/epg/countries/{country}/{epgId}/regions" -->
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

GetCountryRegionsRequest req = new GetCountryRegionsRequest() {
    Country = "Morocco",
    EpgId = "<id>",
};

var res = await sdk.Epg.GetCountryRegionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetCountryRegionsRequest](../../Models/Requests/GetCountryRegionsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetCountryRegionsResponse](../../Models/Requests/GetCountryRegionsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ListLineups

Get lineups for a region within an EPG provider

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listLineups" method="get" path="/livetv/epg/countries/{country}/{epgId}/regions/{region}/lineups" -->
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

ListLineupsRequest req = new ListLineupsRequest() {
    Country = "Vanuatu",
    EpgId = "<id>",
    Region = "<value>",
};

var res = await sdk.Epg.ListLineupsAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListLineupsRequest](../../Models/Requests/ListLineupsRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[ListLineupsResponse](../../Models/Requests/ListLineupsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |