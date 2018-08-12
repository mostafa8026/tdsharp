using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class LocalFile : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "localFile";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("path")]
            public string Path { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_downloaded")]
            public bool CanBeDownloaded { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_deleted")]
            public bool CanBeDeleted { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_downloading_active")]
            public bool IsDownloadingActive { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_downloading_completed")]
            public bool IsDownloadingCompleted { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("downloaded_prefix_size")]
            public int DownloadedPrefixSize { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("downloaded_size")]
            public int DownloadedSize { get; set; }
        }
    }
}