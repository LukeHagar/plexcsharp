<!-- Start SDK Example Usage [usage] -->
```csharp
using LukeHagar.PlexAPI.SDK;
using LukeHagar.PlexAPI.SDK.Models.Components;

var sdk = new PlexAPI(accessToken: "<YOUR_API_KEY_HERE>");

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->