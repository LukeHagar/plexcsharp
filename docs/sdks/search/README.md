# Search
(*Search*)

## Overview

API Calls that perform search operations with Plex Media Server


### Available Operations

* [PerformSearch](#performsearch) - Perform a search
* [PerformVoiceSearch](#performvoicesearch) - Perform a voice search
* [GetSearchResults](#getsearchresults) - Get Search Results

## PerformSearch

This endpoint performs a search across all library sections, or a single section, and returns matches as hubs, split up by type. It performs spell checking, looks for partial matches, and orders the hubs based on quality of results. In addition, based on matches, it will return other related matches (e.g. for a genre match, it may return movies in that genre, or for an actor match, movies with that actor).

In the response's items, the following extra attributes are returned to further describe or disambiguate the result:

- `reason`: The reason for the result, if not because of a direct search term match; can be either:
  - `section`: There are multiple identical results from different sections.
  - `originalTitle`: There was a search term match from the original title field (sometimes those can be very different or in a foreign language).
  - `<hub identifier>`: If the reason for the result is due to a result in another hub, the source hub identifier is returned. For example, if the search is for "dylan" then Bob Dylan may be returned as an artist result, an a few of his albums returned as album results with a reason code of `artist` (the identifier of that particular hub). Or if the search is for "arnold", there might be movie results returned with a reason of `actor`
- `reasonTitle`: The string associated with the reason code. For a section reason, it'll be the section name; For a hub identifier, it'll be a string associated with the match (e.g. `Arnold Schwarzenegger` for movies which were returned because the search was for "arnold").
- `reasonID`: The ID of the item associated with the reason for the result. This might be a section ID, a tag ID, an artist ID, or a show ID.

This request is intended to be very fast, and called as the user types.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Search.PerformSearchAsync(
    query: "dylan",
    sectionId: 1516.53D,
    limit: 5D
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Query`                                                                               | *string*                                                                              | :heavy_check_mark:                                                                    | The query term                                                                        | arnold                                                                                |
| `SectionId`                                                                           | *double*                                                                              | :heavy_minus_sign:                                                                    | This gives context to the search, and can result in re-ordering of search result hubs |                                                                                       |
| `Limit`                                                                               | *double*                                                                              | :heavy_minus_sign:                                                                    | The number of items to return per hub                                                 | 5                                                                                     |

### Response

**[PerformSearchResponse](../../Models/Requests/PerformSearchResponse.md)**

### Errors

| Error Object                                    | Status Code                                     | Content Type                                    |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| PlexAPI.Models.Errors.PerformSearchResponseBody | 401                                             | application/json                                |
| PlexAPI.Models.Errors.SDKException              | 4xx-5xx                                         | */*                                             |


## PerformVoiceSearch

This endpoint performs a search specifically tailored towards voice or other imprecise input which may work badly with the substring and spell-checking heuristics used by the `/hubs/search` endpoint. 
It uses a [Levenshtein distance](https://en.wikipedia.org/wiki/Levenshtein_distance) heuristic to search titles, and as such is much slower than the other search endpoint. 
Whenever possible, clients should limit the search to the appropriate type. 
Results, as well as their containing per-type hubs, contain a `distance` attribute which can be used to judge result quality.


### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Search.PerformVoiceSearchAsync(
    query: "dead+poop",
    sectionId: 4094.8D,
    limit: 5D
);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Query`                                                                               | *string*                                                                              | :heavy_check_mark:                                                                    | The query term                                                                        | dead+poop                                                                             |
| `SectionId`                                                                           | *double*                                                                              | :heavy_minus_sign:                                                                    | This gives context to the search, and can result in re-ordering of search result hubs |                                                                                       |
| `Limit`                                                                               | *double*                                                                              | :heavy_minus_sign:                                                                    | The number of items to return per hub                                                 | 5                                                                                     |

### Response

**[PerformVoiceSearchResponse](../../Models/Requests/PerformVoiceSearchResponse.md)**

### Errors

| Error Object                                         | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| PlexAPI.Models.Errors.PerformVoiceSearchResponseBody | 401                                                  | application/json                                     |
| PlexAPI.Models.Errors.SDKException                   | 4xx-5xx                                              | */*                                                  |


## GetSearchResults

This will search the database for the string provided.

### Example Usage

```csharp
using PlexAPI;
using PlexAPI.Models.Requests;
using PlexAPI.Models.Components;

var sdk = new PlexAPISDK(
    accessToken: "<YOUR_API_KEY_HERE>",
    xPlexClientIdentifier: "Postman"
);

var res = await sdk.Search.GetSearchResultsAsync(query: "110");

// handle response
```

### Parameters

| Parameter                      | Type                           | Required                       | Description                    | Example                        |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `Query`                        | *string*                       | :heavy_check_mark:             | The search query string to use | 110                            |

### Response

**[GetSearchResultsResponse](../../Models/Requests/GetSearchResultsResponse.md)**

### Errors

| Error Object                                       | Status Code                                        | Content Type                                       |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| PlexAPI.Models.Errors.GetSearchResultsResponseBody | 401                                                | application/json                                   |
| PlexAPI.Models.Errors.SDKException                 | 4xx-5xx                                            | */*                                                |
