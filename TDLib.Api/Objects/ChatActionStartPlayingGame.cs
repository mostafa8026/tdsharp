using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatAction : Object
        {
            public class ChatActionStartPlayingGame : ChatAction
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatActionStartPlayingGame";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}