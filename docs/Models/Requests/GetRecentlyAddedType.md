# GetRecentlyAddedType


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     | Example                                                                         |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `Key`                                                                           | *string*                                                                        | :heavy_check_mark:                                                              | N/A                                                                             | /library/sections/2/all?type=2                                                  |
| `Type`                                                                          | *string*                                                                        | :heavy_check_mark:                                                              | N/A                                                                             | show                                                                            |
| `Title`                                                                         | *string*                                                                        | :heavy_check_mark:                                                              | N/A                                                                             | TV Shows                                                                        |
| `Active`                                                                        | *bool*                                                                          | :heavy_check_mark:                                                              | N/A                                                                             | false                                                                           |
| `Filter`                                                                        | List<[GetRecentlyAddedFilter](../../Models/Requests/GetRecentlyAddedFilter.md)> | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `Sort`                                                                          | List<[GetRecentlyAddedSort](../../Models/Requests/GetRecentlyAddedSort.md)>     | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |
| `Field`                                                                         | List<[GetRecentlyAddedField](../../Models/Requests/GetRecentlyAddedField.md)>   | :heavy_minus_sign:                                                              | N/A                                                                             |                                                                                 |