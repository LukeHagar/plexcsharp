# Devices
(*Devices*)

## Overview

Media grabbers provide ways for media to be obtained for a given protocol. The simplest ones are `stream` and `download`. More complex grabbers can have associated devices

Network tuners can present themselves on the network using the Simple Service Discovery Protocol and Plex Media Server will discover them. The following XML is an example of the data returned from SSDP. The `deviceType`, `serviceType`, and `serviceId` values must remain as they are in the example in order for PMS to properly discover the device. Other less-obvious fields are described in the parameters section below.

Example SSDP output
```
<root xmlns="urn:schemas-upnp-org:device-1-0">
    <specVersion>
        <major>1</major>
        <minor>0</minor>
    </specVersion>
    <device>
        <deviceType>urn:plex-tv:device:Media:1</deviceType>
        <friendlyName>Turing Hopper 3000</friendlyName>
        <manufacturer>Plex, Inc.</manufacturer>
        <manufacturerURL>https://plex.tv/</manufacturerURL>
        <modelDescription>Turing Hopper 3000 Media Grabber</modelDescription>
        <modelName>Plex Media Grabber</modelName>
        <modelNumber>1</modelNumber>
        <modelURL>https://plex.tv</modelURL>
        <UDN>uuid:42fde8e4-93b6-41e5-8a63-12d848655811</UDN>
        <serviceList>
            <service>
                <URLBase>http://10.0.0.5:8088</URLBase>
                <serviceType>urn:plex-tv:service:MediaGrabber:1</serviceType>
                <serviceId>urn:plex-tv:serviceId:MediaGrabber</serviceId>
            </service>
        </serviceList>
    </device>
</root>
```

  - UDN: (string) A UUID for the device. This should be unique across models of a device at minimum.
  - URLBase: (string) The base HTTP URL for the device from which all of the other endpoints are hosted.


### Available Operations

* [GetAvailableGrabbers](#getavailablegrabbers) - Get available grabbers
* [ListDevices](#listdevices) - Get all devices
* [AddDevice](#adddevice) - Add a device
* [DiscoverDevices](#discoverdevices) - Tell grabbers to discover devices
* [RemoveDevice](#removedevice) - Remove a device
* [GetDeviceDetails](#getdevicedetails) - Get device details
* [ModifyDevice](#modifydevice) - Enable or disable a device
* [SetChannelmap](#setchannelmap) - Set a device's channel mapping
* [GetDevicesChannels](#getdeviceschannels) - Get a device's channels
* [SetDevicePreferences](#setdevicepreferences) - Set device preferences
* [StopScan](#stopscan) - Tell a device to stop scanning for channels
* [Scan](#scan) - Tell a device to scan for channels
* [GetThumb](#getthumb) - Get device thumb

## GetAvailableGrabbers

Get available grabbers visible to the server

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAvailableGrabbers" method="get" path="/media/grabbers" -->
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

GetAvailableGrabbersRequest req = new GetAvailableGrabbersRequest() {
    Protocol = "livetv",
};

var res = await sdk.Devices.GetAvailableGrabbersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetAvailableGrabbersRequest](../../Models/Requests/GetAvailableGrabbersRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetAvailableGrabbersResponse](../../Models/Requests/GetAvailableGrabbersResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ListDevices

Get the list of all devices present

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listDevices" method="get" path="/media/grabbers/devices" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Devices.ListDevicesAsync();

// handle response
```

### Response

**[ListDevicesResponse](../../Models/Requests/ListDevicesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## AddDevice

This endpoint adds a device to an existing grabber. The device is identified, and added to the correct grabber.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addDevice" method="post" path="/media/grabbers/devices" -->
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

AddDeviceRequest req = new AddDeviceRequest() {
    Uri = "http://10.0.0.5",
};

var res = await sdk.Devices.AddDeviceAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [AddDeviceRequest](../../Models/Requests/AddDeviceRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[AddDeviceResponse](../../Models/Requests/AddDeviceResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DiscoverDevices

Tell grabbers to discover devices

### Example Usage

<!-- UsageSnippet language="csharp" operationID="discoverDevices" method="post" path="/media/grabbers/devices/discover" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Devices.DiscoverDevicesAsync();

// handle response
```

### Response

**[DiscoverDevicesResponse](../../Models/Requests/DiscoverDevicesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## RemoveDevice

Remove a devices by its id along with its channel mappings

### Example Usage

<!-- UsageSnippet language="csharp" operationID="removeDevice" method="delete" path="/media/grabbers/devices/{deviceId}" -->
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

RemoveDeviceRequest req = new RemoveDeviceRequest() {
    DeviceId = 685908,
};

var res = await sdk.Devices.RemoveDeviceAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [RemoveDeviceRequest](../../Models/Requests/RemoveDeviceRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[RemoveDeviceResponse](../../Models/Requests/RemoveDeviceResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetDeviceDetails

Get a device's details by its id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDeviceDetails" method="get" path="/media/grabbers/devices/{deviceId}" -->
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

GetDeviceDetailsRequest req = new GetDeviceDetailsRequest() {
    DeviceId = 170949,
};

var res = await sdk.Devices.GetDeviceDetailsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetDeviceDetailsRequest](../../Models/Requests/GetDeviceDetailsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetDeviceDetailsResponse](../../Models/Requests/GetDeviceDetailsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ModifyDevice

Enable or disable a device by its id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="modifyDevice" method="put" path="/media/grabbers/devices/{deviceId}" -->
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

ModifyDeviceRequest req = new ModifyDeviceRequest() {
    DeviceId = 879135,
    Enabled = BoolInt.True,
};

var res = await sdk.Devices.ModifyDeviceAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ModifyDeviceRequest](../../Models/Requests/ModifyDeviceRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ModifyDeviceResponse](../../Models/Requests/ModifyDeviceResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## SetChannelmap

Set a device's channel mapping

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setChannelmap" method="put" path="/media/grabbers/devices/{deviceId}/channelmap" -->
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

SetChannelmapRequest req = new SetChannelmapRequest() {
    DeviceId = 937661,
    ChannelMapping = new LukeHagar.PlexAPI.SDK.Models.Requests.ChannelMapping() {},
    ChannelMappingByKey = new ChannelMappingByKey() {},
    ChannelsEnabled = new List<string>() {
        "4",
        "6",
        ".",
        "1",
        ",",
        "4",
        "4",
        ".",
        "1",
        ",",
        "4",
        "5",
        ".",
        "1",
    },
};

var res = await sdk.Devices.SetChannelmapAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [SetChannelmapRequest](../../Models/Requests/SetChannelmapRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[SetChannelmapResponse](../../Models/Requests/SetChannelmapResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetDevicesChannels

Get a device's channels by its id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getDevicesChannels" method="get" path="/media/grabbers/devices/{deviceId}/channels" -->
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

GetDevicesChannelsRequest req = new GetDevicesChannelsRequest() {
    DeviceId = 517209,
};

var res = await sdk.Devices.GetDevicesChannelsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetDevicesChannelsRequest](../../Models/Requests/GetDevicesChannelsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetDevicesChannelsResponse](../../Models/Requests/GetDevicesChannelsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## SetDevicePreferences

Set device preferences by its id

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setDevicePreferences" method="put" path="/media/grabbers/devices/{deviceId}/prefs" -->
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

SetDevicePreferencesRequest req = new SetDevicePreferencesRequest() {
    DeviceId = 420973,
};

var res = await sdk.Devices.SetDevicePreferencesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [SetDevicePreferencesRequest](../../Models/Requests/SetDevicePreferencesRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[SetDevicePreferencesResponse](../../Models/Requests/SetDevicePreferencesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## StopScan

Tell a device to stop scanning for channels

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stopScan" method="delete" path="/media/grabbers/devices/{deviceId}/scan" -->
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

StopScanRequest req = new StopScanRequest() {
    DeviceId = 576494,
};

var res = await sdk.Devices.StopScanAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [StopScanRequest](../../Models/Requests/StopScanRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[StopScanResponse](../../Models/Requests/StopScanResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## Scan

Tell a device to scan for channels

### Example Usage

<!-- UsageSnippet language="csharp" operationID="scan" method="post" path="/media/grabbers/devices/{deviceId}/scan" -->
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

ScanRequest req = new ScanRequest() {
    DeviceId = 57391,
    Source = "Cable",
};

var res = await sdk.Devices.ScanAsync(req);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `request`                                           | [ScanRequest](../../Models/Requests/ScanRequest.md) | :heavy_check_mark:                                  | The request object to use for the request.          |

### Response

**[ScanResponse](../../Models/Requests/ScanResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetThumb

Get a device's thumb for display to the user

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getThumb" method="get" path="/media/grabbers/devices/{deviceId}/thumb/{version}" -->
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

GetThumbRequest req = new GetThumbRequest() {
    DeviceId = 960617,
    VersionPathParameter = 1025,
};

var res = await sdk.Devices.GetThumbAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetThumbRequest](../../Models/Requests/GetThumbRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[GetThumbResponse](../../Models/Requests/GetThumbResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |