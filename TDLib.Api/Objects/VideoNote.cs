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
        /// Describes a video note. The video must be equal in width and height, cropped to a circle, and stored in MPEG4 format 
        /// </summary>
        public class VideoNote : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "videoNote";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Duration of the video, in seconds; as defined by the sender 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("duration")]
            public int Duration { get; set; }

            /// <summary>
            /// Video width and height; as defined by the sender 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("length")]
            public int Length { get; set; }

            /// <summary>
            /// Video thumbnail; as defined by the sender; may be null 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("thumbnail")]
            public PhotoSize Thumbnail { get; set; }

            /// <summary>
            /// File containing the video
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("video")]
            public File Video { get; set; }
        }
    }
}