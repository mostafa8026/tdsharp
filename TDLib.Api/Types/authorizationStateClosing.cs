using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthorizationState : Structure
    {

        public partial class authorizationStateClosing : AuthorizationState
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "authorizationStateClosing";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}