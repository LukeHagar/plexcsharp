# GetTransientTokenRequest


## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `Type`                                                                                      | [GetTransientTokenQueryParamType](../../Models/Requests/GetTransientTokenQueryParamType.md) | :heavy_check_mark:                                                                          | `delegation` - This is the only supported `type` parameter.                                 |
| `Scope`                                                                                     | [Scope](../../Models/Requests/Scope.md)                                                     | :heavy_check_mark:                                                                          | `all` - This is the only supported `scope` parameter.                                       |