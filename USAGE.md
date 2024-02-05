<!-- Start SDK Example Usage [usage] -->
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