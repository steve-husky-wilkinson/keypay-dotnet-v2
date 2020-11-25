using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.PayRun
{
    public class JournalExportResult
    {
        public JournalExportStatus Status { get; set; }
        public string Message { get; set; }
        public ExternalService JournalSource { get; set; }
        public string JournalExternalReferenceId { get; set; }
    }
}
