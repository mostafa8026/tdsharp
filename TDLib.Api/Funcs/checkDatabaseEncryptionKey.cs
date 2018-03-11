using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class checkDatabaseEncryptionKey : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "checkDatabaseEncryptionKey";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("encryption_key")]
                public byte[] encryption_key_;

        }

    }

}