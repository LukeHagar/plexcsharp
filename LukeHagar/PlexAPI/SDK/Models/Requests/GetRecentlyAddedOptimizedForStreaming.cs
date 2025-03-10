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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class GetRecentlyAddedOptimizedForStreamingType
    {
        private GetRecentlyAddedOptimizedForStreamingType(string value) { Value = value; }

        public string Value { get; private set; }
        public static GetRecentlyAddedOptimizedForStreamingType GetRecentlyAddedOptimizedForStreaming1 { get { return new GetRecentlyAddedOptimizedForStreamingType("get-recently-added_optimizedForStreaming_1"); } }
        
        public static GetRecentlyAddedOptimizedForStreamingType Boolean { get { return new GetRecentlyAddedOptimizedForStreamingType("boolean"); } }
        
        public static GetRecentlyAddedOptimizedForStreamingType Null { get { return new GetRecentlyAddedOptimizedForStreamingType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(GetRecentlyAddedOptimizedForStreamingType v) { return v.Value; }
        public static GetRecentlyAddedOptimizedForStreamingType FromString(string v) {
            switch(v) {
                case "get-recently-added_optimizedForStreaming_1": return GetRecentlyAddedOptimizedForStreaming1;
                case "boolean": return Boolean;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for GetRecentlyAddedOptimizedForStreamingType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((GetRecentlyAddedOptimizedForStreamingType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// Has this media been optimized for streaming. NOTE: This can be 0, 1, false or true
    /// </summary>
    [JsonConverter(typeof(GetRecentlyAddedOptimizedForStreaming.GetRecentlyAddedOptimizedForStreamingConverter))]
    public class GetRecentlyAddedOptimizedForStreaming {
        public GetRecentlyAddedOptimizedForStreaming(GetRecentlyAddedOptimizedForStreamingType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public GetRecentlyAddedOptimizedForStreaming1? GetRecentlyAddedOptimizedForStreaming1 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        public GetRecentlyAddedOptimizedForStreamingType Type { get; set; }


        public static GetRecentlyAddedOptimizedForStreaming CreateGetRecentlyAddedOptimizedForStreaming1(GetRecentlyAddedOptimizedForStreaming1 getRecentlyAddedOptimizedForStreaming1) {
            GetRecentlyAddedOptimizedForStreamingType typ = GetRecentlyAddedOptimizedForStreamingType.GetRecentlyAddedOptimizedForStreaming1;

            GetRecentlyAddedOptimizedForStreaming res = new GetRecentlyAddedOptimizedForStreaming(typ);
            res.GetRecentlyAddedOptimizedForStreaming1 = getRecentlyAddedOptimizedForStreaming1;
            return res;
        }

        public static GetRecentlyAddedOptimizedForStreaming CreateBoolean(bool boolean) {
            GetRecentlyAddedOptimizedForStreamingType typ = GetRecentlyAddedOptimizedForStreamingType.Boolean;

            GetRecentlyAddedOptimizedForStreaming res = new GetRecentlyAddedOptimizedForStreaming(typ);
            res.Boolean = boolean;
            return res;
        }

        public static GetRecentlyAddedOptimizedForStreaming CreateNull() {
            GetRecentlyAddedOptimizedForStreamingType typ = GetRecentlyAddedOptimizedForStreamingType.Null;
            return new GetRecentlyAddedOptimizedForStreaming(typ);
        }

        public class GetRecentlyAddedOptimizedForStreamingConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(GetRecentlyAddedOptimizedForStreaming);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new GetRecentlyAddedOptimizedForStreaming(GetRecentlyAddedOptimizedForStreamingType.GetRecentlyAddedOptimizedForStreaming1)
                    {
                        GetRecentlyAddedOptimizedForStreaming1 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<GetRecentlyAddedOptimizedForStreaming1>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(GetRecentlyAddedOptimizedForStreaming1), new GetRecentlyAddedOptimizedForStreaming(GetRecentlyAddedOptimizedForStreamingType.GetRecentlyAddedOptimizedForStreaming1), "GetRecentlyAddedOptimizedForStreaming1"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    var converted = Convert.ToBoolean(json);
                    return new GetRecentlyAddedOptimizedForStreaming(GetRecentlyAddedOptimizedForStreamingType.Boolean)
                    {
                        Boolean = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                GetRecentlyAddedOptimizedForStreaming res = (GetRecentlyAddedOptimizedForStreaming)value;
                if (GetRecentlyAddedOptimizedForStreamingType.FromString(res.Type).Equals(GetRecentlyAddedOptimizedForStreamingType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.GetRecentlyAddedOptimizedForStreaming1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.GetRecentlyAddedOptimizedForStreaming1));
                    return;
                }
                if (res.Boolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Boolean));
                    return;
                }

            }

        }

    }
}