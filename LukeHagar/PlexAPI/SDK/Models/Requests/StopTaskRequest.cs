//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace LukeHagar.PlexAPI.SDK.Models.Requests
{
    using LukeHagar.PlexAPI.SDK.Models.Requests;
    using LukeHagar.PlexAPI.SDK.Utils;
    
    public class StopTaskRequest
    {

        /// <summary>
        /// The name of the task to be started.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=taskName")]
        public PathParamTaskName TaskName { get; set; } = default!;
    }
}