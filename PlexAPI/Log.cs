
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
    /// Submit logs to the Log Handler for Plex Media Server<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public interface ILog
    {

        /// <summary>
        /// Logging a single line message.
        /// 
        /// <remarks>
        /// This endpoint will write a single-line log message, including a level and source to the main Plex Media Server log.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<LogLineResponse> LogLineAsync(Level level, string message, string source);

        /// <summary>
        /// Logging a multi-line message
        /// 
        /// <remarks>
        /// This endpoint allows for the batch addition of log entries to the main Plex Media Server log.  <br/>
        /// It accepts a text/plain request body, where each line represents a distinct log entry.  <br/>
        /// Each log entry consists of URL-encoded key-value pairs, specifying log attributes such as &apos;level&apos;, &apos;message&apos;, and &apos;source&apos;.  <br/>
        /// <br/>
        /// Log entries are separated by a newline character (`\n`).  <br/>
        /// Each entry&apos;s parameters should be URL-encoded to ensure accurate parsing and handling of special characters.  <br/>
        /// This method is efficient for logging multiple entries in a single API call, reducing the overhead of multiple individual requests.  <br/>
        /// <br/>
        /// The &apos;level&apos; parameter specifies the log entry&apos;s severity or importance, with the following integer values:<br/>
        /// - `0`: Error - Critical issues that require immediate attention.<br/>
        /// - `1`: Warning - Important events that are not critical but may indicate potential issues.<br/>
        /// - `2`: Info - General informational messages about system operation.<br/>
        /// - `3`: Debug - Detailed information useful for debugging purposes.<br/>
        /// - `4`: Verbose - Highly detailed diagnostic information for in-depth analysis.<br/>
        /// <br/>
        /// The &apos;message&apos; parameter contains the log text, and &apos;source&apos; identifies the log message&apos;s origin (e.g., an application name or module).<br/>
        /// <br/>
        /// Example of a single log entry format:<br/>
        /// `level=4&amp;message=Sample%20log%20entry&amp;source=applicationName`<br/>
        /// <br/>
        /// Ensure each parameter is properly URL-encoded to avoid interpretation issues.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<LogMultiLineResponse> LogMultiLineAsync(string request);

        /// <summary>
        /// Enabling Papertrail
        /// 
        /// <remarks>
        /// This endpoint will enable all Plex Media Serverlogs to be sent to the Papertrail networked logging site for a period of time.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<EnablePaperTrailResponse> EnablePaperTrailAsync();
    }

    /// <summary>
    /// Submit logs to the Log Handler for Plex Media Server<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class Log: ILog
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.2.1";
        private const string _sdkGenVersion = "2.281.2";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.2.1 2.281.2 0.0.3 Plex-API";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Log(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<LogLineResponse> LogLineAsync(Level level, string message, string source)
        {
            var request = new LogLineRequest()
            {
                Level = level,
                Message = message,
                Source = source,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/log", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new LogLineResponse
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
                    response.Object = JsonConvert.DeserializeObject<LogLineResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<LogMultiLineResponse> LogMultiLineAsync(string request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/log";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "Request", "string", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new LogMultiLineResponse
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
                    response.Object = JsonConvert.DeserializeObject<LogMultiLineResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }


        public async Task<EnablePaperTrailResponse> EnablePaperTrailAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/log/networked";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new EnablePaperTrailResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200) || (response.StatusCode == 400) || (response.StatusCode == 403))
            {

                return response;
            }

            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<EnablePaperTrailResponseBody>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

    }
}