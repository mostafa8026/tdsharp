using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class NetworkType : Structure
    {

        public partial class networkTypeNone : NetworkType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "networkTypeNone";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}