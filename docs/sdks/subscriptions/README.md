# Subscriptions
(*Subscriptions*)

## Overview

Subscriptions determine which media will be recorded and the criteria for selecting an airing when multiple are available


### Available Operations

* [GetAllSubscriptions](#getallsubscriptions) - Get all subscriptions
* [CreateSubscription](#createsubscription) - Create a subscription
* [ProcessSubscriptions](#processsubscriptions) - Process all subscriptions
* [GetScheduledRecordings](#getscheduledrecordings) - Get all scheduled recordings
* [GetTemplate](#gettemplate) - Get the subscription template
* [CancelGrab](#cancelgrab) - Cancel an existing grab
* [DeleteSubscription](#deletesubscription) - Delete a subscription
* [GetSubscription](#getsubscription) - Get a single subscription
* [EditSubscriptionPreferences](#editsubscriptionpreferences) - Edit a subscription
* [ReorderSubscription](#reordersubscription) - Re-order a subscription

## GetAllSubscriptions

Get all subscriptions and potentially the grabs too

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAllSubscriptions" method="get" path="/media/subscriptions" -->
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

GetAllSubscriptionsRequest req = new GetAllSubscriptionsRequest() {
    IncludeGrabs = BoolInt.True,
    IncludeStorage = BoolInt.True,
};

var res = await sdk.Subscriptions.GetAllSubscriptionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetAllSubscriptionsRequest](../../Models/Requests/GetAllSubscriptionsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetAllSubscriptionsResponse](../../Models/Requests/GetAllSubscriptionsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## CreateSubscription

Create a subscription. The query parameters should be mostly derived from the [template](#tag/Subscriptions/operation/mediaSubscriptionsGetTemplate)

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSubscription" method="post" path="/media/subscriptions" -->
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

CreateSubscriptionRequest req = new CreateSubscriptionRequest() {
    TargetLibrarySectionID = 1,
    TargetSectionLocationID = 3,
    Type = 2,
    Hints = new Hints() {},
    Prefs = new CreateSubscriptionQueryParamPrefs() {},
    Params = new Params() {},
};

var res = await sdk.Subscriptions.CreateSubscriptionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [CreateSubscriptionRequest](../../Models/Requests/CreateSubscriptionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[CreateSubscriptionResponse](../../Models/Requests/CreateSubscriptionResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ProcessSubscriptions

Process all subscriptions asynchronously

### Example Usage

<!-- UsageSnippet language="csharp" operationID="processSubscriptions" method="post" path="/media/subscriptions/process" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Subscriptions.ProcessSubscriptionsAsync();

// handle response
```

### Response

**[ProcessSubscriptionsResponse](../../Models/Requests/ProcessSubscriptionsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetScheduledRecordings

Get all scheduled recordings across all subscriptions

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getScheduledRecordings" method="get" path="/media/subscriptions/scheduled" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Subscriptions.GetScheduledRecordingsAsync();

// handle response
```

### Response

**[GetScheduledRecordingsResponse](../../Models/Requests/GetScheduledRecordingsResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetTemplate

Get the templates for a piece of media which could include fetching one airing, season, the whole show, etc.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTemplate" method="get" path="/media/subscriptions/template" -->
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

GetTemplateRequest req = new GetTemplateRequest() {
    Guid = "plex://episode/5fc70265c40548002d539d23",
};

var res = await sdk.Subscriptions.GetTemplateAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetTemplateRequest](../../Models/Requests/GetTemplateRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetTemplateResponse](../../Models/Requests/GetTemplateResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## CancelGrab

Cancels an existing media grab (recording). It can be used to resolve a conflict which exists for a rolling subscription.
Note: This cancellation does not persist across a server restart, but neither does a rolling subscription itself.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="cancelGrab" method="delete" path="/media/grabbers/operations/{operationId}" -->
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

CancelGrabRequest req = new CancelGrabRequest() {
    OperationId = "<id>",
};

var res = await sdk.Subscriptions.CancelGrabAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [CancelGrabRequest](../../Models/Requests/CancelGrabRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[CancelGrabResponse](../../Models/Requests/CancelGrabResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## DeleteSubscription

Delete a subscription, cancelling all of its grabs as well

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteSubscription" method="delete" path="/media/subscriptions/{subscriptionId}" -->
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

DeleteSubscriptionRequest req = new DeleteSubscriptionRequest() {
    SubscriptionId = 974618,
};

var res = await sdk.Subscriptions.DeleteSubscriptionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [DeleteSubscriptionRequest](../../Models/Requests/DeleteSubscriptionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[DeleteSubscriptionResponse](../../Models/Requests/DeleteSubscriptionResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetSubscription

Get a single subscription and potentially the grabs too

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSubscription" method="get" path="/media/subscriptions/{subscriptionId}" -->
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

GetSubscriptionRequest req = new GetSubscriptionRequest() {
    SubscriptionId = 186713,
    IncludeGrabs = BoolInt.True,
    IncludeStorage = BoolInt.True,
};

var res = await sdk.Subscriptions.GetSubscriptionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetSubscriptionRequest](../../Models/Requests/GetSubscriptionRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetSubscriptionResponse](../../Models/Requests/GetSubscriptionResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## EditSubscriptionPreferences

Edit a subscription's preferences

### Example Usage

<!-- UsageSnippet language="csharp" operationID="editSubscriptionPreferences" method="put" path="/media/subscriptions/{subscriptionId}" -->
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

EditSubscriptionPreferencesRequest req = new EditSubscriptionPreferencesRequest() {
    SubscriptionId = 673918,
    Prefs = new EditSubscriptionPreferencesQueryParamPrefs() {},
};

var res = await sdk.Subscriptions.EditSubscriptionPreferencesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [EditSubscriptionPreferencesRequest](../../Models/Requests/EditSubscriptionPreferencesRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[EditSubscriptionPreferencesResponse](../../Models/Requests/EditSubscriptionPreferencesResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## ReorderSubscription

Re-order a subscription to change its priority

### Example Usage

<!-- UsageSnippet language="csharp" operationID="reorderSubscription" method="put" path="/media/subscriptions/{subscriptionId}/move" -->
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

ReorderSubscriptionRequest req = new ReorderSubscriptionRequest() {
    SubscriptionId = 440634,
};

var res = await sdk.Subscriptions.ReorderSubscriptionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ReorderSubscriptionRequest](../../Models/Requests/ReorderSubscriptionRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ReorderSubscriptionResponse](../../Models/Requests/ReorderSubscriptionResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |