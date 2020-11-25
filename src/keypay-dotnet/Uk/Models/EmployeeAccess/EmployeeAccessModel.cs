using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.EmployeeAccess
{
    public class EmployeeAccessModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
