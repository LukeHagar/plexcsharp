<!-- Start SDK Example Usage [usage] -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(
    accessToken: "<YOUR_API_KEY_HERE>",
    clientID: "gcgzw5rz2xovp84b4vha3a40",
    clientName: "Plex Web",
    clientVersion: "4.133.0",
    clientPlatform: "Chrome",
    deviceName: "Linux"
);

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->