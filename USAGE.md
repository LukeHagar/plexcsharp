<!-- Start SDK Example Usage [usage] -->
```csharp
using PlexAPI;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "gcgzw5rz2xovp84b4vha3a40"
);

var res = await sdk.Server.GetServerCapabilitiesAsync();

// handle response
```
<!-- End SDK Example Usage [usage] -->