using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class OptionValue : Structure
    {

        public partial class optionValueEmpty : OptionValue
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "optionValueEmpty";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}