//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI
{
    using Newtonsoft.Json;
    using PlexAPI.Hooks;
    using PlexAPI.Models.Components;
    using PlexAPI.Models.Errors;
    using PlexAPI.Utils.Retries;
    using PlexAPI.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;


    public enum ServerProtocol
    {
        [JsonProperty("http")]
        Http,
        [JsonProperty("https")]
        Https,
    }

    public static class ServerProtocolExtension
    {
        public static string Value(this ServerProtocol value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServerProtocol ToEnum(this string value)
        {
            foreach(var field in typeof(ServerProtocol).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ServerProtocol)
                    {
                        return (ServerProtocol)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServerProtocol");
        }
    }

    /// <summary>
    /// Plex-API: An Open API Spec for interacting with Plex.tv
    /// </summary>
    public interface IPlexAPISDK
    {

        /// <summary>
        /// Operations against the Plex Media Server System.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IServer Server { get; }

        /// <summary>
        /// API Calls interacting with Plex Media Server Media<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IMedia Media { get; }

        /// <summary>
        /// API Calls that perform operations with Plex Media Server Videos<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IVideo Video { get; }

        /// <summary>
        /// Activities are awesome. They provide a way to monitor and control asynchronous operations on the server. In order to receive real-time updates for activities, a client would normally subscribe via either EventSource or Websocket endpoints.<br/>
        /// 
        /// <remarks>
        /// Activities are associated with HTTP replies via a special `X-Plex-Activity` header which contains the UUID of the activity.<br/>
        /// Activities are optional cancellable. If cancellable, they may be cancelled via the `DELETE` endpoint. Other details:<br/>
        /// - They can contain a `progress` (from 0 to 100) marking the percent completion of the activity.<br/>
        /// - They must contain an `type` which is used by clients to distinguish the specific activity.<br/>
        /// - They may contain a `Context` object with attributes which associate the activity with various specific entities (items, libraries, etc.)<br/>
        /// - The may contain a `Response` object which attributes which represent the result of the asynchronous operation.<br/>
        /// 
        /// </remarks>
        /// </summary>
        public IActivities Activities { get; }

        /// <summary>
        /// Butler is the task manager of the Plex Media Server Ecosystem.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IButler Butler { get; }

        /// <summary>
        /// API Calls that perform operations directly against https://Plex.tv<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IPlex Plex { get; }

        /// <summary>
        /// Hubs are a structured two-dimensional container for media, generally represented by multiple horizontal rows.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IHubs Hubs { get; }

        /// <summary>
        /// API Calls that perform search operations with Plex Media Server<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ISearch Search { get; }

        /// <summary>
        /// API Calls interacting with Plex Media Server Libraries<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ILibrary Library { get; }

        /// <summary>
        /// Submit logs to the Log Handler for Plex Media Server<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ILog Log { get; }

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
        public IPlaylists Playlists { get; }

        /// <summary>
        /// API Calls regarding authentication for Plex Media Server<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IAuthentication Authentication { get; }

        /// <summary>
        /// API Calls that perform operations with Plex Media Server Statistics<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IStatistics Statistics { get; }

        /// <summary>
        /// API Calls that perform search operations with Plex Media Server Sessions<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public ISessions Sessions { get; }

        /// <summary>
        /// This describes the API for searching and applying updates to the Plex Media Server.<br/>
        /// 
        /// <remarks>
        /// Updates to the status can be observed via the Event API.<br/>
        /// 
        /// </remarks>
        /// </summary>
        public IUpdater Updater { get; }

        /// <summary>
        /// API Calls that perform operations with Plex Media Server Users<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IUser User { get; }

        /// <summary>
        /// API Calls that perform operations with Plex Media Server Watchlists<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        public IWatchlist Watchlist { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "{protocol}://{ip}:{port}",
        };

        public string ServerUrl = "";
        public int ServerIndex = 0;
        public List<Dictionary<string, string>> ServerDefaults = new List<Dictionary<string, string>>();
        public string? XPlexClientIdentifier;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], this.ServerDefaults[this.ServerIndex]);
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Plex-API: An Open API Spec for interacting with Plex.tv
    /// </summary>
    public class PlexAPISDK: IPlexAPISDK
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.4.1";
        private const string _sdkGenVersion = "2.404.3";
        private const string _openapiDocVersion = "0.0.3";
        private const string _userAgent = "speakeasy-sdk/csharp 0.4.1 2.404.3 0.0.3 PlexAPI";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _client;
        private Func<PlexAPI.Models.Components.Security>? _securitySource;
        public IServer Server { get; private set; }
        public IMedia Media { get; private set; }
        public IVideo Video { get; private set; }
        public IActivities Activities { get; private set; }
        public IButler Butler { get; private set; }
        public IPlex Plex { get; private set; }
        public IHubs Hubs { get; private set; }
        public ISearch Search { get; private set; }
        public ILibrary Library { get; private set; }
        public ILog Log { get; private set; }
        public IPlaylists Playlists { get; private set; }
        public IAuthentication Authentication { get; private set; }
        public IStatistics Statistics { get; private set; }
        public ISessions Sessions { get; private set; }
        public IUpdater Updater { get; private set; }
        public IUser User { get; private set; }
        public IWatchlist Watchlist { get; private set; }

        public PlexAPISDK(string? accessToken = null, Func<string>? accessTokenSource = null, string? xPlexClientIdentifier = null, int? serverIndex = null, ServerProtocol? protocol = null, string?  ip = null, string?  port = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }
            List<Dictionary<string, string>> serverDefaults = new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>()
                {
                    {"protocol", protocol == null ? "http" : ServerProtocolExtension.Value(protocol.Value)},
                    {"ip", ip == null ? "10.10.10.47" : ip},
                    {"port", port == null ? "32400" : port},
                },
            };

            _client = client ?? new SpeakeasyHttpClient();

            if(accessTokenSource != null)
            {
                _securitySource = () => new PlexAPI.Models.Components.Security() { AccessToken = accessTokenSource() };
            }
            else if(accessToken != null)
            {
                _securitySource = () => new PlexAPI.Models.Components.Security() { AccessToken = accessToken };
            }

            SDKConfiguration = new SDKConfig()
            {
                XPlexClientIdentifier = xPlexClientIdentifier,
                ServerDefaults = serverDefaults,
                ServerIndex = _serverIndex,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _client = SDKConfiguration.InitHooks(_client);


            Server = new Server(_client, _securitySource, _serverUrl, SDKConfiguration);


            Media = new Media(_client, _securitySource, _serverUrl, SDKConfiguration);


            Video = new Video(_client, _securitySource, _serverUrl, SDKConfiguration);


            Activities = new Activities(_client, _securitySource, _serverUrl, SDKConfiguration);


            Butler = new Butler(_client, _securitySource, _serverUrl, SDKConfiguration);


            Plex = new Plex(_client, _securitySource, _serverUrl, SDKConfiguration);


            Hubs = new Hubs(_client, _securitySource, _serverUrl, SDKConfiguration);


            Search = new Search(_client, _securitySource, _serverUrl, SDKConfiguration);


            Library = new Library(_client, _securitySource, _serverUrl, SDKConfiguration);


            Log = new Log(_client, _securitySource, _serverUrl, SDKConfiguration);


            Playlists = new Playlists(_client, _securitySource, _serverUrl, SDKConfiguration);


            Authentication = new Authentication(_client, _securitySource, _serverUrl, SDKConfiguration);


            Statistics = new Statistics(_client, _securitySource, _serverUrl, SDKConfiguration);


            Sessions = new Sessions(_client, _securitySource, _serverUrl, SDKConfiguration);


            Updater = new Updater(_client, _securitySource, _serverUrl, SDKConfiguration);


            User = new User(_client, _securitySource, _serverUrl, SDKConfiguration);


            Watchlist = new Watchlist(_client, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}