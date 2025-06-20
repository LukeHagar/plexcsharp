//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace LukeHagar.PlexAPI.SDK
{
    using LukeHagar.PlexAPI.SDK.Hooks;
    using LukeHagar.PlexAPI.SDK.Models.Components;
    using LukeHagar.PlexAPI.SDK.Models.Errors;
    using LukeHagar.PlexAPI.SDK.Models.Requests;
    using LukeHagar.PlexAPI.SDK.Utils;
    using LukeHagar.PlexAPI.SDK.Utils.Retries;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

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
        private const string _sdkVersion = "0.15.1";
        private const string _sdkGenVersion = "2.623.0";
        private const string _openapiDocVersion = "0.0.3";

        public Updater(SDKConfig config)
        {
            SDKConfiguration = config;
        }

        public async Task<GetUpdateStatusResponse> GetUpdateStatusAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/updater/status";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "getUpdateStatus", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetUpdateStatusResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetUpdateStatusResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.Object = obj;
                    return response;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetUpdateStatusBadRequest>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetUpdateStatusUnauthorized>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<CheckForUpdatesResponse> CheckForUpdatesAsync(Download? download = null)
        {
            var request = new CheckForUpdatesRequest()
            {
                Download = download,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/updater/check", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "checkForUpdates", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {                
                return new CheckForUpdatesResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<CheckForUpdatesBadRequest>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<CheckForUpdatesUnauthorized>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<ApplyUpdatesResponse> ApplyUpdatesAsync(Tonight? tonight = null, Skip? skip = null)
        {
            var request = new ApplyUpdatesRequest()
            {
                Tonight = tonight,
                Skip = skip,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/updater/apply", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", SDKConfiguration.UserAgent);

            if (SDKConfiguration.SecuritySource != null)
            {
                httpRequest = new SecurityMetadata(SDKConfiguration.SecuritySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(SDKConfiguration, baseUrl, "applyUpdates", new List<string> {  }, SDKConfiguration.SecuritySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await SDKConfiguration.Client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode == 401 || _statusCode >= 400 && _statusCode < 500 || _statusCode == 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {                
                return new ApplyUpdatesResponse()
                {
                    StatusCode = responseStatusCode,
                    ContentType = contentType,
                    RawResponse = httpResponse
                };
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ApplyUpdatesBadRequest>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ApplyUpdatesUnauthorized>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }
    }
}