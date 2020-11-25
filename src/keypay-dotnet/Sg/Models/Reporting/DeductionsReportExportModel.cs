using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class DeductionsReportExportModel
    {
        public string PayRun { get; set; }
        public DateTime DatePaid { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string Location { get; set; }
        public List<DeductionsReportDeductionAmountModel> Amounts { get; set; }
    }
}
