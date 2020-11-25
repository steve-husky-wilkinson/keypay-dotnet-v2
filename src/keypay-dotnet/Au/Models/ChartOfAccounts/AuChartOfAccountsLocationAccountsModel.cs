using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.ChartOfAccounts
{
    public class AuChartOfAccountsLocationAccountsModel
    {
        public int? PaygLiabilityAccountId { get; set; }
        public int? PaygExpenseAccountId { get; set; }
        public int? SuperannuationExpenseAccountId { get; set; }
        public int? SuperannuationLiabilityAccountId { get; set; }
        public int? PaymentAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
        public int? StudentLoanLiabilityAccountId { get; set; }
        public int? PostgraduateStudentLoanLiabilityAccountId { get; set; }
        public int? EmployerNationalInsuranceLiabilityAccountId { get; set; }
        public int? EmployeeNationalInsuranceLiabilityAccountId { get; set; }
    }
}
