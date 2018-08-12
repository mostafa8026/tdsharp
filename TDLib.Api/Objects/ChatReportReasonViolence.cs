using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatReportReason : Object
        {
            public class ChatReportReasonViolence : ChatReportReason
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatReportReasonViolence";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}