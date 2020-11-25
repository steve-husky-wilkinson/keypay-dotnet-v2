using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Business
{
    public class BusinessAccessModel
    {
        public RelatedUserType AccessType { get; set; }
        public IList<EmployeeGroupAccessModel> EmployeeGroups { get; set; }
        public IList<LocationAccessModel> LocationAccess { get; set; }
        public ReportAccessModel Reports { get; set; }
        public KioskAccessModel KioskAccess { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
