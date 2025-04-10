using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.RosterShift
{
    public class GetRosterShiftsQueryModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public RosterShiftStatus ShiftStatus { get; set; }
        public IList<RosterShiftStatus> ShiftStatuses { get; set; }
        public IList<String> SelectedLocations { get; set; }
        public IList<String> SelectedEmployees { get; set; }
        public IList<String> SelectedRoles { get; set; }
        public int? EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeGroupId { get; set; }
        public bool UnassignedShiftsOnly { get; set; }
        public bool SelectAllRoles { get; set; }
        public bool ExcludeShiftsOverlappingFromDate { get; set; }
        public int? PageSize { get; set; }
        public int? PageNum { get; set; }
        public bool IncludeWarnings { get; set; }
    }
}
