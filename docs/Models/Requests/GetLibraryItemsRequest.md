# GetLibraryItemsRequest


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `SectionId`                                           | *object*                                              | :heavy_check_mark:                                    | the Id of the library to query                        |                                                       |
| `Tag`                                                 | [Tag](../../Models/Requests/Tag.md)                   | :heavy_check_mark:                                    | A key representing a specific tag within the section. |                                                       |
| `IncludeGuids`                                        | *long*                                                | :heavy_minus_sign:                                    | Adds the Guids object to the response<br/>            | 1                                                     |