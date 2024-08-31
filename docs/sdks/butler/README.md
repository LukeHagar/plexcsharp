# Butler
(*Butler*)

## Overview

Butler is the task manager of the Plex Media Server Ecosystem.


### Available Operations

* [GetButlerTasks](#getbutlertasks) - Get Butler tasks
* [StartAllTasks](#startalltasks) - Start all Butler tasks
* [StopAllTasks](#stopalltasks) - Stop all Butler tasks
* [StartTask](#starttask) - Start a single Butler task
* [StopTask](#stoptask) - Stop a single Butler task

## GetButlerTasks

Returns a list of butler tasks

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Butler.GetButlerTasksAsync();

// handle response
```

### Response

**[GetButlerTasksResponse](../../Models/Requests/GetButlerTasksResponse.md)**

### Errors

| Error Object                                     | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| PlexAPI.Models.Errors.GetButlerTasksResponseBody | 401                                              | application/json                                 |
| PlexAPI.Models.Errors.SDKException               | 4xx-5xx                                          | */*                                              |


## StartAllTasks

This endpoint will attempt to start all Butler tasks that are enabled in the settings. Butler tasks normally run automatically during a time window configured on the server's Settings page but can be manually started using this endpoint. Tasks will run with the following criteria:
1. Any tasks not scheduled to run on the current day will be skipped.
2. If a task is configured to run at a random time during the configured window and we are outside that window, the task will start immediately.
3. If a task is configured to run at a random time during the configured window and we are within that window, the task will be scheduled at a random time within the window.
4. If we are outside the configured window, the task will start immediately.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Butler.StartAllTasksAsync();

// handle response
```

### Response

**[StartAllTasksResponse](../../Models/Requests/StartAllTasksResponse.md)**

### Errors

| Error Object                                    | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| PlexAPI.Models.Errors.StartAllTasksResponseBody | 401                                             | application/json                                |
| PlexAPI.Models.Errors.SDKException              | 4xx-5xx                                         | */*                                             |


## StopAllTasks

This endpoint will stop all currently running tasks and remove any scheduled tasks from the queue.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Butler.StopAllTasksAsync();

// handle response
```

### Response

**[StopAllTasksResponse](../../Models/Requests/StopAllTasksResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| PlexAPI.Models.Errors.StopAllTasksResponseBody | 401                                            | application/json                               |
| PlexAPI.Models.Errors.SDKException             | 4xx-5xx                                        | */*                                            |


## StartTask

This endpoint will attempt to start a single Butler task that is enabled in the settings. Butler tasks normally run automatically during a time window configured on the server's Settings page but can be manually started using this endpoint. Tasks will run with the following criteria:
1. Any tasks not scheduled to run on the current day will be skipped.
2. If a task is configured to run at a random time during the configured window and we are outside that window, the task will start immediately.
3. If a task is configured to run at a random time during the configured window and we are within that window, the task will be scheduled at a random time within the window.
4. If we are outside the configured window, the task will start immediately.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Butler.StartTaskAsync(taskName: PlexAPI.Models.Requests.TaskName.CleanOldBundles);

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `TaskName`                                    | [TaskName](../../Models/Requests/TaskName.md) | :heavy_check_mark:                            | the name of the task to be started.           |

### Response

**[StartTaskResponse](../../Models/Requests/StartTaskResponse.md)**

### Errors

| Error Object                                | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| PlexAPI.Models.Errors.StartTaskResponseBody | 401                                         | application/json                            |
| PlexAPI.Models.Errors.SDKException          | 4xx-5xx                                     | */*                                         |


## StopTask

This endpoint will stop a currently running task by name, or remove it from the list of scheduled tasks if it exists. See the section above for a list of task names for this endpoint.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Butler.StopTaskAsync(taskName: PlexAPI.Models.Requests.PathParamTaskName.BackupDatabase);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `TaskName`                                                      | [PathParamTaskName](../../Models/Requests/PathParamTaskName.md) | :heavy_check_mark:                                              | The name of the task to be started.                             |

### Response

**[StopTaskResponse](../../Models/Requests/StopTaskResponse.md)**

### Errors

| Error Object                               | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| PlexAPI.Models.Errors.StopTaskResponseBody | 401                                        | application/json                           |
| PlexAPI.Models.Errors.SDKException         | 4xx-5xx                                    | */*                                        |
