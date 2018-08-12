using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PageBlock : Object
        {
            public class PageBlockTitle : PageBlock
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "pageBlockTitle";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public RichText Title { get; set; }
            }
        }
    }
}