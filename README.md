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

StartTranscodeSessionRequest req = new StartTranscodeSessionRequest() {
    TranscodeType = TranscodeType.Music,
    Extension = Extension.Mpd,
    AdvancedSubtitles = LukeHagar.PlexAPI.SDK.Models.Components.AdvancedSubtitles.Burn,
    AudioBoost = 50,
    AudioChannelCount = 5,
    AutoAdjustQuality = BoolInt.True,
    AutoAdjustSubtitle = BoolInt.True,
    DirectPlay = BoolInt.True,
    DirectStream = BoolInt.True,
    DirectStreamAudio = BoolInt.True,
    DisableResolutionRotation = BoolInt.True,
    HasMDE = BoolInt.True,
    Location = StartTranscodeSessionQueryParamLocation.Wan,
    MediaBufferSize = 102400,
    MediaIndex = 0,
    MusicBitrate = 5000,
    Offset = 90.5D,
    PartIndex = 0,
    Path = "/library/metadata/151671",
    PeakBitrate = 12000,
    PhotoResolution = "1080x1080",
    Protocol = StartTranscodeSessionQueryParamProtocol.Dash,
    SecondsPerSegment = 5,
    SubtitleSize = 50,
    VideoBitrate = 12000,
    VideoQuality = 50,
    VideoResolution = "1080x1080",
    XPlexClientProfileExtra = "add-limitation(scope=videoCodec&scopeName=*&type=upperBound&name=video.frameRate&value=60&replace=true)+append-transcode-target-codec(type=videoProfile&context=streaming&videoCodec=h264%2Chevc&audioCodec=aac&protocol=dash)",
    XPlexClientProfileName = "generic",
};

var res = await sdk.Transcoder.StartTranscodeSessionAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Activities](docs/sdks/activities/README.md)

* [ListActivities](docs/sdks/activities/README.md#listactivities) - Get all activities
* [CancelActivity](docs/sdks/activities/README.md#cancelactivity) - Cancel a running activity

### [Authentication](docs/sdks/authentication/README.md)

* [GetTokenDetails](docs/sdks/authentication/README.md#gettokendetails) - Get Token Details
* [PostUsersSignInData](docs/sdks/authentication/README.md#postuserssignindata) - Get User Sign In Data

### [Butler](docs/sdks/butler/README.md)

* [StopTasks](docs/sdks/butler/README.md#stoptasks) - Stop all Butler tasks
* [GetTasks](docs/sdks/butler/README.md#gettasks) - Get all Butler tasks
* [StartTasks](docs/sdks/butler/README.md#starttasks) - Start all Butler tasks
* [StopTask](docs/sdks/butler/README.md#stoptask) - Stop a single Butler task
* [StartTask](docs/sdks/butler/README.md#starttask) - Start a single Butler task

### [Collections](docs/sdks/collections/README.md)

* [CreateCollection](docs/sdks/collections/README.md#createcollection) - Create collection

### [Content](docs/sdks/content/README.md)

* [GetCollectionItems](docs/sdks/content/README.md#getcollectionitems) - Get items in a collection
* [GetMetadataItem](docs/sdks/content/README.md#getmetadataitem) - Get a metadata item
* [GetAlbums](docs/sdks/content/README.md#getalbums) - Set section albums
* [ListContent](docs/sdks/content/README.md#listcontent) - Get items in the section
* [GetAllLeaves](docs/sdks/content/README.md#getallleaves) - Set section leaves
* [GetArts](docs/sdks/content/README.md#getarts) - Set section artwork
* [GetCategories](docs/sdks/content/README.md#getcategories) - Set section categories
* [GetCluster](docs/sdks/content/README.md#getcluster) - Set section clusters
* [GetSonicPath](docs/sdks/content/README.md#getsonicpath) - Similar tracks to transition from one to another
* [GetFolders](docs/sdks/content/README.md#getfolders) - Get all folder locations
* [ListMoments](docs/sdks/content/README.md#listmoments) - Set section moments
* [GetSonicallySimilar](docs/sdks/content/README.md#getsonicallysimilar) - The nearest audio tracks
* [GetCollectionImage](docs/sdks/content/README.md#getcollectionimage) - Get a collection's image

### [Devices](docs/sdks/devices/README.md)

* [GetAvailableGrabbers](docs/sdks/devices/README.md#getavailablegrabbers) - Get available grabbers
* [ListDevices](docs/sdks/devices/README.md#listdevices) - Get all devices
* [AddDevice](docs/sdks/devices/README.md#adddevice) - Add a device
* [DiscoverDevices](docs/sdks/devices/README.md#discoverdevices) - Tell grabbers to discover devices
* [RemoveDevice](docs/sdks/devices/README.md#removedevice) - Remove a device
* [GetDeviceDetails](docs/sdks/devices/README.md#getdevicedetails) - Get device details
* [ModifyDevice](docs/sdks/devices/README.md#modifydevice) - Enable or disable a device
* [SetChannelmap](docs/sdks/devices/README.md#setchannelmap) - Set a device's channel mapping
* [GetDevicesChannels](docs/sdks/devices/README.md#getdeviceschannels) - Get a device's channels
* [SetDevicePreferences](docs/sdks/devices/README.md#setdevicepreferences) - Set device preferences
* [StopScan](docs/sdks/devices/README.md#stopscan) - Tell a device to stop scanning for channels
* [Scan](docs/sdks/devices/README.md#scan) - Tell a device to scan for channels
* [GetThumb](docs/sdks/devices/README.md#getthumb) - Get device thumb

### [DownloadQueue](docs/sdks/downloadqueue/README.md)

* [CreateDownloadQueue](docs/sdks/downloadqueue/README.md#createdownloadqueue) - Create download queue
* [GetDownloadQueue](docs/sdks/downloadqueue/README.md#getdownloadqueue) - Get a download queue
* [AddDownloadQueueItems](docs/sdks/downloadqueue/README.md#adddownloadqueueitems) - Add to download queue
* [ListDownloadQueueItems](docs/sdks/downloadqueue/README.md#listdownloadqueueitems) - Get download queue items
* [GetItemDecision](docs/sdks/downloadqueue/README.md#getitemdecision) - Grab download queue item decision
* [GetDownloadQueueMedia](docs/sdks/downloadqueue/README.md#getdownloadqueuemedia) - Grab download queue media
* [RemoveDownloadQueueItems](docs/sdks/downloadqueue/README.md#removedownloadqueueitems) - Delete download queue items
* [GetDownloadQueueItems](docs/sdks/downloadqueue/README.md#getdownloadqueueitems) - Get download queue items
* [RestartProcessingDownloadQueueItems](docs/sdks/downloadqueue/README.md#restartprocessingdownloadqueueitems) - Restart processing of items from the decision

### [DVRs](docs/sdks/dvrs/README.md)

* [ListDVRs](docs/sdks/dvrs/README.md#listdvrs) - Get DVRs
* [CreateDVR](docs/sdks/dvrs/README.md#createdvr) - Create a DVR
* [DeleteDVR](docs/sdks/dvrs/README.md#deletedvr) - Delete a single DVR
* [GetDVR](docs/sdks/dvrs/README.md#getdvr) - Get a single DVR
* [DeleteLineup](docs/sdks/dvrs/README.md#deletelineup) - Delete a DVR Lineup
* [AddLineup](docs/sdks/dvrs/README.md#addlineup) - Add a DVR Lineup
* [SetDVRPreferences](docs/sdks/dvrs/README.md#setdvrpreferences) - Set DVR preferences
* [StopDVRReload](docs/sdks/dvrs/README.md#stopdvrreload) - Tell a DVR to stop reloading program guide
* [ReloadGuide](docs/sdks/dvrs/README.md#reloadguide) - Tell a DVR to reload program guide
* [TuneChannel](docs/sdks/dvrs/README.md#tunechannel) - Tune a channel on a DVR
* [RemoveDeviceFromDVR](docs/sdks/dvrs/README.md#removedevicefromdvr) - Remove a device from an existing DVR
* [AddDeviceToDVR](docs/sdks/dvrs/README.md#adddevicetodvr) - Add a device to an existing DVR

### [Epg](docs/sdks/epg/README.md)

* [ComputeChannelMap](docs/sdks/epg/README.md#computechannelmap) - Compute the best channel map
* [GetChannels](docs/sdks/epg/README.md#getchannels) - Get channels for a lineup
* [GetCountries](docs/sdks/epg/README.md#getcountries) - Get all countries
* [GetAllLanguages](docs/sdks/epg/README.md#getalllanguages) - Get all languages
* [GetLineup](docs/sdks/epg/README.md#getlineup) - Compute the best lineup
* [GetLineupChannels](docs/sdks/epg/README.md#getlineupchannels) - Get the channels for mulitple lineups
* [GetCountriesLineups](docs/sdks/epg/README.md#getcountrieslineups) - Get lineups for a country via postal code
* [GetCountryRegions](docs/sdks/epg/README.md#getcountryregions) - Get regions for a country
* [ListLineups](docs/sdks/epg/README.md#listlineups) - Get lineups for a region

### [Events](docs/sdks/events/README.md)

* [GetNotifications](docs/sdks/events/README.md#getnotifications) - Connect to Eventsource
* [ConnectWebSocket](docs/sdks/events/README.md#connectwebsocket) - Connect to WebSocket

### [General](docs/sdks/general/README.md)

* [GetServerInfo](docs/sdks/general/README.md#getserverinfo) - Get PMS info
* [GetIdentity](docs/sdks/general/README.md#getidentity) - Get PMS identity
* [GetSourceConnectionInformation](docs/sdks/general/README.md#getsourceconnectioninformation) - Get Source Connection Information
* [GetTransientToken](docs/sdks/general/README.md#gettransienttoken) - Get Transient Tokens

### [Hubs](docs/sdks/hubs/README.md)

* [GetAllHubs](docs/sdks/hubs/README.md#getallhubs) - Get global hubs
* [GetContinueWatching](docs/sdks/hubs/README.md#getcontinuewatching) - Get the continue watching hub
* [GetHubItems](docs/sdks/hubs/README.md#gethubitems) - Get a hub's items
* [GetPromotedHubs](docs/sdks/hubs/README.md#getpromotedhubs) - Get the hubs which are promoted
* [GetMetadataHubs](docs/sdks/hubs/README.md#getmetadatahubs) - Get hubs for section by metadata item
* [GetPostplayHubs](docs/sdks/hubs/README.md#getpostplayhubs) - Get postplay hubs
* [GetRelatedHubs](docs/sdks/hubs/README.md#getrelatedhubs) - Get related hubs
* [GetSectionHubs](docs/sdks/hubs/README.md#getsectionhubs) - Get section hubs
* [ResetSectionDefaults](docs/sdks/hubs/README.md#resetsectiondefaults) - Reset hubs to defaults
* [ListHubs](docs/sdks/hubs/README.md#listhubs) - Get hubs
* [CreateCustomHub](docs/sdks/hubs/README.md#createcustomhub) - Create a custom hub
* [MoveHub](docs/sdks/hubs/README.md#movehub) - Move Hub
* [DeleteCustomHub](docs/sdks/hubs/README.md#deletecustomhub) - Delete a custom hub
* [UpdateHubVisibility](docs/sdks/hubs/README.md#updatehubvisibility) - Change hub visibility

### [Library](docs/sdks/library/README.md)

* [GetLibraryItems](docs/sdks/library/README.md#getlibraryitems) - Get all items in library
* [DeleteCaches](docs/sdks/library/README.md#deletecaches) - Delete library caches
* [CleanBundles](docs/sdks/library/README.md#cleanbundles) - Clean bundles
* [IngestTransientItem](docs/sdks/library/README.md#ingesttransientitem) - Ingest a transient item
* [GetLibraryMatches](docs/sdks/library/README.md#getlibrarymatches) - Get library matches
* [OptimizeDatabase](docs/sdks/library/README.md#optimizedatabase) - Optimize the Database
* [GetRandomArtwork](docs/sdks/library/README.md#getrandomartwork) - Get random artwork
* [GetSections](docs/sdks/library/README.md#getsections) - Get library sections (main Media Provider Only)
* [AddSection](docs/sdks/library/README.md#addsection) - Add a library section
* [StopAllRefreshes](docs/sdks/library/README.md#stopallrefreshes) - Stop refresh
* [GetSectionsPrefs](docs/sdks/library/README.md#getsectionsprefs) - Get section prefs
* [RefreshSectionsMetadata](docs/sdks/library/README.md#refreshsectionsmetadata) - Refresh all sections
* [GetTags](docs/sdks/library/README.md#gettags) - Get all library tags of a type
* [DeleteMetadataItem](docs/sdks/library/README.md#deletemetadataitem) - Delete a metadata item
* [EditMetadataItem](docs/sdks/library/README.md#editmetadataitem) - Edit a metadata item
* [DetectAds](docs/sdks/library/README.md#detectads) - Ad-detect an item
* [GetAllItemLeaves](docs/sdks/library/README.md#getallitemleaves) - Get the leaves of an item
* [AnalyzeMetadata](docs/sdks/library/README.md#analyzemetadata) - Analyze an item
* [GenerateThumbs](docs/sdks/library/README.md#generatethumbs) - Generate thumbs of chapters for an item
* [DetectCredits](docs/sdks/library/README.md#detectcredits) - Credit detect a metadata item
* [GetExtras](docs/sdks/library/README.md#getextras) - Get an item's extras
* [AddExtras](docs/sdks/library/README.md#addextras) - Add to an item's extras
* [GetFile](docs/sdks/library/README.md#getfile) - Get a file from a metadata or media bundle
* [StartBifGeneration](docs/sdks/library/README.md#startbifgeneration) - Start BIF generation of an item
* [DetectIntros](docs/sdks/library/README.md#detectintros) - Intro detect an item
* [CreateMarker](docs/sdks/library/README.md#createmarker) - Create a marker
* [MatchItem](docs/sdks/library/README.md#matchitem) - Match a metadata item
* [ListMatches](docs/sdks/library/README.md#listmatches) - Get metadata matches for an item
* [MergeItems](docs/sdks/library/README.md#mergeitems) - Merge a metadata item
* [ListSonicallySimilar](docs/sdks/library/README.md#listsonicallysimilar) - Get nearest tracks to metadata item
* [SetItemPreferences](docs/sdks/library/README.md#setitempreferences) - Set metadata preferences
* [RefreshItemsMetadata](docs/sdks/library/README.md#refreshitemsmetadata) - Refresh a metadata item
* [GetRelatedItems](docs/sdks/library/README.md#getrelateditems) - Get related items
* [ListSimilar](docs/sdks/library/README.md#listsimilar) - Get similar items
* [SplitItem](docs/sdks/library/README.md#splititem) - Split a metadata item
* [AddSubtitles](docs/sdks/library/README.md#addsubtitles) - Add subtitles
* [GetItemTree](docs/sdks/library/README.md#getitemtree) - Get metadata items as a tree
* [Unmatch](docs/sdks/library/README.md#unmatch) - Unmatch a metadata item
* [ListTopUsers](docs/sdks/library/README.md#listtopusers) - Get metadata top users
* [DetectVoiceActivity](docs/sdks/library/README.md#detectvoiceactivity) - Detect voice activity
* [GetAugmentationStatus](docs/sdks/library/README.md#getaugmentationstatus) - Get augmentation status
* [SetStreamSelection](docs/sdks/library/README.md#setstreamselection) - Set stream selection
* [GetPerson](docs/sdks/library/README.md#getperson) - Get person details
* [ListPersonMedia](docs/sdks/library/README.md#listpersonmedia) - Get media for a person
* [DeleteLibrarySection](docs/sdks/library/README.md#deletelibrarysection) - Delete a library section
* [GetLibraryDetails](docs/sdks/library/README.md#getlibrarydetails) - Get a library section by id
* [EditSection](docs/sdks/library/README.md#editsection) - Edit a library section
* [UpdateItems](docs/sdks/library/README.md#updateitems) - Set the fields of the filtered items
* [StartAnalysis](docs/sdks/library/README.md#startanalysis) - Analyze a section
* [Autocomplete](docs/sdks/library/README.md#autocomplete) - Get autocompletions for search
* [GetCollections](docs/sdks/library/README.md#getcollections) - Get collections in a section
* [GetCommon](docs/sdks/library/README.md#getcommon) - Get common fields for items
* [EmptyTrash](docs/sdks/library/README.md#emptytrash) - Empty section trash
* [GetSectionFilters](docs/sdks/library/README.md#getsectionfilters) - Get section filters
* [GetFirstCharacters](docs/sdks/library/README.md#getfirstcharacters) - Get list of first characters
* [DeleteIndexes](docs/sdks/library/README.md#deleteindexes) - Delete section indexes
* [DeleteIntros](docs/sdks/library/README.md#deleteintros) - Delete section intro markers
* [GetSectionPreferences](docs/sdks/library/README.md#getsectionpreferences) - Get section prefs
* [SetSectionPreferences](docs/sdks/library/README.md#setsectionpreferences) - Set section prefs
* [CancelRefresh](docs/sdks/library/README.md#cancelrefresh) - Cancel section refresh
* [RefreshSection](docs/sdks/library/README.md#refreshsection) - Refresh section
* [GetAvailableSorts](docs/sdks/library/README.md#getavailablesorts) - Get a section sorts
* [GetStreamLevels](docs/sdks/library/README.md#getstreamlevels) - Get loudness about a stream in json
* [GetStreamLoudness](docs/sdks/library/README.md#getstreamloudness) - Get loudness about a stream
* [GetChapterImage](docs/sdks/library/README.md#getchapterimage) - Get a chapter image
* [SetItemArtwork](docs/sdks/library/README.md#setitemartwork) - Set an item's artwork, theme, etc
* [UpdateItemArtwork](docs/sdks/library/README.md#updateitemartwork) - Set an item's artwork, theme, etc
* [DeleteMarker](docs/sdks/library/README.md#deletemarker) - Delete a marker
* [EditMarker](docs/sdks/library/README.md#editmarker) - Edit a marker
* [DeleteMediaItem](docs/sdks/library/README.md#deletemediaitem) - Delete a media item
* [GetPartIndex](docs/sdks/library/README.md#getpartindex) - Get BIF index for a part
* [DeleteCollection](docs/sdks/library/README.md#deletecollection) - Delete a collection
* [GetSectionImage](docs/sdks/library/README.md#getsectionimage) - Get a section composite image
* [DeleteStream](docs/sdks/library/README.md#deletestream) - Delete a stream
* [GetStream](docs/sdks/library/README.md#getstream) - Get a stream
* [SetStreamOffset](docs/sdks/library/README.md#setstreamoffset) - Set a stream offset
* [GetItemArtwork](docs/sdks/library/README.md#getitemartwork) - Get an item's artwork, theme, etc
* [GetMediaPart](docs/sdks/library/README.md#getmediapart) - Get a media part
* [GetImageFromBif](docs/sdks/library/README.md#getimagefrombif) - Get an image from part BIF

### [LibraryCollections](docs/sdks/librarycollections/README.md)

* [AddCollectionItems](docs/sdks/librarycollections/README.md#addcollectionitems) - Add items to a collection
* [DeleteCollectionItem](docs/sdks/librarycollections/README.md#deletecollectionitem) - Delete an item from a collection
* [MoveCollectionItem](docs/sdks/librarycollections/README.md#movecollectionitem) - Reorder an item in the collection

### [LibraryPlaylists](docs/sdks/libraryplaylists/README.md)

* [CreatePlaylist](docs/sdks/libraryplaylists/README.md#createplaylist) - Create a Playlist
* [UploadPlaylist](docs/sdks/libraryplaylists/README.md#uploadplaylist) - Upload
* [DeletePlaylist](docs/sdks/libraryplaylists/README.md#deleteplaylist) - Delete a Playlist
* [UpdatePlaylist](docs/sdks/libraryplaylists/README.md#updateplaylist) - Editing a Playlist
* [GetPlaylistGenerators](docs/sdks/libraryplaylists/README.md#getplaylistgenerators) - Get a playlist's generators
* [ClearPlaylistItems](docs/sdks/libraryplaylists/README.md#clearplaylistitems) - Clearing a playlist
* [AddPlaylistItems](docs/sdks/libraryplaylists/README.md#addplaylistitems) - Adding to  a Playlist
* [DeletePlaylistItem](docs/sdks/libraryplaylists/README.md#deleteplaylistitem) - Delete a Generator
* [GetPlaylistGenerator](docs/sdks/libraryplaylists/README.md#getplaylistgenerator) - Get a playlist generator
* [GetPlaylistGeneratorItems](docs/sdks/libraryplaylists/README.md#getplaylistgeneratoritems) - Get a playlist generator's items
* [MovePlaylistItem](docs/sdks/libraryplaylists/README.md#moveplaylistitem) - Moving items in a playlist
* [RefreshPlaylist](docs/sdks/libraryplaylists/README.md#refreshplaylist) - Reprocess a generator

### [LiveTV](docs/sdks/livetv/README.md)

* [GetSessions](docs/sdks/livetv/README.md#getsessions) - Get all sessions
* [GetLiveTVSession](docs/sdks/livetv/README.md#getlivetvsession) - Get a single session
* [GetSessionPlaylistIndex](docs/sdks/livetv/README.md#getsessionplaylistindex) - Get a session playlist index
* [GetSessionSegment](docs/sdks/livetv/README.md#getsessionsegment) - Get a single session segment

### [Log](docs/sdks/log/README.md)

* [WriteLog](docs/sdks/log/README.md#writelog) - Logging a multi-line message to the Plex Media Server log
* [WriteMessage](docs/sdks/log/README.md#writemessage) - Logging a single-line message to the Plex Media Server log
* [EnablePapertrail](docs/sdks/log/README.md#enablepapertrail) - Enabling Papertrail

### [PlayQueue](docs/sdks/playqueue/README.md)

* [CreatePlayQueue](docs/sdks/playqueue/README.md#createplayqueue) - Create a play queue
* [GetPlayQueue](docs/sdks/playqueue/README.md#getplayqueue) - Retrieve a play queue
* [AddToPlayQueue](docs/sdks/playqueue/README.md#addtoplayqueue) - Add a generator or playlist to a play queue
* [ClearPlayQueue](docs/sdks/playqueue/README.md#clearplayqueue) - Clear a play queue
* [ResetPlayQueue](docs/sdks/playqueue/README.md#resetplayqueue) - Reset a play queue
* [Shuffle](docs/sdks/playqueue/README.md#shuffle) - Shuffle a play queue
* [Unshuffle](docs/sdks/playqueue/README.md#unshuffle) - Unshuffle a play queue
* [DeletePlayQueueItem](docs/sdks/playqueue/README.md#deleteplayqueueitem) - Delete an item from a play queue
* [MovePlayQueueItem](docs/sdks/playqueue/README.md#moveplayqueueitem) - Move an item in a play queue

### [Playlist](docs/sdks/playlist/README.md)

* [ListPlaylists](docs/sdks/playlist/README.md#listplaylists) - List playlists
* [GetPlaylist](docs/sdks/playlist/README.md#getplaylist) - Retrieve Playlist
* [GetPlaylistItems](docs/sdks/playlist/README.md#getplaylistitems) - Retrieve Playlist Contents

### [Plex](docs/sdks/plex/README.md)

* [GetServerResources](docs/sdks/plex/README.md#getserverresources) - Get Server Resources

### [Preferences](docs/sdks/preferences/README.md)

* [GetAllPreferences](docs/sdks/preferences/README.md#getallpreferences) - Get all preferences
* [SetPreferences](docs/sdks/preferences/README.md#setpreferences) - Set preferences
* [GetPreference](docs/sdks/preferences/README.md#getpreference) - Get a preferences

### [Provider](docs/sdks/provider/README.md)

* [ListProviders](docs/sdks/provider/README.md#listproviders) - Get the list of available media providers
* [AddProvider](docs/sdks/provider/README.md#addprovider) - Add a media provider
* [RefreshProviders](docs/sdks/provider/README.md#refreshproviders) - Refresh media providers
* [DeleteMediaProvider](docs/sdks/provider/README.md#deletemediaprovider) - Delete a media provider

### [Rate](docs/sdks/rate/README.md)

* [SetRating](docs/sdks/rate/README.md#setrating) - Rate an item

### [Search](docs/sdks/search/README.md)

* [SearchHubs](docs/sdks/search/README.md#searchhubs) - Search Hub
* [VoiceSearchHubs](docs/sdks/search/README.md#voicesearchhubs) - Voice Search Hub

### [Status](docs/sdks/status/README.md)

* [ListSessions](docs/sdks/status/README.md#listsessions) - List Sessions
* [GetBackgroundTasks](docs/sdks/status/README.md#getbackgroundtasks) - Get background tasks
* [ListPlaybackHistory](docs/sdks/status/README.md#listplaybackhistory) - List Playback History
* [TerminateSession](docs/sdks/status/README.md#terminatesession) - Terminate a session
* [DeleteHistory](docs/sdks/status/README.md#deletehistory) - Delete Single History Item
* [GetHistoryItem](docs/sdks/status/README.md#gethistoryitem) - Get Single History Item

### [Subscriptions](docs/sdks/subscriptions/README.md)

* [GetAllSubscriptions](docs/sdks/subscriptions/README.md#getallsubscriptions) - Get all subscriptions
* [CreateSubscription](docs/sdks/subscriptions/README.md#createsubscription) - Create a subscription
* [ProcessSubscriptions](docs/sdks/subscriptions/README.md#processsubscriptions) - Process all subscriptions
* [GetScheduledRecordings](docs/sdks/subscriptions/README.md#getscheduledrecordings) - Get all scheduled recordings
* [GetTemplate](docs/sdks/subscriptions/README.md#gettemplate) - Get the subscription template
* [CancelGrab](docs/sdks/subscriptions/README.md#cancelgrab) - Cancel an existing grab
* [DeleteSubscription](docs/sdks/subscriptions/README.md#deletesubscription) - Delete a subscription
* [GetSubscription](docs/sdks/subscriptions/README.md#getsubscription) - Get a single subscription
* [EditSubscriptionPreferences](docs/sdks/subscriptions/README.md#editsubscriptionpreferences) - Edit a subscription
* [ReorderSubscription](docs/sdks/subscriptions/README.md#reordersubscription) - Re-order a subscription

### [Timeline](docs/sdks/timeline/README.md)

* [MarkPlayed](docs/sdks/timeline/README.md#markplayed) - Mark an item as played
* [Report](docs/sdks/timeline/README.md#report) - Report media timeline
* [Unscrobble](docs/sdks/timeline/README.md#unscrobble) - Mark an item as unplayed

### [Transcoder](docs/sdks/transcoder/README.md)

* [TranscodeImage](docs/sdks/transcoder/README.md#transcodeimage) - Transcode an image
* [MakeDecision](docs/sdks/transcoder/README.md#makedecision) - Make a decision on media playback
* [TriggerFallback](docs/sdks/transcoder/README.md#triggerfallback) - Manually trigger a transcoder fallback
* [TranscodeSubtitles](docs/sdks/transcoder/README.md#transcodesubtitles) - Transcode subtitles
* [StartTranscodeSession](docs/sdks/transcoder/README.md#starttranscodesession) - Start A Transcoding Session

### [UltraBlur](docs/sdks/ultrablur/README.md)

* [GetColors](docs/sdks/ultrablur/README.md#getcolors) - Get UltraBlur Colors
* [GetImage](docs/sdks/ultrablur/README.md#getimage) - Get UltraBlur Image

### [Updater](docs/sdks/updater/README.md)

* [ApplyUpdates](docs/sdks/updater/README.md#applyupdates) - Applying updates
* [CheckUpdates](docs/sdks/updater/README.md#checkupdates) - Checking for updates
* [GetUpdatesStatus](docs/sdks/updater/README.md#getupdatesstatus) - Querying status of updates

### [Users](docs/sdks/users/README.md)

* [GetUsers](docs/sdks/users/README.md#getusers) - Get list of all connected users

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: int` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                                                     | Variables                                    | Description |
| --- | ---------------------------------------------------------- | -------------------------------------------- | ----------- |
| 0   | `https://{IP-description}.{identifier}.plex.direct:{port}` | `identifier`<br/>`IP-description`<br/>`port` |             |
| 1   | `{protocol}://{host}:{port}`                               | `protocol`<br/>`host`<br/>`port`             |             |
| 2   | `https://{full_server_url}`                                | `full_server_url`                            |             |

If the selected server has variables, you may override its default values through the additional parameters made available in the SDK constructor:

| Variable          | Parameter               | Default                              | Description                                                                                                                                                                                                                                                                                                                                                                          |
| ----------------- | ----------------------- | ------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `identifier`      | `identifier: string`    | `"0123456789abcdef0123456789abcdef"` | The unique identifier of this particular PMS                                                                                                                                                                                                                                                                                                                                         |
| `IP-description`  | `ipDescription: string` | `"1-2-3-4"`                          | A `-` separated string of the IPv4 or IPv6 address components                                                                                                                                                                                                                                                                                                                        |
| `port`            | `port: string`          | `"32400"`                            | The Port number configured on the PMS. Typically (`32400`). <br/>If using a reverse proxy, this would be the port number configured on the proxy.<br/>                                                                                                                                                                                                                               |
| `protocol`        | `protocol: string`      | `"http"`                             | The network protocol to use. Typically (`http` or `https`)                                                                                                                                                                                                                                                                                                                           |
| `host`            | `host: string`          | `"localhost"`                        | The Host of the PMS.<br/>If using on a local network, this is the internal IP address of the server hosting the PMS.<br/>If using on an external network, this is the external IP address for your network, and requires port forwarding.<br/>If using a reverse proxy, this would be the external DNS domain for your network, and requires the proxy handle port forwarding. <br/> |
| `full_server_url` | `fullServerUrl: string` | `"http://localhost:32400"`           | The full manual URL to access the PMS                                                                                                                                                                                                                                                                                                                                                |

#### Example

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    serverIndex: 0,
    identifier: "0123456789abcdef0123456789abcdef",
    ipDescription: "1-2-3-4",
    port: "32400",
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

GetServerInfoRequest req = new GetServerInfoRequest() {};

var res = await sdk.General.GetServerInfoAsync(req);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    serverUrl: "https://http://localhost:32400",
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

GetServerInfoRequest req = new GetServerInfoRequest() {};

var res = await sdk.General.GetServerInfoAsync(req);

// handle response
```

### Override Server URL Per-Operation

The server URL can also be overridden on a per-operation basis, provided a server list was specified for the operation. For example:
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

GetTokenDetailsRequest req = new GetTokenDetailsRequest() {};

var res = await sdk.Authentication.GetTokenDetailsAsync(
    request: req,
    serverUrl: "https://plex.tv/api/v2"
);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name    | Type   | Scheme  |
| ------- | ------ | ------- |
| `Token` | apiKey | API key |

To authenticate with the API the `Token` parameter must be set when initializing the SDK client instance. For example:
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;
using LukeHagar.PlexAPI.SDK.Models.Requests;

var sdk = new PlexAPI(
    token: "<YOUR_API_KEY_HERE>",
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
    marketplace: "googlePlay"
);

GetServerInfoRequest req = new GetServerInfoRequest() {};

var res = await sdk.General.GetServerInfoAsync(req);

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

try
{
    GetTokenDetailsRequest req = new GetTokenDetailsRequest() {};

    var res = await sdk.Authentication.GetTokenDetailsAsync(req);

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

    if (ex is GetTokenDetailsBadRequest) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        GetTokenDetailsBadRequestPayload payload = ex.Payload;
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

<details><summary>Less common exceptions (9)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`PlexAPIError`](./LukeHagar/PlexAPI/SDK/Models/Errors/PlexAPIError.cs):
  * [`GetTokenDetailsBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTokenDetailsBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 240 methods.*
  * [`PostUsersSignInDataBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/PostUsersSignInDataBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 240 methods.*
  * [`GetUsersBadRequest`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetUsersBadRequest.cs): Bad Request - A parameter was not specified, or was specified incorrectly. Status code `400`. Applicable to 1 of 240 methods.*
  * [`GetTokenDetailsUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetTokenDetailsUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 240 methods.*
  * [`PostUsersSignInDataUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/PostUsersSignInDataUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 240 methods.*
  * [`GetUsersUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetUsersUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 240 methods.*
  * [`GetServerResourcesUnauthorized`](./LukeHagar/PlexAPI/SDK/Models/Errors/GetServerResourcesUnauthorized.cs): Unauthorized - Returned if the X-Plex-Token is missing from the header or query. Status code `401`. Applicable to 1 of 240 methods.*
  * [`ResponseValidationError`](./LukeHagar/PlexAPI/SDK/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
<!-- End Error Handling [errors] -->

<!-- Start Summary [summary] -->
## Summary


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
  * [Custom HTTP Client](#custom-http-client)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The C# SDK makes API calls using an `ISpeakeasyHttpClient` that wraps the native
[HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient). This
client provides the ability to attach hooks around the request lifecycle that can be used to modify the request or handle
errors and response.

The `ISpeakeasyHttpClient` interface allows you to either use the default `SpeakeasyHttpClient` that comes with the SDK,
or provide your own custom implementation with customized configuration such as custom message handlers, timeouts,
connection pooling, and other HTTP client settings.

The following example shows how to create a custom HTTP client with request modification and error handling:

```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Create a custom HTTP client
public class CustomHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _defaultClient;

    public CustomHttpClient()
    {
        _defaultClient = new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Add custom header and timeout
        request.Headers.Add("x-custom-header", "custom value");
        request.Headers.Add("x-request-timeout", "30");
        
        try
        {
            var response = await _defaultClient.SendAsync(request, cancellationToken);
            // Log successful response
            Console.WriteLine($"Request successful: {response.StatusCode}");
            return response;
        }
        catch (Exception error)
        {
            // Log error
            Console.WriteLine($"Request failed: {error.Message}");
            throw;
        }
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
        _defaultClient?.Dispose();
    }
}

// Use the custom HTTP client with the SDK
var customHttpClient = new CustomHttpClient();
var sdk = new PlexAPI(client: customHttpClient);
```

<details>
<summary>You can also provide a completely custom HTTP client with your own configuration:</summary>

```csharp
using LukeHagar.PlexAPI.SDK.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Custom HTTP client with custom configuration
public class AdvancedHttpClient : ISpeakeasyHttpClient
{
    private readonly HttpClient _httpClient;

    public AdvancedHttpClient()
    {
        var handler = new HttpClientHandler()
        {
            MaxConnectionsPerServer = 10,
            // ServerCertificateCustomValidationCallback = customCertValidation, // Custom SSL validation if needed
        };

        _httpClient = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        return await _httpClient.SendAsync(request, cancellationToken ?? CancellationToken.None);
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}

var sdk = PlexAPI.Builder()
    .WithClient(new AdvancedHttpClient())
    .Build();
```
</details>

<details>
<summary>For simple debugging, you can enable request/response logging by implementing a custom client:</summary>

```csharp
public class LoggingHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _innerClient;

    public LoggingHttpClient(ISpeakeasyHttpClient innerClient = null)
    {
        _innerClient = innerClient ?? new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Log request
        Console.WriteLine($"Sending {request.Method} request to {request.RequestUri}");
        
        var response = await _innerClient.SendAsync(request, cancellationToken);
        
        // Log response
        Console.WriteLine($"Received {response.StatusCode} response");
        
        return response;
    }

    public void Dispose() => _innerClient?.Dispose();
}

var sdk = new PlexAPI(client: new LoggingHttpClient());
```
</details>

The SDK also provides built-in hook support through the `SDKConfiguration.Hooks` system, which automatically handles
`BeforeRequestAsync`, `AfterSuccessAsync`, and `AfterErrorAsync` hooks for advanced request lifecycle management.
<!-- End Custom HTTP Client [http-client] -->

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
