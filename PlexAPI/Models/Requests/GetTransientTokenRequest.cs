
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace PlexAPI.Models.Requests
{
    using PlexAPI.Utils;
    
    public class GetTransientTokenRequest
    {

        /// <summary>
        /// `delegation` - This is the only supported `type` parameter.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=type")]
        public QueryParamType Type { get; set; } = default!;

        /// <summary>
        /// `all` - This is the only supported `scope` parameter.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=scope")]
        public Scope Scope { get; set; } = default!;
    }
}