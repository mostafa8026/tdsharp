using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class Wallpaper : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "wallpaper";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("sizes")]
            public PhotoSize[] Sizes { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("color")]
            public int Color { get; set; }
        }
    }
}