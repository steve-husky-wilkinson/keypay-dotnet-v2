using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.Reporting;

namespace KeyPayV2.Sg.Functions
{
    public class ReportingFunction : BaseFunction
    {
        public ReportingFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Birthday Report
        /// </summary>
        /// <remarks>
        /// Generates a birthday report.
        /// </remarks>
        public List<BirthdayReportExportModel> BirthdayReport(int businessId, BirthdayReportQueryModel request)
        {
            return ApiRequest<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}", Method.Get);
        }

        /// <summary>
        /// Birthday Report
        /// </summary>
        /// <remarks>
        /// Generates a birthday report.
        /// </remarks>
        public Task<List<BirthdayReportExportModel>> BirthdayReportAsync(int businessId, BirthdayReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BirthdayReportExportModel>>($"/business/{businessId}/report/birthday?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public List<SgCostingReportApiModel> CostingReport(int businessId, CostingReportQueryModel request)
        {
            return ApiRequest<List<SgCostingReportApiModel>>($"/business/{businessId}/report/costing?showZeroPayCategories={request.ShowZeroPayCategories}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Costing Report
        /// </summary>
        /// <remarks>
        /// Generates a costing report.
        /// </remarks>
        public Task<List<SgCostingReportApiModel>> CostingReportAsync(int businessId, CostingReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgCostingReportApiModel>>($"/business/{businessId}/report/costing?showZeroPayCategories={request.ShowZeroPayCategories}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// CPF lodgement report
        /// </summary>
        /// <remarks>
        /// Generates a CPF lodgement report
        /// </remarks>
        public List<SgCpfApiModel> CpfLodgementReport(int businessId, CpfLodgementReportQueryModel request)
        {
            return ApiRequest<List<SgCpfApiModel>>($"/business/{businessId}/report/cpf?employeeId={request.EmployeeId}&paymentTypeId={request.PaymentTypeId}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// CPF lodgement report
        /// </summary>
        /// <remarks>
        /// Generates a CPF lodgement report
        /// </remarks>
        public Task<List<SgCpfApiModel>> CpfLodgementReportAsync(int businessId, CpfLodgementReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgCpfApiModel>>($"/business/{businessId}/report/cpf?employeeId={request.EmployeeId}&paymentTypeId={request.PaymentTypeId}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Deductions Report
        /// </summary>
        /// <remarks>
        /// Generates a deductions report.
        /// </remarks>
        public List<DeductionsReportExportModel> DeductionsReport(int businessId, DeductionsReportQueryModel request)
        {
            return ApiRequest<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions?employeeId={request.EmployeeId}&deductionCategoryId={request.DeductionCategoryId}&disableRollupReporting={request.DisableRollupReporting}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Deductions Report
        /// </summary>
        /// <remarks>
        /// Generates a deductions report.
        /// </remarks>
        public Task<List<DeductionsReportExportModel>> DeductionsReportAsync(int businessId, DeductionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DeductionsReportExportModel>>($"/business/{businessId}/report/deductions?employeeId={request.EmployeeId}&deductionCategoryId={request.DeductionCategoryId}&disableRollupReporting={request.DisableRollupReporting}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public List<SgDetailedActivityReportExportModel> DetailedActivityReport(int businessId, DetailedActivityReportQueryModel request)
        {
            return ApiRequest<List<SgDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Detailed Activity Report
        /// </summary>
        /// <remarks>
        /// Generates a detailed activity report.
        /// </remarks>
        public Task<List<SgDetailedActivityReportExportModel>> DetailedActivityReportAsync(int businessId, DetailedActivityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgDetailedActivityReportExportModel>>($"/business/{businessId}/report/detailedactivity?payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Document Acknowledgements Report
        /// </summary>
        /// <remarks>
        /// Generates a document acknowledgements report.
        /// </remarks>
        public List<DocumentAcknowledgementsReportExportModel> DocumentAcknowledgementsReport(int businessId, DocumentAcknowledgementsReportQueryModel request)
        {
            return ApiRequest<List<DocumentAcknowledgementsReportExportModel>>($"/business/{businessId}/report/documentAcknowledgements?documentId={request.DocumentId}{ConvertEnumerableToQueryString("employeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&documentStatus={request.DocumentStatus}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Get);
        }

        /// <summary>
        /// Document Acknowledgements Report
        /// </summary>
        /// <remarks>
        /// Generates a document acknowledgements report.
        /// </remarks>
        public Task<List<DocumentAcknowledgementsReportExportModel>> DocumentAcknowledgementsReportAsync(int businessId, DocumentAcknowledgementsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DocumentAcknowledgementsReportExportModel>>($"/business/{businessId}/report/documentAcknowledgements?documentId={request.DocumentId}{ConvertEnumerableToQueryString("employeeIds", request.EmployeeIds?.Select(x => x.ToString()))}&documentStatus={request.DocumentStatus}&employingEntityId={request.EmployingEntityId}&locationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Audit Report
        /// </summary>
        /// <remarks>
        /// Generates an Employee Audit Report.
        /// </remarks>
        public List<EmployeeDetailsAuditReportApiModel> EmployeeAuditReport(int businessId, EmployeeAuditReportQueryModel request)
        {
            return ApiRequest<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit?employeeId={request.EmployeeId}&section={request.Section}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Audit Report
        /// </summary>
        /// <remarks>
        /// Generates an Employee Audit Report.
        /// </remarks>
        public Task<List<EmployeeDetailsAuditReportApiModel>> EmployeeAuditReportAsync(int businessId, EmployeeAuditReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsAuditReportApiModel>>($"/business/{businessId}/report/employeeaudit?employeeId={request.EmployeeId}&section={request.Section}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public List<dynamic> EmployeeDetailsReport(int businessId, EmployeeDetailsReportQueryModel request)
        {
            return ApiRequest<List<dynamic>>($"/business/{businessId}/report/employeedetails{ConvertEnumerableToQueryString("selectedColumns", request.SelectedColumns?.Select(x => x.ToString()))}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}&includeActive={request.IncludeActive}&includeInactive={request.IncludeInactive}", Method.Get);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public Task<List<dynamic>> EmployeeDetailsReportAsync(int businessId, EmployeeDetailsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<dynamic>>($"/business/{businessId}/report/employeedetails{ConvertEnumerableToQueryString("selectedColumns", request.SelectedColumns?.Select(x => x.ToString()))}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}&includeActive={request.IncludeActive}&includeInactive={request.IncludeInactive}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public List<dynamic> EmployeeDetailsReport(int businessId, EmployeeDetailsReportRequestModel model)
        {
            return ApiRequest<List<dynamic>,EmployeeDetailsReportRequestModel>($"/business/{businessId}/report/employeedetails", model, Method.Post);
        }

        /// <summary>
        /// Employee Details Report
        /// </summary>
        /// <remarks>
        /// Generates an employee details report.
        /// </remarks>
        public Task<List<dynamic>> EmployeeDetailsReportAsync(int businessId, EmployeeDetailsReportRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<dynamic>,EmployeeDetailsReportRequestModel>($"/business/{businessId}/report/employeedetails", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Employee Details Report Fields
        /// </summary>
        /// <remarks>
        /// Gets the fields for the Employee Details Report.
        /// </remarks>
        public List<EmployeeDetailsReportField> EmployeeDetailsReportFields(int businessId)
        {
            return ApiRequest<List<EmployeeDetailsReportField>>($"/business/{businessId}/report/employeedetails/fields", Method.Get);
        }

        /// <summary>
        /// Employee Details Report Fields
        /// </summary>
        /// <remarks>
        /// Gets the fields for the Employee Details Report.
        /// </remarks>
        public Task<List<EmployeeDetailsReportField>> EmployeeDetailsReportFieldsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeDetailsReportField>>($"/business/{businessId}/report/employeedetails/fields", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public List<SgGrossToNetResponseModel> GrossToNetReport(int businessId, GrossToNetReportQueryModel request)
        {
            return ApiRequest<List<SgGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?employeeId={request.EmployeeId}{ConvertEnumerableToQueryString("payCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Gross To Net Report
        /// </summary>
        /// <remarks>
        /// Generates a Gross To Net Report.
        /// </remarks>
        public Task<List<SgGrossToNetResponseModel>> GrossToNetReportAsync(int businessId, GrossToNetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgGrossToNetResponseModel>>($"/business/{businessId}/report/grosstonet?employeeId={request.EmployeeId}{ConvertEnumerableToQueryString("payCategoryIds", request.PayCategoryIds?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public void JournalReport(int businessId, JournalReportQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/journal?payRunId={request.PayRunId}&journalView={request.JournalView}&journalService={request.JournalService}", Method.Get);
        }

        /// <summary>
        /// Journal Report
        /// </summary>
        /// <remarks>
        /// Gets the journal for a finalised pay run with the specified Id.
        /// </remarks>
        public Task JournalReportAsync(int businessId, JournalReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/journal?payRunId={request.PayRunId}&journalView={request.JournalView}&journalService={request.JournalService}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public List<SgLeaveBalancesExportModel> LeaveBalancesReport(int businessId, LeaveBalancesReportQueryModel request)
        {
            return ApiRequest<List<SgLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&groupBy={request.GroupBy}&employingEntityId={request.EmployingEntityId}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        /// <summary>
        /// Leave Balances Report
        /// </summary>
        /// <remarks>
        /// Generates a leave balances report.
        /// </remarks>
        public Task<List<SgLeaveBalancesExportModel>> LeaveBalancesReportAsync(int businessId, LeaveBalancesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgLeaveBalancesExportModel>>($"/business/{businessId}/report/leavebalances?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&groupBy={request.GroupBy}&employingEntityId={request.EmployingEntityId}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public List<LeaveLiabilityExportModel> LeaveLiabilityReport(int businessId, LeaveLiabilityReportQueryModel request)
        {
            return ApiRequest<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&includeApprovedLeave={request.IncludeApprovedLeave}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Leave Liability Report
        /// </summary>
        /// <remarks>
        /// Generates a leave liability report.
        /// </remarks>
        public Task<List<LeaveLiabilityExportModel>> LeaveLiabilityReportAsync(int businessId, LeaveLiabilityReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveLiabilityExportModel>>($"/business/{businessId}/report/leaveliability?locationId={request.LocationId}&leaveTypeId={request.LeaveTypeId}&includeApprovedLeave={request.IncludeApprovedLeave}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public List<SgPayCategoriesModel> PayCategoriesReport(int businessId, PayCategoriesReportQueryModel request)
        {
            return ApiRequest<List<SgPayCategoriesModel>>($"/business/{businessId}/report/paycategories?payScheduleId={request.PayScheduleId}&employeeId={request.EmployeeId}&groupByEarningsLocation={request.GroupByEarningsLocation}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Categories Report
        /// </summary>
        /// <remarks>
        /// Generates a pay categories report.
        /// </remarks>
        public Task<List<SgPayCategoriesModel>> PayCategoriesReportAsync(int businessId, PayCategoriesReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPayCategoriesModel>>($"/business/{businessId}/report/paycategories?payScheduleId={request.PayScheduleId}&employeeId={request.EmployeeId}&groupByEarningsLocation={request.GroupByEarningsLocation}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public List<SgPaymentHistoryModel> EmployeePaymentHistoryReport(int businessId, EmployeePaymentHistoryReportQueryModel request)
        {
            return ApiRequest<List<SgPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?employeeId={request.EmployeeId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Employee Payment History Report
        /// </summary>
        /// <remarks>
        /// Generates an employee payment history report.
        /// </remarks>
        public Task<List<SgPaymentHistoryModel>> EmployeePaymentHistoryReportAsync(int businessId, EmployeePaymentHistoryReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPaymentHistoryModel>>($"/business/{businessId}/report/paymenthistory?employeeId={request.EmployeeId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public List<SgPayRunInclusionExportModel> PayRunInclusionsReport(int businessId, PayRunInclusionsReportQueryModel request)
        {
            return ApiRequest<List<SgPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?employeeId={request.EmployeeId}&status={request.Status}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Pay Run Inclusions Report
        /// </summary>
        /// <remarks>
        /// Generates a pay run inclusions report.
        /// </remarks>
        public Task<List<SgPayRunInclusionExportModel>> PayRunInclusionsReportAsync(int businessId, PayRunInclusionsReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgPayRunInclusionExportModel>>($"/business/{businessId}/report/payruninclusions?employeeId={request.EmployeeId}&status={request.Status}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public List<SgRosterTimesheetComparisonReportExportModel> RosterVsTimesheetComparisonReport(int businessId, RosterVsTimesheetComparisonReportQueryModel request)
        {
            return ApiRequest<List<SgRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?employmentTypeId={request.EmploymentTypeId}&employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("timesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&rosterLocationId={request.RosterLocationId}&timesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("rosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Roster vs Timesheet Comparison Report
        /// </summary>
        /// <remarks>
        /// Generates a roster vs timesheet comparison report.
        /// </remarks>
        public Task<List<SgRosterTimesheetComparisonReportExportModel>> RosterVsTimesheetComparisonReportAsync(int businessId, RosterVsTimesheetComparisonReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgRosterTimesheetComparisonReportExportModel>>($"/business/{businessId}/report/rostertimesheetcomparison?employmentTypeId={request.EmploymentTypeId}&employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("timesheetStatuses", request.TimesheetStatuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&rosterLocationId={request.RosterLocationId}&timesheetLocationId={request.TimesheetLocationId}{ConvertEnumerableToQueryString("rosterStatuses", request.RosterStatuses?.Select(x => x.ToString()))}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public List<SgTimesheetExportModel> TimesheetReport(int businessId, TimesheetReportQueryModel request)
        {
            return ApiRequest<List<SgTimesheetExportModel>>($"/business/{businessId}/report/timesheet?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Timesheet Report
        /// </summary>
        /// <remarks>
        /// Generates a timesheet report.
        /// </remarks>
        public Task<List<SgTimesheetExportModel>> TimesheetReportAsync(int businessId, TimesheetReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgTimesheetExportModel>>($"/business/{businessId}/report/timesheet?employeeId={request.EmployeeId}&includeCosts={request.IncludeCosts}{ConvertEnumerableToQueryString("statuses", request.Statuses?.Select(x => x.ToString()))}&workTypeId={request.WorkTypeId}&payScheduleId={request.PayScheduleId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Withholding Report
        /// </summary>
        /// <remarks>
        /// Generates a withholding report, containing a breakdown of the amounts withheld per month for a given date range
        /// </remarks>
        public List<SgWithholdingModel> WithholdingReport(int businessId, WithholdingReportQueryModel request)
        {
            return ApiRequest<List<SgWithholdingModel>>($"/business/{businessId}/report/withholding?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        /// <summary>
        /// Withholding Report
        /// </summary>
        /// <remarks>
        /// Generates a withholding report, containing a breakdown of the amounts withheld per month for a given date range
        /// </remarks>
        public Task<List<SgWithholdingModel>> WithholdingReportAsync(int businessId, WithholdingReportQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<SgWithholdingModel>>($"/business/{businessId}/report/withholding?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }
    }
}
