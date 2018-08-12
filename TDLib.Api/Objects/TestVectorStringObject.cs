using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class TestVectorStringObject : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "testVectorStringObject";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("value")]
            public TestString[] Value { get; set; }
        }
    }
}