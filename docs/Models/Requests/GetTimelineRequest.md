# GetTimelineRequest


## Fields

| Field                                             | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `RatingKey`                                       | *double*                                          | :heavy_check_mark:                                | The rating key of the media item                  | 23409                                             |
| `Key`                                             | *string*                                          | :heavy_check_mark:                                | The key of the media item to get the timeline for | /library/metadata/23409                           |
| `State`                                           | [State](../../Models/Requests/State.md)           | :heavy_check_mark:                                | The state of the media item                       | playing                                           |
| `HasMDE`                                          | *double*                                          | :heavy_check_mark:                                | Whether the media item has MDE                    | 1                                                 |
| `Time`                                            | *double*                                          | :heavy_check_mark:                                | The time of the media item                        | 2000                                              |
| `Duration`                                        | *double*                                          | :heavy_check_mark:                                | The duration of the media item                    | 10000                                             |
| `Context`                                         | *string*                                          | :heavy_check_mark:                                | The context of the media item                     | home:hub.continueWatching                         |
| `PlayQueueItemID`                                 | *double*                                          | :heavy_check_mark:                                | The play queue item ID of the media item          | 1                                                 |
| `PlayBackTime`                                    | *double*                                          | :heavy_check_mark:                                | The playback time of the media item               | 2000                                              |
| `Row`                                             | *double*                                          | :heavy_check_mark:                                | The row of the media item                         | 1                                                 |