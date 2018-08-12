using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class ToggleChatIsPinned : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "toggleChatIsPinned";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_pinned")]
            public bool IsPinned { get; set; }
        }
    }
}