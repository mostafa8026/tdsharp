using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class createTemporaryPassword : Method<TemporaryPasswordState>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "createTemporaryPassword";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("password")]
                public string password_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("valid_for")]
                public int valid_for_;

        }

    }

}