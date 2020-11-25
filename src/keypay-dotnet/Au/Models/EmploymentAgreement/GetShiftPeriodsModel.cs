using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.EmploymentAgreement
{
    public class GetShiftPeriodsModel
    {
        public DateTime? FirstShiftStartTime { get; set; }
        public DateTime? LastShiftStartTime { get; set; }
    }
}
