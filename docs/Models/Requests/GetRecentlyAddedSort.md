# GetRecentlyAddedSort


## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `Default`                                                                                     | *string*                                                                                      | :heavy_minus_sign:                                                                            | N/A                                                                                           | asc                                                                                           |
| `Active`                                                                                      | *bool*                                                                                        | :heavy_minus_sign:                                                                            | N/A                                                                                           | false                                                                                         |
| `ActiveDirection`                                                                             | [GetRecentlyAddedActiveDirection](../../Models/Requests/GetRecentlyAddedActiveDirection.md)   | :heavy_minus_sign:                                                                            | The direction of the sort. Can be either `asc` or `desc`.<br/>                                | asc                                                                                           |
| `DefaultDirection`                                                                            | [GetRecentlyAddedDefaultDirection](../../Models/Requests/GetRecentlyAddedDefaultDirection.md) | :heavy_minus_sign:                                                                            | The direction of the sort. Can be either `asc` or `desc`.<br/>                                | asc                                                                                           |
| `DescKey`                                                                                     | *string*                                                                                      | :heavy_minus_sign:                                                                            | N/A                                                                                           | titleSort:desc                                                                                |
| `FirstCharacterKey`                                                                           | *string*                                                                                      | :heavy_minus_sign:                                                                            | N/A                                                                                           | /library/sections/2/firstCharacter                                                            |
| `Key`                                                                                         | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           | titleSort                                                                                     |
| `Title`                                                                                       | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           | Title                                                                                         |