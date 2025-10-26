# Policy


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `Scope`                                                                         | [GetPlaylistGeneratorScope](../../Models/Requests/GetPlaylistGeneratorScope.md) | :heavy_minus_sign:                                                              | N/A                                                                             |
| `Unwatched`                                                                     | *bool*                                                                          | :heavy_minus_sign:                                                              | True if only unwatched items are optimized                                      |
| `Value`                                                                         | *long*                                                                          | :heavy_minus_sign:                                                              | If the scope is count, the number of items to optimize                          |