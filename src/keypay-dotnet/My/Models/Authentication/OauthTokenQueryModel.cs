using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Authentication
{
    public class OauthTokenQueryModel
    {
        public HttpRequestMessage Request { get; set; }
    }
}
