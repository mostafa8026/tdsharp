using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getChatReportSpamState : Method<ChatReportSpamState>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getChatReportSpamState";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

        }

    }

}