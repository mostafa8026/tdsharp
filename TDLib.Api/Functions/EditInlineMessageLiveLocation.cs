using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class EditInlineMessageLiveLocation : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "editInlineMessageLiveLocation";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("inline_message_id")]
            public string InlineMessageId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public Location Location { get; set; }
        }
    }
}