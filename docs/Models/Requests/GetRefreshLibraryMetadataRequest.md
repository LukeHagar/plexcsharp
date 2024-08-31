# GetRefreshLibraryMetadataRequest


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `SectionId`                                                       | *double*                                                          | :heavy_check_mark:                                                | The id of the library                                             | 15                                                                |
| `Force`                                                           | [Force](../../Models/Requests/Force.md)                           | :heavy_minus_sign:                                                | Force the refresh even if the library is already being refreshed. | 0                                                                 |