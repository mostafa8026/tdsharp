using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class searchSecretMessages : Method<FoundMessages>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "searchSecretMessages";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("query")]
                public string query_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("from_search_id")]
                public string from_search_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("limit")]
                public int limit_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("filter")]
                public SearchMessagesFilter filter_;

        }

    }

}