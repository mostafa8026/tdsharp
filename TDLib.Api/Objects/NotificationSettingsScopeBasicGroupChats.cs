using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class NotificationSettingsScope : Object
        {
            public class NotificationSettingsScopeBasicGroupChats : NotificationSettingsScope
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "notificationSettingsScopeBasicGroupChats";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}