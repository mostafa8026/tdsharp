using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class UserPrivacySettingRule : Object
        {
            public class UserPrivacySettingRuleRestrictContacts : UserPrivacySettingRule
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingRuleRestrictContacts";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}