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
* [GetLibrarySectionsAll](docs/sdks/library/README.md#getlibrarysectionsall) - Get Library section media by tag ALL
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
    ip: "4982:bc2a:b4f8:efb5:2394:5bc3:ab4f:0e6d",
    port: "44765",
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

[`PlexAPIError`](./LukeHagar/PlexAPI/SDK/Models/Errors/PlexAPIError.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `StatusCode`  | *int*                 | HTTP status code      |
| `Headers`     | *HttpResponseHeaders* | HTTP headers          |
| `ContentType` | *string?*             | HTTP content type     |
| `RawResponse` | *HttpResponseMessage* | HTTP response object  |
| `Body`        | *string*              | HTTP response body    |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

### Example

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Errors;
using System.Collections.Generic;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

try
{
    var res = await sdk.Server.GetServerCapabilitiesAsync();

    // handle response
}
catch (PlexAPIError ex)  // all SDK exceptions inherit from PlexAPIError
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpResponseMessage rawResponse = ex.RawResponse;
    HttpResponseHeaders headers = ex.Headers;
    int statusCode = ex.StatusCode;
    string? contentType = ex.ContentType;
    var responseBody = ex.Body;

    if (ex is GetServerCapabilitiesBadRequest) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        GetServerCapabilitiesBadRequestPayload payload = ex.Payload;
        List<Errors> Errors = payload.Errors;
        HttpResponseMessage RawResponse = payload.RawResponse;
    }

    // An underlying cause may be provided
    if (ex.InnerException != null)
    {
        Exception cause = ex.InnerException;
    }
}
catch (System.Net.Http.HttpRequestException ex)
{
    // Check ex.InnerException for Network connectivity errors
}
```

### Error Classes

**Primary exception:**
* [`PlexAPIError`](./LukeHagar/PlexAPI/SDK/Models/Errors/PlexAPIError.cs): The base class for HTTP error responses.

<details><summary>Less common exceptions (158)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`PlexAPIError`](./LukeHagar/PlexAPI/SDK/Models/Errors/PlexAPIError.cs):
  * [`GetServerCapabilitiesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerCapabilitiesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetServerPreferencesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerPreferencesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetAvailableClientsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetAvailableClientsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetDevicesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetDevicesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetMyPlexAccountBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetMyPlexAccountBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetResizedPhotoBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetResizedPhotoBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetMediaProvidersBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetMediaProvidersBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetServerListBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerListBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`MarkPlayedBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/MarkPlayedBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`MarkUnplayedBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/MarkUnplayedBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`UpdatePlayProgressBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/UpdatePlayProgressBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetBannerImageBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetBannerImageBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetThumbImageBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetThumbImageBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetTimelineBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTimelineBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`StartUniversalTranscodeBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/StartUniversalTranscodeBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetServerActivitiesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerActivitiesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`CancelServerActivitiesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/CancelServerActivitiesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetButlerTasksBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetButlerTasksBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`StartAllTasksBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/StartAllTasksBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`StopAllTasksBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/StopAllTasksBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`StartTaskBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/StartTaskBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`StopTaskBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/StopTaskBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetCompanionsDataBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetCompanionsDataBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetUserFriendsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetUserFriendsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetGeoDataBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetGeoDataBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetHomeDataBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetHomeDataBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetServerResourcesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerResourcesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetPinBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetPinBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetTokenByPinIdBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTokenByPinIdBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetGlobalHubsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetGlobalHubsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetLibraryHubsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetLibraryHubsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`PerformSearchBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/PerformSearchBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`PerformVoiceSearchBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/PerformVoiceSearchBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetSearchResultsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSearchResultsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetFileHashBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetFileHashBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetRecentlyAddedLibraryBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetRecentlyAddedLibraryBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetAllLibrariesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetAllLibrariesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetLibraryDetailsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetLibraryDetailsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`DeleteLibraryBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/DeleteLibraryBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetLibraryItemsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetLibraryItemsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetLibrarySectionsAllBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetLibrarySectionsAllBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetRefreshLibraryMetadataBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetRefreshLibraryMetadataBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetSearchLibraryBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSearchLibraryBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetGenresLibraryBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetGenresLibraryBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetCountriesLibraryBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetCountriesLibraryBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetActorsLibraryBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetActorsLibraryBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetSearchAllLibrariesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSearchAllLibrariesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetMediaMetaDataBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetMediaMetaDataBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetMetadataChildrenBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetMetadataChildrenBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetTopWatchedContentBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTopWatchedContentBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetWatchListBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetWatchListBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`LogLineBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/LogLineBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`LogMultiLineBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/LogMultiLineBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`EnablePaperTrailBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/EnablePaperTrailBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`CreatePlaylistBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/CreatePlaylistBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetPlaylistsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetPlaylistsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetPlaylistBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetPlaylistBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`DeletePlaylistBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/DeletePlaylistBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`UpdatePlaylistBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/UpdatePlaylistBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetPlaylistContentsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetPlaylistContentsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`ClearPlaylistContentsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/ClearPlaylistContentsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`AddPlaylistContentsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/AddPlaylistContentsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`UploadPlaylistBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/UploadPlaylistBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetTransientTokenBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTransientTokenBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetSourceConnectionInformationBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSourceConnectionInformationBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetTokenDetailsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTokenDetailsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`PostUsersSignInDataBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/PostUsersSignInDataBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetStatisticsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetStatisticsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetResourcesStatisticsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetResourcesStatisticsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetBandwidthStatisticsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetBandwidthStatisticsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetSessionsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSessionsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetSessionHistoryBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSessionHistoryBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetTranscodeSessionsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTranscodeSessionsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`StopTranscodeSessionBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/StopTranscodeSessionBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetUpdateStatusBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetUpdateStatusBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`CheckForUpdatesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/CheckForUpdatesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`ApplyUpdatesBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/ApplyUpdatesBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetUsersBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetUsersBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 84 methods.*
  * [`GetServerCapabilitiesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerCapabilitiesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetServerPreferencesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerPreferencesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetAvailableClientsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetAvailableClientsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetDevicesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetDevicesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetMyPlexAccountUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetMyPlexAccountUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetResizedPhotoUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetResizedPhotoUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetMediaProvidersUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetMediaProvidersUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetServerListUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerListUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`MarkPlayedUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/MarkPlayedUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`MarkUnplayedUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/MarkUnplayedUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`UpdatePlayProgressUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/UpdatePlayProgressUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetBannerImageUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetBannerImageUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetThumbImageUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetThumbImageUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetTimelineUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTimelineUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`StartUniversalTranscodeUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/StartUniversalTranscodeUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetServerActivitiesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerActivitiesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`CancelServerActivitiesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/CancelServerActivitiesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetButlerTasksUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetButlerTasksUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`StartAllTasksUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/StartAllTasksUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`StopAllTasksUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/StopAllTasksUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`StartTaskUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/StartTaskUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`StopTaskUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/StopTaskUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetCompanionsDataUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetCompanionsDataUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetUserFriendsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetUserFriendsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetGeoDataUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetGeoDataUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetHomeDataUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetHomeDataUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetServerResourcesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerResourcesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetGlobalHubsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetGlobalHubsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetLibraryHubsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetLibraryHubsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`PerformSearchUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/PerformSearchUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`PerformVoiceSearchUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/PerformVoiceSearchUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetSearchResultsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSearchResultsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetFileHashUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetFileHashUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetRecentlyAddedLibraryUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetRecentlyAddedLibraryUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetAllLibrariesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetAllLibrariesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetLibraryDetailsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetLibraryDetailsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`DeleteLibraryUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/DeleteLibraryUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetLibraryItemsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetLibraryItemsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetLibrarySectionsAllUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetLibrarySectionsAllUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetRefreshLibraryMetadataUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetRefreshLibraryMetadataUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetSearchLibraryUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSearchLibraryUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetGenresLibraryUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetGenresLibraryUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetCountriesLibraryUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetCountriesLibraryUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetActorsLibraryUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetActorsLibraryUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetSearchAllLibrariesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSearchAllLibrariesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetMediaMetaDataUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetMediaMetaDataUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetMetadataChildrenUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetMetadataChildrenUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetTopWatchedContentUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTopWatchedContentUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetWatchListUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetWatchListUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`LogLineUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/LogLineUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`LogMultiLineUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/LogMultiLineUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`EnablePaperTrailUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/EnablePaperTrailUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`CreatePlaylistUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/CreatePlaylistUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetPlaylistsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetPlaylistsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetPlaylistUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetPlaylistUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`DeletePlaylistUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/DeletePlaylistUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`UpdatePlaylistUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/UpdatePlaylistUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetPlaylistContentsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetPlaylistContentsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`ClearPlaylistContentsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/ClearPlaylistContentsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`AddPlaylistContentsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/AddPlaylistContentsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`UploadPlaylistUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/UploadPlaylistUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetTransientTokenUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTransientTokenUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetSourceConnectionInformationUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSourceConnectionInformationUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetTokenDetailsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTokenDetailsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`PostUsersSignInDataUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/PostUsersSignInDataUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetStatisticsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetStatisticsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetResourcesStatisticsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetResourcesStatisticsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetBandwidthStatisticsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetBandwidthStatisticsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetSessionsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSessionsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetSessionHistoryUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetSessionHistoryUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetTranscodeSessionsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTranscodeSessionsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`StopTranscodeSessionUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/StopTranscodeSessionUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetUpdateStatusUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetUpdateStatusUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`CheckForUpdatesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/CheckForUpdatesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`ApplyUpdatesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/ApplyUpdatesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetUsersUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetUsersUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 84 methods.*
  * [`GetTokenByPinIdResponseBody`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTokenByPinIdResponseBody.cs): Not Found or Expired. Status code `404`. Applicable to 1 of 84 methods.*
  * [`GetServerIdentityRequestTimeout`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerIdentityRequestTimeout.cs): Request Timeout. Status code `408`. Applicable to 1 of 84 methods.*
  * [`ResponseValidationError`](./LukeHagar/PlexAPI/SDK/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
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
