using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SgDeductionModel
    {
        public string PayToBankAccountBranchCode { get; set; }
        public string DeductionCategoryId { get; set; }
        public string DeductionCategoryName { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string PaymentReference { get; set; }
        public string Note { get; set; }
        public string PayToBankAccountSwift { get; set; }
        public string PayToBankAccountNumber { get; set; }
        public string PayTo { get; set; }
        public int? AdditionalData { get; set; }
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
