using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class CallId : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "callId";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }
        }
    }
}