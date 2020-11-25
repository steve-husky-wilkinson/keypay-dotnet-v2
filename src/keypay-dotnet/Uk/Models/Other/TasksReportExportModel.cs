using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Other
{
    public class TasksReportExportModel
    {
        public int PayRunTaskId { get; set; }
        public string EmployeeName { get; set; }
        public int? EmployeeId { get; set; }
        public string ExternalId { get; set; }
        public string TaskDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Completed { get; set; }
        public List<TasksReportNoteModel> Notes { get; set; }
        public string CompletedBy { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
