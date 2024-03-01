
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI
{
    using Newtonsoft.Json;
    using PlexAPI.Models.Components;
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Playlists are ordered collections of media. They can be dumb (just a list of media) or smart (based on a media query, such as &quot;all albums from 2017&quot;). <br/>
    /// 
    /// <remarks>
    /// They can be organized in (optionally nesting) folders.<br/>
    /// Retrieving a playlist, or its items, will trigger a refresh of its metadata. <br/>
    /// This may cause the duration and number of items to change.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public interface IPlaylists
    {

        /// <summary>
        /// Create a Playlist
        /// 
        /// <remarks>
        /// Create a new playlist. By default the playlist is blank. To create a playlist along with a first item, pass:<br/>
        /// - `uri` - The content URI for what we&apos;re playing (e.g. `server://1234/com.plexapp.plugins.library/library/metadata/1`).<br/>
        /// - `playQueueID` - To create a playlist from an existing play queue.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<CreatePlaylistResponse> CreatePlaylistAsync(CreatePlaylistRequest request);

        /// <summary>
        /// Get All Playlists
        /// 
        /// <remarks>
        /// Get All Playlists given the specified filters.
        /// </remarks>
        /// </summary>
        Task<GetPlaylistsResponse> GetPlaylistsAsync(PlaylistType? playlistType = null, QueryParamSmart? smart = null);

        /// <summary>
        /// Retrieve Playlist
        /// 
        /// <remarks>
        /// Gets detailed metadata for a playlist. A playlist for many purposes (rating, editing metadata, tagging), can be treated like a regular metadata item:<br/>
        /// Smart playlist details contain the `content` attribute. This is the content URI for the generator. This can then be parsed by a client to provide smart playlist editing.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetPlaylistResponse> GetPlaylistAsync(double playlistID);

        /// <summary>
        /// Deletes a Playlist
        /// 
        /// <remarks>
        /// This endpoint will delete a playlist<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<DeletePlaylistResponse> DeletePlaylistAsync(double playlistID);

        /// <summary>
        /// Update a Playlist
        /// 
        /// <remarks>
        /// From PMS version 1.9.1 clients can also edit playlist metadata using this endpoint as they would via `PUT /library/metadata/{playlistID}`<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<UpdatePlaylistResponse> UpdatePlaylistAsync(double playlistID, string? title = null, string? summary = null);

        /// <summary>
        /// Retrieve Playlist Contents
        /// 
        /// <remarks>
        /// Gets the contents of a playlist. Should be paged by clients via standard mechanisms. <br/>
        /// By default leaves are returned (e.g. episodes, movies). In order to return other types you can use the `type` parameter. <br/>
        /// For example, you could use this to display a list of recently added albums vis a smart playlist. <br/>
        /// Note that for dumb playlists, items have a `playlistItemID` attribute which is used for deleting or moving items.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetPlaylistContentsResponse> GetPlaylistContentsAsync(double playlistID, double type);

        /// <summary>
        /// Delete Playlist Contents
        /// 
        /// <remarks>
        /// Clears a playlist, only works with dumb playlists. Returns the playlist.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<ClearPlaylistContentsResponse> ClearPlaylistContentsAsync(double playlistID);

        /// <summary>
        /// Adding to a Playlist
        /// 
        /// <remarks>
        /// Adds a generator to a playlist, same parameters as the POST to create. With a dumb playlist, this adds the specified items to the playlist.<br/>
        /// With a smart playlist, passing a new `uri` parameter replaces the rules for the playlist. Returns the playlist.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<AddPlaylistContentsResponse> AddPlaylistContentsAsync(double playlistID, string uri, double? playQueueID = null);

        /// <summary>
        /// Upload Playlist
        /// 
        /// <remarks>
        /// Imports m3u playlists by passing a path on the server to scan for m3u-formatted playlist files, or a path to a single playlist file.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<UploadPlaylistResponse> UploadPlaylistAsync(string path, Force force);
    }

    /// <summary>
    /// Playlists are ordered collections of media. They can be dumb (just a list of media) or smart (based on a media query, such as &quot;all albums from 2017&quot;). <br/>
    /// 
    /// <remarks>
    /// They can be organized in (optionally nesting) folders.<br/>
    /// Retrieving a playlist, or its items, will trigger a refresh of its metadata. <br/>
    /// This may cause the duration and number of items to change.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class Playlists: IPlaylists
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.0";
        private const string _sdkGenVersion = "2.275.4";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.0 2.275.4 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Playlists(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreatePlaylistResponse> CreatePlaylistAsync(CreatePlaylistRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CreatePlaylistResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<CreatePlaylistResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }

            if((response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<CreatePlaylistPlaylistsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetPlaylistsResponse> GetPlaylistsAsync(PlaylistType? playlistType = null, QueryParamSmart? smart = null)
        {
            var request = new GetPlaylistsRequest()
            {
                PlaylistType = playlistType,
                Smart = smart,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetPlaylistsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetPlaylistsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }

            if((response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetPlaylistsPlaylistsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetPlaylistResponse> GetPlaylistAsync(double playlistID)
        {
            var request = new GetPlaylistRequest()
            {
                PlaylistID = playlistID,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists/{playlistID}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetPlaylistResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetPlaylistResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }

            if((response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetPlaylistPlaylistsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<DeletePlaylistResponse> DeletePlaylistAsync(double playlistID)
        {
            var request = new DeletePlaylistRequest()
            {
                PlaylistID = playlistID,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists/{playlistID}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new DeletePlaylistResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200) || (response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<DeletePlaylistResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<UpdatePlaylistResponse> UpdatePlaylistAsync(double playlistID, string? title = null, string? summary = null)
        {
            var request = new UpdatePlaylistRequest()
            {
                PlaylistID = playlistID,
                Title = title,
                Summary = summary,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists/{playlistID}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UpdatePlaylistResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200) || (response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<UpdatePlaylistResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<GetPlaylistContentsResponse> GetPlaylistContentsAsync(double playlistID, double type)
        {
            var request = new GetPlaylistContentsRequest()
            {
                PlaylistID = playlistID,
                Type = type,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists/{playlistID}/items", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetPlaylistContentsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetPlaylistContentsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }

            if((response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetPlaylistContentsPlaylistsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<ClearPlaylistContentsResponse> ClearPlaylistContentsAsync(double playlistID)
        {
            var request = new ClearPlaylistContentsRequest()
            {
                PlaylistID = playlistID,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists/{playlistID}/items", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ClearPlaylistContentsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200) || (response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<ClearPlaylistContentsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<AddPlaylistContentsResponse> AddPlaylistContentsAsync(double playlistID, string uri, double? playQueueID = null)
        {
            var request = new AddPlaylistContentsRequest()
            {
                PlaylistID = playlistID,
                Uri = uri,
                PlayQueueID = playQueueID,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists/{playlistID}/items", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new AddPlaylistContentsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<AddPlaylistContentsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }

            if((response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<AddPlaylistContentsPlaylistsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        public async Task<UploadPlaylistResponse> UploadPlaylistAsync(string path, Force force)
        {
            var request = new UploadPlaylistRequest()
            {
                Path = path,
                Force = force,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/playlists/upload", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new UploadPlaylistResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200) || (response.StatusCode == 400))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<UploadPlaylistResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}