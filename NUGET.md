# LukeHagar.PlexAPI.SDK


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

<!-- Placeholder for Future Speakeasy SDK Sections -->