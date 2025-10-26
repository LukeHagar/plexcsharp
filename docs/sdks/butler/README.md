# Butler
(*Butler*)

## Overview

The butler is responsible for running periodic tasks.  Some tasks run daily, others every few days, and some weekly.  These includes database maintenance, metadata updating, thumbnail generation, media analysis, and other tasks.

### Available Operations

* [StopTasks](#stoptasks) - Stop all Butler tasks
* [GetTasks](#gettasks) - Get all Butler tasks
* [StartTasks](#starttasks) - Start all Butler tasks
* [StopTask](#stoptask) - Stop a single Butler task
* [StartTask](#starttask) - Start a single Butler task

## StopTasks

This endpoint will stop all currently running tasks and remove any scheduled tasks from the queue.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="stopTasks" method="delete" path="/butler" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Butler.StopTasksAsync();

// handle response
```

### Response

**[StopTasksResponse](../../Models/Requests/StopTasksResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## GetTasks

Get the list of butler tasks and their scheduling


### Example Usage

<!-- UsageSnippet language="csharp" operationID="getTasks" method="get" path="/butler" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Butler.GetTasksAsync();

// handle response
```

### Response

**[GetTasksResponse](../../Models/Requests/GetTasksResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## StartTasks

This endpoint will attempt to start all Butler tasks that are enabled in the settings. Butler tasks normally run automatically during a time window configured on the server's Settings page but can be manually started using this endpoint. Tasks will run with the following criteria:

  1. Any tasks not scheduled to run on the current day will be skipped.
  2. If a task is configured to run at a random time during the configured window and we are outside that window, the task will start immediately.
  3. If a task is configured to run at a random time during the configured window and we are within that window, the task will be scheduled at a random time within the window.
  4. If we are outside the configured window, the task will start immediately.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="startTasks" method="post" path="/butler" -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(token: "<YOUR_API_KEY_HERE>");

var res = await sdk.Butler.StartTasksAsync();

// handle response
```

### Response

**[StartTasksResponse](../../Models/Requests/StartTasksResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## StopTask

This endpoint will stop a currently running task by name, or remove it from the list of scheduled tasks if it exists


### Example Usage

<!-- UsageSnippet language="csharp" operationID="stopTask" method="delete" path="/butler/{task}" -->
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

StopTaskRequest req = new StopTaskRequest() {
    Task = Task.CleanOldBundles,
};

var res = await sdk.Butler.StopTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [StopTaskRequest](../../Models/Requests/StopTaskRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[StopTaskResponse](../../Models/Requests/StopTaskResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |

## StartTask

This endpoint will attempt to start a specific Butler task by name.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="startTask" method="post" path="/butler/{task}" -->
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

StartTaskRequest req = new StartTaskRequest() {
    Task = PathParamTask.RefreshLocalMedia,
};

var res = await sdk.Butler.StartTaskAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [StartTaskRequest](../../Models/Requests/StartTaskRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[StartTaskResponse](../../Models/Requests/StartTaskResponse.md)**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException | 4XX, 5XX                                         | \*/\*                                            |