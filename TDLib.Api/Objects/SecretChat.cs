using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SecretChat : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "secretChat";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("state")]
            public SecretChatState State { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_outbound")]
            public bool IsOutbound { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("ttl")]
            public int Ttl { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("key_hash")]
            public byte[] KeyHash { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("layer")]
            public int Layer { get; set; }
        }
    }
}