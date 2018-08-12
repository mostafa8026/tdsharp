using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class CallDiscardReason : Object
        {
            public class CallDiscardReasonDeclined : CallDiscardReason
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "callDiscardReasonDeclined";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}