# StartUniversalTranscodeRequest


## Fields

| Field                                         | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `HasMDE`                                      | *double*                                      | :heavy_check_mark:                            | Whether the media item has MDE                |
| `Path`                                        | *string*                                      | :heavy_check_mark:                            | The path to the media item to transcode       |
| `MediaIndex`                                  | *double*                                      | :heavy_check_mark:                            | The index of the media item to transcode      |
| `PartIndex`                                   | *double*                                      | :heavy_check_mark:                            | The index of the part to transcode            |
| `Protocol`                                    | *string*                                      | :heavy_check_mark:                            | The protocol to use for the transcode session |
| `FastSeek`                                    | *double*                                      | :heavy_minus_sign:                            | Whether to use fast seek or not               |
| `DirectPlay`                                  | *double*                                      | :heavy_minus_sign:                            | Whether to use direct play or not             |
| `DirectStream`                                | *double*                                      | :heavy_minus_sign:                            | Whether to use direct stream or not           |
| `SubtitleSize`                                | *double*                                      | :heavy_minus_sign:                            | The size of the subtitles                     |
| `Subtites`                                    | *string*                                      | :heavy_minus_sign:                            | The subtitles                                 |
| `AudioBoost`                                  | *double*                                      | :heavy_minus_sign:                            | The audio boost                               |
| `Location`                                    | *string*                                      | :heavy_minus_sign:                            | The location of the transcode session         |
| `MediaBufferSize`                             | *double*                                      | :heavy_minus_sign:                            | The size of the media buffer                  |
| `Session`                                     | *string*                                      | :heavy_minus_sign:                            | The session ID                                |
| `AddDebugOverlay`                             | *double*                                      | :heavy_minus_sign:                            | Whether to add a debug overlay or not         |
| `AutoAdjustQuality`                           | *double*                                      | :heavy_minus_sign:                            | Whether to auto adjust quality or not         |