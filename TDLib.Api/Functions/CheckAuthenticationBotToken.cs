using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class CheckAuthenticationBotToken : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "checkAuthenticationBotToken";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("token")]
            public string Token { get; set; }
        }
    }
}