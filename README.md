# Plex-API

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package LukeHagar.PlexAPI.SDK
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference LukeHagar/PlexAPI/SDK/LukeHagar.PlexAPI.SDK.csproj
```
<!-- End SDK Installation [installation] -->

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

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Activities](docs/sdks/activities/README.md)

* [GetServerActivities](docs/sdks/activities/README.md#getserveractivities) - Get Server Activities
* [CancelServerActivities](docs/sdks/activities/README.md#cancelserveractivities) - Cancel Server Activities

### [Authentication](docs/sdks/authentication/README.md)

* [GetTransientToken](docs/sdks/authentication/README.md#gettransienttoken) - Get a Transient Token
* [GetSourceConnectionInformation](docs/sdks/authentication/README.md#getsourceconnectioninformation) - Get Source Connection Information
* [GetTokenDetails](docs/sdks/authentication/README.md#gettokendetails) - Get Token Details
* [PostUsersSignInData](docs/sdks/authentication/README.md#postuserssignindata) - Get User Sign In Data

### [Butler](docs/sdks/butler/README.md)

* [GetButlerTasks](docs/sdks/butler/README.md#getbutlertasks) - Get Butler tasks
* [StartAllTasks](docs/sdks/butler/README.md#startalltasks) - Start all Butler tasks
* [StopAllTasks](docs/sdks/butler/README.md#stopalltasks) - Stop all Butler tasks
* [StartTask](docs/sdks/butler/README.md#starttask) - Start a single Butler task
* [StopTask](docs/sdks/butler/README.md#stoptask) - Stop a single Butler task

### [Hubs](docs/sdks/hubs/README.md)

* [GetGlobalHubs](docs/sdks/hubs/README.md#getglobalhubs) - Get Global Hubs
* [GetRecentlyAdded](docs/sdks/hubs/README.md#getrecentlyadded) - Get Recently Added
* [GetLibraryHubs](docs/sdks/hubs/README.md#getlibraryhubs) - Get library specific hubs

### [Library](docs/sdks/library/README.md)

* [GetFileHash](docs/sdks/library/README.md#getfilehash) - Get Hash Value
* [GetRecentlyAddedLibrary](docs/sdks/library/README.md#getrecentlyaddedlibrary) - Get Recently Added
* [GetAllLibraries](docs/sdks/library/README.md#getalllibraries) - Get All Libraries
* [GetLibraryDetails](docs/sdks/library/README.md#getlibrarydetails) - Get Library Details
* [DeleteLibrary](docs/sdks/library/README.md#deletelibrary) - Delete Library Section
* [GetLibraryItems](docs/sdks/library/README.md#getlibraryitems) - Get Library Items
* [GetAllMediaLibrary](docs/sdks/library/README.md#getallmedialibrary) - Get all media of library
* [GetRefreshLibraryMetadata](docs/sdks/library/README.md#getrefreshlibrarymetadata) - Refresh Metadata Of The Library
* [GetSearchLibrary](docs/sdks/library/README.md#getsearchlibrary) - Search Library
* [GetGenresLibrary](docs/sdks/library/README.md#getgenreslibrary) - Get Genres of library media
* [GetCountriesLibrary](docs/sdks/library/README.md#getcountrieslibrary) - Get Countries of library media
* [GetActorsLibrary](docs/sdks/library/README.md#getactorslibrary) - Get Actors of library media
* [GetSearchAllLibraries](docs/sdks/library/README.md#getsearchalllibraries) - Search All Libraries
* [GetMediaMetaData](docs/sdks/library/README.md#getmediametadata) - Get Media Metadata
* [GetMediaArts](docs/sdks/library/README.md#getmediaarts) - Get Media Background Artwork
* [PostMediaArts](docs/sdks/library/README.md#postmediaarts) - Upload Media Background Artwork
* [GetMediaPosters](docs/sdks/library/README.md#getmediaposters) - Get Media Posters
* [PostMediaPoster](docs/sdks/library/README.md#postmediaposter) - Upload Media Poster
* [GetMetadataChildren](docs/sdks/library/README.md#getmetadatachildren) - Get Items Children
* [GetTopWatchedContent](docs/sdks/library/README.md#gettopwatchedcontent) - Get Top Watched Content

### [Log](docs/sdks/log/README.md)

* [LogLine](docs/sdks/log/README.md#logline) - Logging a single line message.
* [LogMultiLine](docs/sdks/log/README.md#logmultiline) - Logging a multi-line message
* [EnablePaperTrail](docs/sdks/log/README.md#enablepapertrail) - Enabling Papertrail

### [Media](docs/sdks/media/README.md)

* [MarkPlayed](docs/sdks/media/README.md#markplayed) - Mark Media Played
* [MarkUnplayed](docs/sdks/media/README.md#markunplayed) - Mark Media Unplayed
* [UpdatePlayProgress](docs/sdks/media/README.md#updateplayprogress) - Update Media Play Progress
* [GetBannerImage](docs/sdks/media/README.md#getbannerimage) - Get Banner Image
* [GetThumbImage](docs/sdks/media/README.md#getthumbimage) - Get Thumb Image

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

### [Plex](docs/sdks/plex/README.md)

* [GetCompanionsData](docs/sdks/plex/README.md#getcompanionsdata) - Get Companions Data
* [GetUserFriends](docs/sdks/plex/README.md#getuserfriends) - Get list of friends of the user logged in
* [GetGeoData](docs/sdks/plex/README.md#getgeodata) - Get Geo Data
* [GetHomeData](docs/sdks/plex/README.md#gethomedata) - Get Plex Home Data
* [GetServerResources](docs/sdks/plex/README.md#getserverresources) - Get Server Resources
* [GetPin](docs/sdks/plex/README.md#getpin) - Get a Pin
* [GetTokenByPinId](docs/sdks/plex/README.md#gettokenbypinid) - Get Access Token by PinId


### [Search](docs/sdks/search/README.md)

* [PerformSearch](docs/sdks/search/README.md#performsearch) - Perform a search
* [PerformVoiceSearch](docs/sdks/search/README.md#performvoicesearch) - Perform a voice search
* [GetSearchResults](docs/sdks/search/README.md#getsearchresults) - Get Search Results

### [Server](docs/sdks/server/README.md)

* [GetServerCapabilities](docs/sdks/server/README.md#getservercapabilities) - Get Server Capabilities
* [GetServerPreferences](docs/sdks/server/README.md#getserverpreferences) - Get Server Preferences
* [GetAvailableClients](docs/sdks/server/README.md#getavailableclients) - Get Available Clients
* [GetDevices](docs/sdks/server/README.md#getdevices) - Get Devices
* [GetServerIdentity](docs/sdks/server/README.md#getserveridentity) - Get Server Identity
* [GetMyPlexAccount](docs/sdks/server/README.md#getmyplexaccount) - Get MyPlex Account
* [GetResizedPhoto](docs/sdks/server/README.md#getresizedphoto) - Get a Resized Photo
* [GetMediaProviders](docs/sdks/server/README.md#getmediaproviders) - Get Media Providers
* [GetServerList](docs/sdks/server/README.md#getserverlist) - Get Server List

### [Sessions](docs/sdks/sessions/README.md)

* [GetSessions](docs/sdks/sessions/README.md#getsessions) - Get Active Sessions
* [GetSessionHistory](docs/sdks/sessions/README.md#getsessionhistory) - Get Session History
* [GetTranscodeSessions](docs/sdks/sessions/README.md#gettranscodesessions) - Get Transcode Sessions
* [StopTranscodeSession](docs/sdks/sessions/README.md#stoptranscodesession) - Stop a Transcode Session

### [Statistics](docs/sdks/statistics/README.md)

* [GetStatistics](docs/sdks/statistics/README.md#getstatistics) - Get Media Statistics
* [GetResourcesStatistics](docs/sdks/statistics/README.md#getresourcesstatistics) - Get Resources Statistics
* [GetBandwidthStatistics](docs/sdks/statistics/README.md#getbandwidthstatistics) - Get Bandwidth Statistics

### [Updater](docs/sdks/updater/README.md)

* [GetUpdateStatus](docs/sdks/updater/README.md#getupdatestatus) - Querying status of updates
* [CheckForUpdates](docs/sdks/updater/README.md#checkforupdates) - Checking for updates
* [ApplyUpdates](docs/sdks/updater/README.md#applyupdates) - Apply Updates

### [Users](docs/sdks/users/README.md)

* [GetUsers](docs/sdks/users/README.md#getusers) - Get list of all connected users

### [Video](docs/sdks/video/README.md)

* [GetTimeline](docs/sdks/video/README.md#gettimeline) - Get the timeline for a media item
* [StartUniversalTranscode](docs/sdks/video/README.md#startuniversaltranscode) - Start Universal Transcode

### [Watchlist](docs/sdks/watchlist/README.md)

* [GetWatchList](docs/sdks/watchlist/README.md#getwatchlist) - Get User Watchlist

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Server Variables

The default server `https://10.10.10.47:32400` contains variables and is set to `https://10.10.10.47:32400` by default. To override default values, the following parameters are available when initializing the SDK client instance:

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

<!-- Start Summary [summary] -->
## Summary

Plex-API: An Open API Spec for interacting with Plex.tv and Plex Media Server

# Plex Media Server OpenAPI Specification

An Open Source OpenAPI Specification for Plex Media Server

Automation and SDKs provided by [Speakeasy](https://speakeasyapi.dev/)

## Documentation

[API Documentation](https://plexapi.dev)

## SDKs

The following SDKs are generated from the OpenAPI Specification. They are automatically generated and may not be fully tested. If you find any issues, please open an issue on the [main specification Repository](https://github.com/LukeHagar/plex-api-spec).

| Language              | Repository                                        | Releases                                                                                         | Other                                                   |
| --------------------- | ------------------------------------------------- | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------- |
| Python                | [GitHub](https://github.com/LukeHagar/plexpy)     | [PyPI](https://pypi.org/project/plex-api-client/)                                                | -                                                       |
| JavaScript/TypeScript | [GitHub](https://github.com/LukeHagar/plexjs)     | [NPM](https://www.npmjs.com/package/@lukehagar/plexjs) \ [JSR](https://jsr.io/@lukehagar/plexjs) | -                                                       |
| Go                    | [GitHub](https://github.com/LukeHagar/plexgo)     | [Releases](https://github.com/LukeHagar/plexgo/releases)                                         | [GoDoc](https://pkg.go.dev/github.com/LukeHagar/plexgo) |
| Ruby                  | [GitHub](https://github.com/LukeHagar/plexruby)   | [Releases](https://github.com/LukeHagar/plexruby/releases)                                       | -                                                       |
| Swift                 | [GitHub](https://github.com/LukeHagar/plexswift)  | [Releases](https://github.com/LukeHagar/plexswift/releases)                                      | -                                                       |
| PHP                   | [GitHub](https://github.com/LukeHagar/plexphp)    | [Releases](https://github.com/LukeHagar/plexphp/releases)                                        | -                                                       |
| Java                  | [GitHub](https://github.com/LukeHagar/plexjava)   | [Releases](https://github.com/LukeHagar/plexjava/releases)                                       | -                                                       |
| C#                    | [GitHub](https://github.com/LukeHagar/plexcsharp) | [Releases](https://github.com/LukeHagar/plexcsharp/releases)                                     | -
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [Plex-API](#plex-api)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Server Selection](#server-selection)
  * [Authentication](#authentication)
  * [Error Handling](#error-handling)
* [Plex Media Server OpenAPI Specification](#plex-media-server-openapi-specification)
  * [Documentation](#documentation)
  * [SDKs](#sdks)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

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
