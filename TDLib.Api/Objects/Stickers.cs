using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class Stickers : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "stickers";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("stickers")]
            public Sticker[] Stickers_ { get; set; }
        }
    }
}