using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Animations : Structure
    {

        public partial class animations : Animations
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "animations";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("animations")]
                public Animation.animation[] animations_;

        }

    }

}