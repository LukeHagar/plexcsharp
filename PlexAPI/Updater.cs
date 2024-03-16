
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
    /// This describes the API for searching and applying updates to the Plex Media Server.<br/>
    /// 
    /// <remarks>
    /// Updates to the status can be observed via the Event API.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public interface IUpdater
    {

        /// <summary>
        /// Querying status of updates
        /// 
        /// <remarks>
        /// Querying status of updates
        /// </remarks>
        /// </summary>
        Task<GetUpdateStatusResponse> GetUpdateStatusAsync();

        /// <summary>
        /// Checking for updates
        /// 
        /// <remarks>
        /// Checking for updates
        /// </remarks>
        /// </summary>
        Task<CheckForUpdatesResponse> CheckForUpdatesAsync(Download? download = null);

        /// <summary>
        /// Apply Updates
        /// 
        /// <remarks>
        /// Note that these two parameters are effectively mutually exclusive. The `tonight` parameter takes precedence and `skip` will be ignored if `tonight` is also passed<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<ApplyUpdatesResponse> ApplyUpdatesAsync(Tonight? tonight = null, Skip? skip = null);
    }

    /// <summary>
    /// This describes the API for searching and applying updates to the Plex Media Server.<br/>
    /// 
    /// <remarks>
    /// Updates to the status can be observed via the Event API.<br/>
    /// 
    /// </remarks>
    /// </summary>
    public class Updater: IUpdater
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.0";
        private const string _sdkGenVersion = "2.281.2";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.0 2.281.2 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Updater(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetUpdateStatusResponse> GetUpdateStatusAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/updater/status";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new GetUpdateStatusResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetUpdateStatusResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetUpdateStatusUpdaterResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<CheckForUpdatesResponse> CheckForUpdatesAsync(Download? download = null)
        {
            var request = new CheckForUpdatesRequest()
            {
                Download = download,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/updater/check", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new CheckForUpdatesResponse
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
                    response.Object = JsonConvert.DeserializeObject<CheckForUpdatesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<ApplyUpdatesResponse> ApplyUpdatesAsync(Tonight? tonight = null, Skip? skip = null)
        {
            var request = new ApplyUpdatesRequest()
            {
                Tonight = tonight,
                Skip = skip,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/updater/apply", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new ApplyUpdatesResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200) || (response.StatusCode == 400) || (response.StatusCode == 500))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<ApplyUpdatesResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

    }
}