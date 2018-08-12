using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputCredentials : Object
        {
            public class InputCredentialsApplePay : InputCredentials
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "inputCredentialsApplePay";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("data")]
                public string Data { get; set; }
            }
        }
    }
}