using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// A small image inside the text 
        /// </summary>
        public partial class RichText : Object
        {
            /// <summary>
            /// A small image inside the text 
            /// </summary>
            public class RichTextIcon : RichText
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "richTextIcon";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The image represented as a document. The image can be in GIF, JPEG or PNG format
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("document")]
                public Document Document { get; set; }

                /// <summary>
                /// Width of a bounding box in which the image should be shown, 0 if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("width")]
                public int Width { get; set; }

                /// <summary>
                /// Height of a bounding box in which the image should be shown, 0 if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("height")]
                public int Height { get; set; }
            }
        }
    }
}