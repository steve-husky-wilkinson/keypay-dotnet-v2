using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Common
{
    public class SaveSuperFundModel
    {
        public string MemberNumber { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public decimal? FixedAmount { get; set; }
        public string ProductCode { get; set; }
        public string FundName { get; set; }
        public bool AllocateBalance { get; set; }
        public bool? IsEmployerNominatedFund { get; set; }
    }
}
