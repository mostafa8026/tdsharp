using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class FileType : Object
        {
            public class FileTypeAnimation : FileType
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "fileTypeAnimation";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}