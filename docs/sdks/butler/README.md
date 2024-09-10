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
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Butler.GetButlerTasksAsync();

// handle response
```

### Response

**[GetButlerTasksResponse](../../Models/Requests/GetButlerTasksResponse.md)**

### Errors

| Error Object                                                   | Status Code                                                    | Content Type                                                   |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetButlerTasksBadRequest   | 400                                                            | application/json                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.GetButlerTasksUnauthorized | 401                                                            | application/json                                               |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException               | 4xx-5xx                                                        | */*                                                            |


## StartAllTasks

This endpoint will attempt to start all Butler tasks that are enabled in the settings. Butler tasks normally run automatically during a time window configured on the server's Settings page but can be manually started using this endpoint. Tasks will run with the following criteria:
1. Any tasks not scheduled to run on the current day will be skipped.
2. If a task is configured to run at a random time during the configured window and we are outside that window, the task will start immediately.
3. If a task is configured to run at a random time during the configured window and we are within that window, the task will be scheduled at a random time within the window.
4. If we are outside the configured window, the task will start immediately.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Butler.StartAllTasksAsync();

// handle response
```

### Response

**[StartAllTasksResponse](../../Models/Requests/StartAllTasksResponse.md)**

### Errors

| Error Object                                                  | Status Code                                                   | Content Type                                                  |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.StartAllTasksBadRequest   | 400                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.StartAllTasksUnauthorized | 401                                                           | application/json                                              |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException              | 4xx-5xx                                                       | */*                                                           |


## StopAllTasks

This endpoint will stop all currently running tasks and remove any scheduled tasks from the queue.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Butler.StopAllTasksAsync();

// handle response
```

### Response

**[StopAllTasksResponse](../../Models/Requests/StopAllTasksResponse.md)**

### Errors

| Error Object                                                 | Status Code                                                  | Content Type                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| LukeHagar.PlexAPI.SDK.Models.Errors.StopAllTasksBadRequest   | 400                                                          | application/json                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.StopAllTasksUnauthorized | 401                                                          | application/json                                             |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException             | 4xx-5xx                                                      | */*                                                          |


## StartTask

This endpoint will attempt to start a single Butler task that is enabled in the settings. Butler tasks normally run automatically during a time window configured on the server's Settings page but can be manually started using this endpoint. Tasks will run with the following criteria:
1. Any tasks not scheduled to run on the current day will be skipped.
2. If a task is configured to run at a random time during the configured window and we are outside that window, the task will start immediately.
3. If a task is configured to run at a random time during the configured window and we are within that window, the task will be scheduled at a random time within the window.
4. If we are outside the configured window, the task will start immediately.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Butler.StartTaskAsync(taskName: LukeHagar.PlexAPI.SDK.Models.Requests.TaskName.CleanOldBundles);

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `TaskName`                                    | [TaskName](../../Models/Requests/TaskName.md) | :heavy_check_mark:                            | the name of the task to be started.           |

### Response

**[StartTaskResponse](../../Models/Requests/StartTaskResponse.md)**

### Errors

| Error Object                                              | Status Code                                               | Content Type                                              |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.StartTaskBadRequest   | 400                                                       | application/json                                          |
| LukeHagar.PlexAPI.SDK.Models.Errors.StartTaskUnauthorized | 401                                                       | application/json                                          |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException          | 4xx-5xx                                                   | */*                                                       |


## StopTask

This endpoint will stop a currently running task by name, or remove it from the list of scheduled tasks if it exists. See the section above for a list of task names for this endpoint.


### Example Usage

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Requests;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Butler.StopTaskAsync(taskName: LukeHagar.PlexAPI.SDK.Models.Requests.PathParamTaskName.BackupDatabase);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `TaskName`                                                      | [PathParamTaskName](../../Models/Requests/PathParamTaskName.md) | :heavy_check_mark:                                              | The name of the task to be started.                             |

### Response

**[StopTaskResponse](../../Models/Requests/StopTaskResponse.md)**

### Errors

| Error Object                                             | Status Code                                              | Content Type                                             |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| LukeHagar.PlexAPI.SDK.Models.Errors.StopTaskBadRequest   | 400                                                      | application/json                                         |
| LukeHagar.PlexAPI.SDK.Models.Errors.StopTaskUnauthorized | 401                                                      | application/json                                         |
| LukeHagar.PlexAPI.SDK.Models.Errors.SDKException         | 4xx-5xx                                                  | */*                                                      |
