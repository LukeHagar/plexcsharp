
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
    using PlexAPI.Models.Requests;
    using PlexAPI.Utils;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// API Calls that perform search operations with Plex Media Server Sessions<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public interface ISessions
    {

        /// <summary>
        /// Get Active Sessions
        /// 
        /// <remarks>
        /// This will retrieve the &quot;Now Playing&quot; Information of the PMS.
        /// </remarks>
        /// </summary>
        Task<GetSessionsResponse> GetSessionsAsync();

        /// <summary>
        /// Get Session History
        /// 
        /// <remarks>
        /// This will Retrieve a listing of all history views.
        /// </remarks>
        /// </summary>
        Task<GetSessionHistoryResponse> GetSessionHistoryAsync();

        /// <summary>
        /// Get Transcode Sessions
        /// 
        /// <remarks>
        /// Get Transcode Sessions
        /// </remarks>
        /// </summary>
        Task<GetTranscodeSessionsResponse> GetTranscodeSessionsAsync();

        /// <summary>
        /// Stop a Transcode Session
        /// 
        /// <remarks>
        /// Stop a Transcode Session
        /// </remarks>
        /// </summary>
        Task<StopTranscodeSessionResponse> StopTranscodeSessionAsync(string sessionKey);
    }

    /// <summary>
    /// API Calls that perform search operations with Plex Media Server Sessions<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class Sessions: ISessions
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.223.3";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.223.3 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Sessions(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetSessionsResponse> GetSessionsAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/status/sessions";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetSessionsResponse
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
                    response.Object = JsonConvert.DeserializeObject<GetSessionsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetSessionHistoryResponse> GetSessionHistoryAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/status/sessions/history/all";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetSessionHistoryResponse
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
                    response.Object = JsonConvert.DeserializeObject<GetSessionHistoryResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetTranscodeSessionsResponse> GetTranscodeSessionsAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = baseUrl + "/transcode/sessions";
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetTranscodeSessionsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetTranscodeSessionsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetTranscodeSessionsSessionsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<StopTranscodeSessionResponse> StopTranscodeSessionAsync(string sessionKey)
        {
            var request = new StopTranscodeSessionRequest()
            {
                SessionKey = sessionKey,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/transcode/sessions/{sessionKey}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new StopTranscodeSessionResponse
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
                    response.Object = JsonConvert.DeserializeObject<StopTranscodeSessionResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}