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
        /// Toggles the "All members are admins" setting in basic groups; requires creator privileges in the group 
        /// </summary>
        public class ToggleBasicGroupAdministrators : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleBasicGroupAdministrators";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the basic group 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("basic_group_id")]
            public int BasicGroupId { get; set; }

            /// <summary>
            /// New value of everyone_is_administrator
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("everyone_is_administrator")]
            public bool EveryoneIsAdministrator { get; set; }
        }
    }
}