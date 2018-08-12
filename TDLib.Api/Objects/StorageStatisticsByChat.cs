using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class StorageStatisticsByChat : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "storageStatisticsByChat";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("size")]
            public long Size { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("by_file_type")]
            public StorageStatisticsByFileType[] ByFileType { get; set; }
        }
    }
}