using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Location
{
    public class MySingleLocationModel
    {
        public List<MyLocationModel> NestedLocations { get; set; }
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public string FullyQualifiedName { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsRollupReportingLocation { get; set; }
        public string GeneralLedgerMappingCode { get; set; }
        public IList<Int32> DefaultShiftConditionIds { get; set; }
        public string State { get; set; }
    }
}
