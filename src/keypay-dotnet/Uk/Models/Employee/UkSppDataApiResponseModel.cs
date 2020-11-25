using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSppDataApiResponseModel
    {
        public int? Id { get; set; }
        public SppEligibilityEnum Status { get; set; }
        public IList<StatutoryLeaveLogEvent> Log { get; set; }
    }
}
