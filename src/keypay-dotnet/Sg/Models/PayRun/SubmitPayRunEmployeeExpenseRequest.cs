using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SubmitPayRunEmployeeExpenseRequest
    {
        public IdType LocationIdType { get; set; }
        public IdType EmployeeExpenseCategoryIdType { get; set; }
        public Dictionary<string,List<EmployeeExpenseModel>> Expenses { get; set; }
        public int PayRunId { get; set; }
        public IdType EmployeeIdType { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool SuppressCalculations { get; set; }
    }
}
