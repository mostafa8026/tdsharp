using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetUser : Function<User>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getUser";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }
        }
    }
}