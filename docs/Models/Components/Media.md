# Media

`Media` represents an one or more media files (parts) and is a child of a metadata item. There aren't necessarily any guaranteed attributes on media elements since the attributes will vary based on the type. The possible attributes are not documented here, but they typically have self-evident names. High-level media information that can be used for badging and flagging, such as `videoResolution` and codecs, is included on the media element.



## Fields

| Field                                         | Type                                          | Required                                      | Description                                   | Example                                       |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `AspectRatio`                                 | *double*                                      | :heavy_minus_sign:                            | N/A                                           | 2.35                                          |
| `AudioChannels`                               | *long*                                        | :heavy_minus_sign:                            | N/A                                           | 2                                             |
| `AudioCodec`                                  | *object*                                      | :heavy_minus_sign:                            | N/A                                           | aac                                           |
| `AudioProfile`                                | *object*                                      | :heavy_minus_sign:                            | N/A                                           | lc                                            |
| `Bitrate`                                     | *long*                                        | :heavy_minus_sign:                            | N/A                                           | 5612                                          |
| `Container`                                   | *object*                                      | :heavy_minus_sign:                            | N/A                                           | mov                                           |
| `Duration`                                    | *long*                                        | :heavy_minus_sign:                            | N/A                                           | 150192                                        |
| `Has64bitOffsets`                             | *bool*                                        | :heavy_minus_sign:                            | N/A                                           | false                                         |
| `HasVoiceActivity`                            | *bool*                                        | :heavy_minus_sign:                            | N/A                                           | true                                          |
| `Height`                                      | *long*                                        | :heavy_minus_sign:                            | N/A                                           | 544                                           |
| `Id`                                          | *long*                                        | :heavy_minus_sign:                            | N/A                                           | 1                                             |
| `OptimizedForStreaming`                       | *bool*                                        | :heavy_minus_sign:                            | N/A                                           | false                                         |
| `Part`                                        | List<[Part](../../Models/Components/Part.md)> | :heavy_minus_sign:                            | N/A                                           |                                               |
| `VideoCodec`                                  | *object*                                      | :heavy_minus_sign:                            | N/A                                           | h264                                          |
| `VideoFrameRate`                              | *object*                                      | :heavy_minus_sign:                            | N/A                                           | 24p                                           |
| `VideoProfile`                                | *object*                                      | :heavy_minus_sign:                            | N/A                                           | main                                          |
| `VideoResolution`                             | *object*                                      | :heavy_minus_sign:                            | N/A                                           | 720                                           |
| `Width`                                       | *long*                                        | :heavy_minus_sign:                            | N/A                                           | 1280                                          |
| `AdditionalProperties`                        | Dictionary<String, *object*>                  | :heavy_minus_sign:                            | N/A                                           |                                               |