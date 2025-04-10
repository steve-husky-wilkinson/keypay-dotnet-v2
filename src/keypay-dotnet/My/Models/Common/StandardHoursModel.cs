using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.Employee;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class StandardHoursModel
    {
        public int EmployeeId { get; set; }
        public decimal StandardHoursPerWeek { get; set; }
        public decimal StandardHoursPerDay { get; set; }
        public bool UseAdvancedWorkWeek { get; set; }
        public List<StandardHoursDayModel> StandardWorkDays { get; set; }
    }
}
