# PastSubscription


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   | Example                                                                       |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Id`                                                                          | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           |                                                                               |
| `Mode`                                                                        | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           |                                                                               |
| `RenewsAt`                                                                    | *long*                                                                        | :heavy_check_mark:                                                            | N/A                                                                           | 1556281940                                                                    |
| `EndsAt`                                                                      | *long*                                                                        | :heavy_check_mark:                                                            | N/A                                                                           | 1556281940                                                                    |
| `Canceled`                                                                    | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           | false                                                                         |
| `GracePeriod`                                                                 | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           | false                                                                         |
| `OnHold`                                                                      | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           | false                                                                         |
| `CanReactivate`                                                               | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           | false                                                                         |
| `CanUpgrade`                                                                  | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           | false                                                                         |
| `CanDowngrade`                                                                | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           | false                                                                         |
| `CanConvert`                                                                  | *bool*                                                                        | :heavy_minus_sign:                                                            | N/A                                                                           | false                                                                         |
| `Type`                                                                        | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           | plexpass                                                                      |
| `Transfer`                                                                    | *string*                                                                      | :heavy_check_mark:                                                            | N/A                                                                           |                                                                               |
| `State`                                                                       | [PostUsersSignInDataState](../../Models/Requests/PostUsersSignInDataState.md) | :heavy_check_mark:                                                            | N/A                                                                           | ended                                                                         |
| `Billing`                                                                     | [Billing](../../Models/Requests/Billing.md)                                   | :heavy_check_mark:                                                            | N/A                                                                           |                                                                               |