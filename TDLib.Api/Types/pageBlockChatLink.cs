using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PageBlock : Structure
    {

        public partial class pageBlockChatLink : PageBlock
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "pageBlockChatLink";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public ChatPhoto.chatPhoto photo_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("username")]
                public string username_;

        }

    }

}