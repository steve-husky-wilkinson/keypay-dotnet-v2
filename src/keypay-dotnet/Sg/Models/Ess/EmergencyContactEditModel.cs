using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EmergencyContactEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string AlternateContactNumber { get; set; }
    }
}
