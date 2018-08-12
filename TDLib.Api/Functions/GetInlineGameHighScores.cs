using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetInlineGameHighScores : Function<GameHighScores>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getInlineGameHighScores";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("inline_message_id")]
            public string InlineMessageId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }
        }
    }
}