using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class File : Structure
    {

        public partial class file : File
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "file";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public int id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("size")]
                public int size_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("expected_size")]
                public int expected_size_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("local")]
                public LocalFile.localFile local_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("remote")]
                public RemoteFile.remoteFile remote_;

        }

    }

}