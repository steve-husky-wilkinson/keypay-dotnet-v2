using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Manager
{
    public class ManagerUnavailabilityModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? TerminationDate { get; set; }
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Reason { get; set; }
        public bool Recurring { get; set; }
        public DayOfWeek? RecurringDay { get; set; }
        public bool IsAllDay { get; set; }
        public bool ViewOnly { get; set; }
    }
}
