using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Common
{
    public class TimeAndAttendanceBreakModel
    {
        public DateTime StartTimeUtc { get; set; }
        public DateTime StartTimeLocal { get; set; }
        public DateTime? EndTimeUtc { get; set; }
        public DateTime? EndTimeLocal { get; set; }
    }
}
