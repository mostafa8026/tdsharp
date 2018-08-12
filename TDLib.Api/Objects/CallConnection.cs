using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class CallConnection : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "callConnection";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public Int64 Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("ip")]
            public string Ip { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("ipv6")]
            public string Ipv6 { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("port")]
            public int Port { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("peer_tag")]
            public byte[] PeerTag { get; set; }
        }
    }
}