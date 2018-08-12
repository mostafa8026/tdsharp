using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class RequestAuthenticationPasswordRecovery : Function<Ok>
        {
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "requestAuthenticationPasswordRecovery";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}