using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventAction : Structure
    {

        public partial class chatEventMemberRestricted : ChatEventAction
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatEventMemberRestricted";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int user_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_status")]
                public ChatMemberStatus old_status_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_status")]
                public ChatMemberStatus new_status_;

        }

    }

}