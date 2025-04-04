using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmployeeEarningsLineSplit
{
    public class EarningsLineSplitEditModel
    {
        public int LocationId { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public bool AllocateBalance { get; set; }
    }
}
