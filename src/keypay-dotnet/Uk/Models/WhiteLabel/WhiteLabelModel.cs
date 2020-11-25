using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.WhiteLabel
{
    public class WhiteLabelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
