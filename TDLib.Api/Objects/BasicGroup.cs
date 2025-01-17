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
        /// Represents a basic group of 0-200 users (must be upgraded to a supergroup to accommodate more than 200 users)
        /// </summary>
        public class BasicGroup : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "basicGroup";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Number of members in the group
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_count")]
            public int MemberCount { get; set; }

            /// <summary>
            /// Status of the current user in the group
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("status")]
            public ChatMemberStatus Status { get; set; }

            /// <summary>
            /// True, if all members have been granted administrator rights in the group
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("everyone_is_administrator")]
            public bool EveryoneIsAdministrator { get; set; }

            /// <summary>
            /// True, if the group is active
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_active")]
            public bool IsActive { get; set; }

            /// <summary>
            /// Identifier of the supergroup to which this group was upgraded; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("upgraded_to_supergroup_id")]
            public int UpgradedToSupergroupId { get; set; }
        }
    }
}