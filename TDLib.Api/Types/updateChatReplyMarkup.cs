using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateChatReplyMarkup : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateChatReplyMarkup";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup_message_id")]
                public long reply_markup_message_id_;

        }

    }

}