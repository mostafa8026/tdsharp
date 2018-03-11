using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthenticationCodeInfo : Structure
    {

        public partial class authenticationCodeInfo : AuthenticationCodeInfo
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "authenticationCodeInfo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("type")]
                public AuthenticationCodeType type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("next_type")]
                public AuthenticationCodeType next_type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("timeout")]
                public int timeout_;

        }

    }

}