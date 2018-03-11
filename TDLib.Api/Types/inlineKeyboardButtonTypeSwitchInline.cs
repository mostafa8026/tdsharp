using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InlineKeyboardButtonType : Structure
    {

        public partial class inlineKeyboardButtonTypeSwitchInline : InlineKeyboardButtonType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inlineKeyboardButtonTypeSwitchInline";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("query")]
                public string query_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("in_current_chat")]
                public bool in_current_chat_;

        }

    }

}