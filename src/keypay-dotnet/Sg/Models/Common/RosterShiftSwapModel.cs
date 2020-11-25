using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Common
{
    public class RosterShiftSwapModel
    {
        public int Id { get; set; }
        public string FromEmployee { get; set; }
        public string ToEmployee { get; set; }
        public int FromEmployeeId { get; set; }
        public int ToEmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        public string RejectedReason { get; set; }
        public int Status { get; set; }
        public string StatusDescription { get; set; }
    }
}
