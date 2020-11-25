using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.Common
{
    public class Attachment
    {
        public Byte[] Data { get; set; }
        public bool IsDeleted { get; set; }
        public int? Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Url { get; set; }
        public DateTime? DateScanned { get; set; }
        public bool? IsInfected { get; set; }
    }
}
