using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class searchCallMessages : Method<Messages>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "searchCallMessages";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("from_message_id")]
                public long from_message_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("limit")]
                public int limit_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("only_missed")]
                public bool only_missed_;

        }

    }

}