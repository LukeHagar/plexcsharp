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
    using LukeHagar.PlexAPI.SDK.Utils.Retries;
    using LukeHagar.PlexAPI.SDK.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// API Calls regarding authentication for Plex Media Server<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public interface IAuthentication
    {

        /// <summary>
        /// Get a Transient Token.
        /// 
        /// <remarks>
        /// This endpoint provides the caller with a temporary token with the same access level as the caller&apos;s token. These tokens are valid for up to 48 hours and are destroyed if the server instance is restarted.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetTransientTokenResponse> GetTransientTokenAsync(GetTransientTokenQueryParamType type, Scope scope);

        /// <summary>
        /// Get Source Connection Information
        /// 
        /// <remarks>
        /// If a caller requires connection details and a transient token for a source that is known to the server, for example a cloud media provider or shared PMS, then this endpoint can be called. This endpoint is only accessible with either an admin token or a valid transient token generated from an admin token.<br/>
        /// Note: requires Plex Media Server &gt;= 1.15.4.<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetSourceConnectionInformationResponse> GetSourceConnectionInformationAsync(string source);

        /// <summary>
        /// Get User Data By Token
        /// 
        /// <remarks>
        /// Get the User data from the provided X-Plex-Token
        /// </remarks>
        /// </summary>
        Task<GetUserDetailsResponse> GetUserDetailsAsync(string xPlexToken, string? serverUrl = null);

        /// <summary>
        /// Get User Sign In Data
        /// 
        /// <remarks>
        /// Sign in user with username and password and return user data with Plex authentication token
        /// </remarks>
        /// </summary>
        Task<PostUsersSignInDataResponse> PostUsersSignInDataAsync(string? xPlexClientIdentifier = null, PostUsersSignInDataRequestBody? requestBody = null, string? serverUrl = null);
    }

    /// <summary>
    /// API Calls regarding authentication for Plex Media Server<br/>
    /// 
    /// <remarks>
    /// 
    /// </remarks>
    /// </summary>
    public class Authentication: IAuthentication
    {
        /// <summary>
        /// List of server URLs available for the getUserDetails operation.
        /// </summary>
        public static readonly string[] GetUserDetailsServerList = {
            "https://plex.tv/api/v2/",
        };
        /// <summary>
        /// List of server URLs available for the post-users-sign-in-data operation.
        /// </summary>
        public static readonly string[] PostUsersSignInDataServerList = {
            "https://plex.tv/api/v2/",
        };
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.6.0";
        private const string _sdkGenVersion = "2.411.9";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.6.0 2.411.9 0.0.3 LukeHagar.PlexAPI.SDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<LukeHagar.PlexAPI.SDK.Models.Components.Security>? _securitySource;

        public Authentication(ISpeakeasyHttpClient client, Func<LukeHagar.PlexAPI.SDK.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetTransientTokenResponse> GetTransientTokenAsync(GetTransientTokenQueryParamType type, Scope scope)
        {
            var request = new GetTransientTokenRequest()
            {
                Type = type,
                Scope = scope,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/security/token", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("getTransientToken", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
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
                return new GetTransientTokenResponse()
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
                    var obj = ResponseBodyDeserializer.Deserialize<GetTransientTokenResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetTransientTokenAuthenticationResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<GetSourceConnectionInformationResponse> GetSourceConnectionInformationAsync(string source)
        {
            var request = new GetSourceConnectionInformationRequest()
            {
                Source = source,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/security/resources", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("getSourceConnectionInformation", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
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
                return new GetSourceConnectionInformationResponse()
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
                    var obj = ResponseBodyDeserializer.Deserialize<GetSourceConnectionInformationResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetSourceConnectionInformationAuthenticationResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<GetUserDetailsResponse> GetUserDetailsAsync(string xPlexToken, string? serverUrl = null)
        {
            var request = new GetUserDetailsRequest()
            {
                XPlexToken = xPlexToken,
            };
            string baseUrl = Utilities.TemplateUrl(GetUserDetailsServerList[0], new Dictionary<string, string>(){
            });
            if (serverUrl != null)
            {
                baseUrl = serverUrl;
            }
            var urlString = URLBuilder.Build(baseUrl, "/user", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("getUserDetails", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<GetUserDetailsUserPlexAccount>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetUserDetailsResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.UserPlexAccount = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetUserDetailsResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<GetUserDetailsAuthenticationResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<PostUsersSignInDataResponse> PostUsersSignInDataAsync(string? xPlexClientIdentifier = null, PostUsersSignInDataRequestBody? requestBody = null, string? serverUrl = null)
        {
            var request = new PostUsersSignInDataRequest()
            {
                XPlexClientIdentifier = xPlexClientIdentifier,
                RequestBody = requestBody,
            };
            request.XPlexClientIdentifier ??= SDKConfiguration.XPlexClientIdentifier;
            
            string baseUrl = Utilities.TemplateUrl(PostUsersSignInDataServerList[0], new Dictionary<string, string>(){
            });
            if (serverUrl != null)
            {
                baseUrl = serverUrl;
            }
            var urlString = URLBuilder.Build(baseUrl, "/users/signin", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "form", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var hookCtx = new HookContext("post-users-sign-in-data", null, null);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
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
            if(responseStatusCode == 201)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<PostUsersSignInDataUserPlexAccount>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PostUsersSignInDataResponse()
                    {
                        StatusCode = responseStatusCode,
                        ContentType = contentType,
                        RawResponse = httpResponse
                    };
                    response.UserPlexAccount = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 400)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<PostUsersSignInDataResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode == 401)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<PostUsersSignInDataAuthenticationResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    obj!.RawResponse = httpResponse;
                    throw obj!;
                }
                else
                {
                    throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }
            }
            else if(responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }
    }
}