using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class ConnectedWebsite : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "connectedWebsite";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public Int64 Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("domain_name")]
            public string DomainName { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public int BotUserId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("browser")]
            public string Browser { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("platform")]
            public string Platform { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("log_in_date")]
            public int LogInDate { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_active_date")]
            public int LastActiveDate { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("ip")]
            public string Ip { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public string Location { get; set; }
        }
    }
}