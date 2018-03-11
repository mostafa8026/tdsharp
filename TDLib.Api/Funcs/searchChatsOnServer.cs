using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class searchChatsOnServer : Method<Chats>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "searchChatsOnServer";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("query")]
                public string query_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("limit")]
                public int limit_;

        }

    }

}