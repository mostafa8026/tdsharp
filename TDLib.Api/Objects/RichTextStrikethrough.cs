using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class RichText : Object
        {
            public class RichTextStrikethrough : RichText
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "richTextStrikethrough";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public RichText Text { get; set; }
            }
        }
    }
}