using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class ShiftPartModel
    {
        public bool IsBreak { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan EffectiveDuration { get; set; }
        public TimeSpan ActualDuration { get; set; }
        public string PayCategory { get; set; }
        public int PayCategoryId { get; set; }
        public decimal Cost { get; set; }
        public decimal? RateMultiplier { get; set; }
        public decimal BaseRate { get; set; }
        public decimal CalculatedRate { get; set; }
        public string DisplayDuration { get; set; }
        public NominalWorkType WorkType { get; set; }
        public NominalClassification Classification { get; set; }
        public NominalLeaveCategory LeaveCategory { get; set; }
        public NominalLocation Location { get; set; }
        public bool IsAllowanceOrUnitBased { get; set; }
    }
}
