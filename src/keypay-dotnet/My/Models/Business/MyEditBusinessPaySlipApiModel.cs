using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class MyEditBusinessPaySlipApiModel
    {
        public bool ShowClassification { get; set; }
        public bool ShowBasePayRate { get; set; }
        public bool ShowEmployeeId { get; set; }
        public bool ShowRateForAnnualEarnings { get; set; }
        public int Id { get; set; }
        public string EmailFrom { get; set; }
        public string EmailBodyMessage { get; set; }
        public bool ShowLeaveAccruals { get; set; }
        public bool ShowLineNotes { get; set; }
        public bool ShowLocationInLineNotes { get; set; }
        public bool AlphabetisePayCategories { get; set; }
        public bool ShowEmployeeExternalId { get; set; }
        public bool EmployeesMustLoginToDownloadPayslips { get; set; }
    }
}
