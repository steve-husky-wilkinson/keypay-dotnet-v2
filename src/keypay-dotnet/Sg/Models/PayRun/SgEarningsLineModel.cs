using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SgEarningsLineModel
    {
        public decimal CpfEmployerContributionAmount { get; set; }
        public decimal CpfEmployeeContributionAmount { get; set; }
        public decimal EmployerVoluntaryCpfAmount { get; set; }
        public decimal EmployerVoluntaryMediSaveAmount { get; set; }
        public decimal SdlContributionAmount { get; set; }
        public string PayCategoryId { get; set; }
        public string PayCategoryName { get; set; }
        public decimal Units { get; set; }
        public string Notes { get; set; }
        public decimal? Rate { get; set; }
        public decimal Earnings { get; set; }
        public decimal LumpSumNumberOfPayPeriods { get; set; }
        public LumpSumCalculationMethod? LumpSumCalculationMethod { get; set; }
        public int? TimesheetLineId { get; set; }
        public string TimesheetLineExternalId { get; set; }
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
