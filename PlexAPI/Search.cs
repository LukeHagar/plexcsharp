
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
    /// API Calls that perform search operations with Plex Media Server<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public interface ISearch
    {

        /// <summary>
        /// Perform a search
        /// 
        /// <remarks>
        /// This endpoint performs a search across all library sections, or a single section, and returns matches as hubs, split up by type. It performs spell checking, looks for partial matches, and orders the hubs based on quality of results. In addition, based on matches, it will return other related matches (e.g. for a genre match, it may return movies in that genre, or for an actor match, movies with that actor).<br/>
        /// <br/>
        /// In the response&apos;s items, the following extra attributes are returned to further describe or disambiguate the result:<br/>
        /// <br/>
        /// - `reason`: The reason for the result, if not because of a direct search term match; can be either:<br/>
        ///   - `section`: There are multiple identical results from different sections.<br/>
        ///   - `originalTitle`: There was a search term match from the original title field (sometimes those can be very different or in a foreign language).<br/>
        ///   - `&lt;hub identifier&gt;`: If the reason for the result is due to a result in another hub, the source hub identifier is returned. For example, if the search is for &quot;dylan&quot; then Bob Dylan may be returned as an artist result, an a few of his albums returned as album results with a reason code of `artist` (the identifier of that particular hub). Or if the search is for &quot;arnold&quot;, there might be movie results returned with a reason of `actor`<br/>
        /// - `reasonTitle`: The string associated with the reason code. For a section reason, it&apos;ll be the section name; For a hub identifier, it&apos;ll be a string associated with the match (e.g. `Arnold Schwarzenegger` for movies which were returned because the search was for &quot;arnold&quot;).<br/>
        /// - `reasonID`: The ID of the item associated with the reason for the result. This might be a section ID, a tag ID, an artist ID, or a show ID.<br/>
        /// <br/>
        /// This request is intended to be very fast, and called as the user types.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<PerformSearchResponse> PerformSearchAsync(string query, double? sectionId = null, double? limit = null);

        /// <summary>
        /// Perform a voice search
        /// 
        /// <remarks>
        /// This endpoint performs a search specifically tailored towards voice or other imprecise input which may work badly with the substring and spell-checking heuristics used by the `/hubs/search` endpoint. <br/>
        /// It uses a <a href="https://en.wikipedia.org/wiki/Levenshtein_distance">Levenshtein distance</a> heuristic to search titles, and as such is much slower than the other search endpoint. <br/>
        /// Whenever possible, clients should limit the search to the appropriate type. <br/>
        /// Results, as well as their containing per-type hubs, contain a `distance` attribute which can be used to judge result quality.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<PerformVoiceSearchResponse> PerformVoiceSearchAsync(string query, double? sectionId = null, double? limit = null);

        /// <summary>
        /// Get Search Results
        /// 
        /// <remarks>
        /// This will search the database for the string provided.
        /// </remarks>
        /// </summary>
        Task<GetSearchResultsResponse> GetSearchResultsAsync(string query);
    }

    /// <summary>
    /// API Calls that perform search operations with Plex Media Server<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class Search: ISearch
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.3";
        private const string _sdkGenVersion = "2.237.2";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.3 2.237.2 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Search(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<PerformSearchResponse> PerformSearchAsync(string query, double? sectionId = null, double? limit = null)
        {
            var request = new PerformSearchRequest()
            {
                Query = query,
                SectionId = sectionId,
                Limit = limit,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hubs/search", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PerformSearchResponse
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
                    response.Object = JsonConvert.DeserializeObject<PerformSearchResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<PerformVoiceSearchResponse> PerformVoiceSearchAsync(string query, double? sectionId = null, double? limit = null)
        {
            var request = new PerformVoiceSearchRequest()
            {
                Query = query,
                SectionId = sectionId,
                Limit = limit,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/hubs/search/voice", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new PerformVoiceSearchResponse
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
                    response.Object = JsonConvert.DeserializeObject<PerformVoiceSearchResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetSearchResultsResponse> GetSearchResultsAsync(string query)
        {
            var request = new GetSearchResultsRequest()
            {
                Query = query,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/search", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetSearchResultsResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.TwoHundredApplicationJsonObject = JsonConvert.DeserializeObject<GetSearchResultsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
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
                    response.FourHundredAndOneApplicationJsonObject = JsonConvert.DeserializeObject<GetSearchResultsSearchResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}