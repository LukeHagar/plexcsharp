# Plex-API

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package Plex-API
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Server](docs/sdks/server/README.md)

* [GetServerCapabilities](docs/sdks/server/README.md#getservercapabilities) - Server Capabilities
* [GetServerPreferences](docs/sdks/server/README.md#getserverpreferences) - Get Server Preferences
* [GetAvailableClients](docs/sdks/server/README.md#getavailableclients) - Get Available Clients
* [GetDevices](docs/sdks/server/README.md#getdevices) - Get Devices
* [GetServerIdentity](docs/sdks/server/README.md#getserveridentity) - Get Server Identity
* [GetMyPlexAccount](docs/sdks/server/README.md#getmyplexaccount) - Get MyPlex Account
* [GetResizedPhoto](docs/sdks/server/README.md#getresizedphoto) - Get a Resized Photo
* [GetServerList](docs/sdks/server/README.md#getserverlist) - Get Server List

### [Media](docs/sdks/media/README.md)

* [MarkPlayed](docs/sdks/media/README.md#markplayed) - Mark Media Played
* [MarkUnplayed](docs/sdks/media/README.md#markunplayed) - Mark Media Unplayed
* [UpdatePlayProgress](docs/sdks/media/README.md#updateplayprogress) - Update Media Play Progress

### [Video](docs/sdks/video/README.md)

* [GetTimeline](docs/sdks/video/README.md#gettimeline) - Get the timeline for a media item
* [StartUniversalTranscode](docs/sdks/video/README.md#startuniversaltranscode) - Start Universal Transcode

### [Activities](docs/sdks/activities/README.md)

* [GetServerActivities](docs/sdks/activities/README.md#getserveractivities) - Get Server Activities
* [CancelServerActivities](docs/sdks/activities/README.md#cancelserveractivities) - Cancel Server Activities

### [Butler](docs/sdks/butler/README.md)

* [GetButlerTasks](docs/sdks/butler/README.md#getbutlertasks) - Get Butler tasks
* [StartAllTasks](docs/sdks/butler/README.md#startalltasks) - Start all Butler tasks
* [StopAllTasks](docs/sdks/butler/README.md#stopalltasks) - Stop all Butler tasks
* [StartTask](docs/sdks/butler/README.md#starttask) - Start a single Butler task
* [StopTask](docs/sdks/butler/README.md#stoptask) - Stop a single Butler task

### [Hubs](docs/sdks/hubs/README.md)

* [GetGlobalHubs](docs/sdks/hubs/README.md#getglobalhubs) - Get Global Hubs
* [GetLibraryHubs](docs/sdks/hubs/README.md#getlibraryhubs) - Get library specific hubs

### [Search](docs/sdks/search/README.md)

* [PerformSearch](docs/sdks/search/README.md#performsearch) - Perform a search
* [PerformVoiceSearch](docs/sdks/search/README.md#performvoicesearch) - Perform a voice search
* [GetSearchResults](docs/sdks/search/README.md#getsearchresults) - Get Search Results

### [Library](docs/sdks/library/README.md)

* [GetFileHash](docs/sdks/library/README.md#getfilehash) - Get Hash Value
* [GetRecentlyAdded](docs/sdks/library/README.md#getrecentlyadded) - Get Recently Added
* [GetLibraries](docs/sdks/library/README.md#getlibraries) - Get All Libraries
* [GetLibrary](docs/sdks/library/README.md#getlibrary) - Get Library Details
* [DeleteLibrary](docs/sdks/library/README.md#deletelibrary) - Delete Library Section
* [GetLibraryItems](docs/sdks/library/README.md#getlibraryitems) - Get Library Items
* [RefreshLibrary](docs/sdks/library/README.md#refreshlibrary) - Refresh Library
* [SearchLibrary](docs/sdks/library/README.md#searchlibrary) - Search Library
* [GetMetadata](docs/sdks/library/README.md#getmetadata) - Get Items Metadata
* [GetMetadataChildren](docs/sdks/library/README.md#getmetadatachildren) - Get Items Children
* [GetOnDeck](docs/sdks/library/README.md#getondeck) - Get On Deck

### [Log](docs/sdks/log/README.md)

* [LogLine](docs/sdks/log/README.md#logline) - Logging a single line message.
* [LogMultiLine](docs/sdks/log/README.md#logmultiline) - Logging a multi-line message
* [EnablePaperTrail](docs/sdks/log/README.md#enablepapertrail) - Enabling Papertrail

### [Plex](docs/sdks/plex/README.md)

* [GetPin](docs/sdks/plex/README.md#getpin) - Get a Pin
* [GetToken](docs/sdks/plex/README.md#gettoken) - Get Access Token

### [Playlists](docs/sdks/playlists/README.md)

* [CreatePlaylist](docs/sdks/playlists/README.md#createplaylist) - Create a Playlist
* [GetPlaylists](docs/sdks/playlists/README.md#getplaylists) - Get All Playlists
* [GetPlaylist](docs/sdks/playlists/README.md#getplaylist) - Retrieve Playlist
* [DeletePlaylist](docs/sdks/playlists/README.md#deleteplaylist) - Deletes a Playlist
* [UpdatePlaylist](docs/sdks/playlists/README.md#updateplaylist) - Update a Playlist
* [GetPlaylistContents](docs/sdks/playlists/README.md#getplaylistcontents) - Retrieve Playlist Contents
* [ClearPlaylistContents](docs/sdks/playlists/README.md#clearplaylistcontents) - Delete Playlist Contents
* [AddPlaylistContents](docs/sdks/playlists/README.md#addplaylistcontents) - Adding to a Playlist
* [UploadPlaylist](docs/sdks/playlists/README.md#uploadplaylist) - Upload Playlist

### [Security](docs/sdks/security/README.md)

* [GetTransientToken](docs/sdks/security/README.md#gettransienttoken) - Get a Transient Token.
* [GetSourceConnectionInformation](docs/sdks/security/README.md#getsourceconnectioninformation) - Get Source Connection Information

### [Statistics](docs/sdks/statistics/README.md)

* [GetStatistics](docs/sdks/statistics/README.md#getstatistics) - Get Media Statistics

### [Sessions](docs/sdks/sessions/README.md)

* [GetSessions](docs/sdks/sessions/README.md#getsessions) - Get Active Sessions
* [GetSessionHistory](docs/sdks/sessions/README.md#getsessionhistory) - Get Session History
* [GetTranscodeSessions](docs/sdks/sessions/README.md#gettranscodesessions) - Get Transcode Sessions
* [StopTranscodeSession](docs/sdks/sessions/README.md#stoptranscodesession) - Stop a Transcode Session

### [Updater](docs/sdks/updater/README.md)

* [GetUpdateStatus](docs/sdks/updater/README.md#getupdatestatus) - Querying status of updates
* [CheckForUpdates](docs/sdks/updater/README.md#checkforupdates) - Checking for updates
* [ApplyUpdates](docs/sdks/updater/README.md#applyupdates) - Apply Updates
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `{protocol}://{ip}:{port}` | `protocol` (default is `http`), `ip` (default is `10.10.10.47`), `port` (default is `32400`) |



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
using PlexAPI;
using PlexAPI.Models.Components;
using PlexAPI.Models.Requests;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Plex.GetPinAsync(
    serverUrl: "https://plex.tv/api/v2",
    xPlexClientIdentifier: "<value>",
    strong: false);

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

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(security: new Models.Components.Security() {
        AccessToken = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
