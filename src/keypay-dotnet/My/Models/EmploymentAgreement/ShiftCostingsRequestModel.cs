using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmploymentAgreement
{
    public class ShiftCostingsRequestModel
    {
        public string TransactionExternalId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType LocationIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType WorkTypeIdType { get; set; }
        public bool IncludeEvaluationResults { get; set; }
        public ShiftCostingsEmployeeModel Employee { get; set; }
        public IList<ShiftCostingsRequestShiftModel> Shifts { get; set; }
    }
}
