using System;
using System.Collections.Generic;

namespace KeyPayV2.Uk.Enums
{
    public enum PayRunEmployeeSelectionStrategy
    {
        None,
        PayRunDefault,
        TimesheetLocations,
        PayRunDefaultWithTimesheets,
        ActiveSubcontractors
    }
}
