using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class DeleteAccount : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "deleteAccount";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("reason")]
            public string Reason { get; set; }
        }
    }
}