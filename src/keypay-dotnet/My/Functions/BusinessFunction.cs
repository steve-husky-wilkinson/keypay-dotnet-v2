using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Models.Business;

namespace KeyPayV2.My.Functions
{
    public class BusinessFunction : BaseFunction
    {
        public BusinessFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Lists all the businesses associated with the current user.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<MyBusinessExportModel> ListBusinesses(ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<MyBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Businesses
        /// </summary>
        /// <remarks>
        /// Lists all the businesses associated with the current user.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<MyBusinessExportModel>> ListBusinessesAsync(ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyBusinessExportModel>>($"/business{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public MyBusinessExportModel CreateNewBusiness(MyBusinessExportModel model)
        {
            return ApiRequest<MyBusinessExportModel,MyBusinessExportModel>($"/business", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<MyBusinessExportModel> CreateNewBusinessAsync(MyBusinessExportModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel,MyBusinessExportModel>($"/business", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public MyBusinessExportModel CreateNewBusiness(MyBusinessExportModel model, CreateNewBusinessQueryModel request)
        {
            return ApiRequest<MyBusinessExportModel,MyBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post);
        }

        /// <summary>
        /// Create New Business
        /// </summary>
        /// <remarks>
        /// Creates a new business.
        /// </remarks>
        public Task<MyBusinessExportModel> CreateNewBusinessAsync(MyBusinessExportModel model, CreateNewBusinessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel,MyBusinessExportModel>($"/business?setupDefaultData={request.SetupDefaultData}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public MyBusinessExportModel GetBusinessDetails(int businessId)
        {
            return ApiRequest<MyBusinessExportModel>($"/business/{businessId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified ID.
        /// </remarks>
        public Task<MyBusinessExportModel> GetBusinessDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel>($"/business/{businessId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List All Business Access Users
        /// </summary>
        /// <remarks>
        /// Lists all of the users with access to this business, as well as the types of access they each have.
        /// This operation supports OData queries.
        /// </remarks>
        public List<BusinessAccessModel> ListAllBusinessAccessUsers(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<BusinessAccessModel>>($"/business/{businessId}/access{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List All Business Access Users
        /// </summary>
        /// <remarks>
        /// Lists all of the users with access to this business, as well as the types of access they each have.
        /// This operation supports OData queries.
        /// </remarks>
        public Task<List<BusinessAccessModel>> ListAllBusinessAccessUsersAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BusinessAccessModel>>($"/business/{businessId}/access{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update details of an associated user
        /// </summary>
        /// <remarks>
        /// Updates the user details (name / email) of a user that is associated with the business.
        /// This endpoint will only work if the user is already associated with the business and is not associated with any other business
        /// </remarks>
        public void UpdateDetailsOfAnAssociatedUser(int businessId, AccessModel viewModel, UpdateDetailsOfAnAssociatedUserQueryModel request)
        {
            ApiRequest($"/business/{businessId}/access?email={request.Email}", viewModel, Method.Put);
        }

        /// <summary>
        /// Update details of an associated user
        /// </summary>
        /// <remarks>
        /// Updates the user details (name / email) of a user that is associated with the business.
        /// This endpoint will only work if the user is already associated with the business and is not associated with any other business
        /// </remarks>
        public Task UpdateDetailsOfAnAssociatedUserAsync(int businessId, AccessModel viewModel, UpdateDetailsOfAnAssociatedUserQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/access?email={request.Email}", viewModel, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Assign Business Access
        /// </summary>
        /// <remarks>
        /// Assigns business access to a name/email.
        /// </remarks>
        public void AssignBusinessAccess(int businessId, CreateBusinessAccessModel viewModel)
        {
            ApiRequest($"/business/{businessId}/access", viewModel, Method.Post);
        }

        /// <summary>
        /// Assign Business Access
        /// </summary>
        /// <remarks>
        /// Assigns business access to a name/email.
        /// </remarks>
        public Task AssignBusinessAccessAsync(int businessId, CreateBusinessAccessModel viewModel, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/access", viewModel, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Revoke Business Access
        /// </summary>
        /// <remarks>
        /// Revokes a user's access to the business.
        /// </remarks>
        public void RevokeBusinessAccess(int businessId, RevokeBusinessAccessQueryModel request)
        {
            ApiRequest($"/business/{businessId}/access?email={request.Email}", Method.Delete);
        }

        /// <summary>
        /// Revoke Business Access
        /// </summary>
        /// <remarks>
        /// Revokes a user's access to the business.
        /// </remarks>
        public Task RevokeBusinessAccessAsync(int businessId, RevokeBusinessAccessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/access?email={request.Email}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get User Business Access
        /// </summary>
        /// <remarks>
        /// Returns the business access assigned to the user with the specified email address.
        /// </remarks>
        public BusinessAccessModel GetUserBusinessAccess(int businessId, GetUserBusinessAccessQueryModel request)
        {
            return ApiRequest<BusinessAccessModel>($"/business/{businessId}/access/user?email={request.Email}", Method.Get);
        }

        /// <summary>
        /// Get User Business Access
        /// </summary>
        /// <remarks>
        /// Returns the business access assigned to the user with the specified email address.
        /// </remarks>
        public Task<BusinessAccessModel> GetUserBusinessAccessAsync(int businessId, GetUserBusinessAccessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<BusinessAccessModel>($"/business/{businessId}/access/user?email={request.Email}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Business Notifications
        /// </summary>
        /// <remarks>
        /// Lists the notifications, that appear on the Dashboard in the application, for the business.
        /// </remarks>
        public List<BusinessAction> ListBusinessNotifications(int businessId)
        {
            return ApiRequest<List<BusinessAction>>($"/business/{businessId}/actionitems/businessnotifications", Method.Get);
        }

        /// <summary>
        /// List Business Notifications
        /// </summary>
        /// <remarks>
        /// Lists the notifications, that appear on the Dashboard in the application, for the business.
        /// </remarks>
        public Task<List<BusinessAction>> ListBusinessNotificationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<BusinessAction>>($"/business/{businessId}/actionitems/businessnotifications", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Dismiss Business Notifications
        /// </summary>
        /// <remarks>
        /// Dismisses a business notification, so that it won't be shown again.
        /// </remarks>
        public void DismissBusinessNotifications(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/actionitems/businessnotifications/{id}/dismiss", Method.Delete);
        }

        /// <summary>
        /// Dismiss Business Notifications
        /// </summary>
        /// <remarks>
        /// Dismisses a business notification, so that it won't be shown again.
        /// </remarks>
        public Task DismissBusinessNotificationsAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/actionitems/businessnotifications/{id}/dismiss", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Business Document Details
        /// </summary>
        /// <remarks>
        /// Lists the details for all of the documents in the business.
        /// </remarks>
        public List<DocumentModel> ListBusinessDocumentDetails(int businessId)
        {
            return ApiRequest<List<DocumentModel>>($"/business/{businessId}/document", Method.Get);
        }

        /// <summary>
        /// List Business Document Details
        /// </summary>
        /// <remarks>
        /// Lists the details for all of the documents in the business.
        /// </remarks>
        public Task<List<DocumentModel>> ListBusinessDocumentDetailsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DocumentModel>>($"/business/{businessId}/document", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<DocumentModel> CreateBusinessDocument(int businessId, FileUploadModel file)
        {
            return ApiRequest<List<DocumentModel>,FileUploadModel>($"/business/{businessId}/document", file, Method.Post);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<DocumentModel>> CreateBusinessDocumentAsync(int businessId, FileUploadModel file, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<DocumentModel>,FileUploadModel>($"/business/{businessId}/document", file, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public List<DocumentModel> CreateBusinessDocument(int businessId, FileUploadModel file, CreateBusinessDocumentQueryModel request)
        {
            return ApiFileRequest<List<DocumentModel>>($"/business/{businessId}/document?visibleToAll={request.VisibleToAll}", file, Method.Post);
        }

        /// <summary>
        /// Create Business Document
        /// </summary>
        /// <remarks>
        /// Uploads new document(s) for business. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<List<DocumentModel>> CreateBusinessDocumentAsync(int businessId, FileUploadModel file, CreateBusinessDocumentQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiFileRequestAsync<List<DocumentModel>>($"/business/{businessId}/document?visibleToAll={request.VisibleToAll}", file, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Business Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the specified business document.
        /// </remarks>
        public DocumentModel GetBusinessDocumentDetails(int businessId, int id)
        {
            return ApiRequest<DocumentModel>($"/business/{businessId}/document/{id}", Method.Get);
        }

        /// <summary>
        /// Get Business Document Details
        /// </summary>
        /// <remarks>
        /// Gets the details for the specified business document.
        /// </remarks>
        public Task<DocumentModel> GetBusinessDocumentDetailsAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentModel>($"/business/{businessId}/document/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Business Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the business document with the specified ID.
        /// </remarks>
        public DocumentModel UpdateBusinessDocumentPermissions(int businessId, int id, UpdateDocumentPermissionsModel model)
        {
            return ApiRequest<DocumentModel,UpdateDocumentPermissionsModel>($"/business/{businessId}/document/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Business Document Permissions
        /// </summary>
        /// <remarks>
        /// Updates permissions for the business document with the specified ID.
        /// </remarks>
        public Task<DocumentModel> UpdateBusinessDocumentPermissionsAsync(int businessId, int id, UpdateDocumentPermissionsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentModel,UpdateDocumentPermissionsModel>($"/business/{businessId}/document/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Business Document
        /// </summary>
        /// <remarks>
        /// Deletes the business document with the specified ID.
        /// </remarks>
        public void DeleteBusinessDocument(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/document/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Business Document
        /// </summary>
        /// <remarks>
        /// Deletes the business document with the specified ID.
        /// </remarks>
        public Task DeleteBusinessDocumentAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/document/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Business Document Content
        /// </summary>
        /// <remarks>
        /// Gets the file content for the business document with the specified ID.
        /// </remarks>
        public DocumentFile GetBusinessDocumentContent(int businessId, int id)
        {
            return ApiRequest<DocumentFile>($"/business/{businessId}/document/{id}/content", Method.Get);
        }

        /// <summary>
        /// Get Business Document Content
        /// </summary>
        /// <remarks>
        /// Gets the file content for the business document with the specified ID.
        /// </remarks>
        public Task<DocumentFile> GetBusinessDocumentContentAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<DocumentFile>($"/business/{businessId}/document/{id}/content", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public MyEmployeePortalSettingsModel GetEmployeePortalSettings(int businessId)
        {
            return ApiRequest<MyEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get);
        }

        /// <summary>
        /// Get Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<MyEmployeePortalSettingsModel> GetEmployeePortalSettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public MyEmployeePortalSettingsModel UpdateEmployeePortalSettings(int businessId, MyEmployeePortalSettingsModel model)
        {
            return ApiRequest<MyEmployeePortalSettingsModel,MyEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post);
        }

        /// <summary>
        /// Update Employee Portal Settings
        /// </summary>
        /// <remarks>
        /// Updates the business employee portal settings
        /// </remarks>
        public Task<MyEmployeePortalSettingsModel> UpdateEmployeePortalSettingsAsync(int businessId, MyEmployeePortalSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEmployeePortalSettingsModel,MyEmployeePortalSettingsModel>($"/business/{businessId}/employeeportalsettings", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Entitlements
        /// </summary>
        /// <remarks>
        /// Lists all of the entitlements for the business.
        /// </remarks>
        public EntitlementsModel ListEntitlements(int businessId)
        {
            return ApiRequest<EntitlementsModel>($"/business/{businessId}/entitlements", Method.Get);
        }

        /// <summary>
        /// List Entitlements
        /// </summary>
        /// <remarks>
        /// Lists all of the entitlements for the business.
        /// </remarks>
        public Task<EntitlementsModel> ListEntitlementsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EntitlementsModel>($"/business/{businessId}/entitlements", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business. This is the tax year that
        /// </remarks>
        public void ChangeTheTaxYear(int businessId, ChangeTheTaxYearQueryModel request)
        {
            ApiRequest($"/business/{businessId}/initialfinancialyear?year={request.Year}", Method.Post);
        }

        /// <summary>
        /// Change the tax year
        /// </summary>
        /// <remarks>
        /// Changes the initial tax year for the current business. This is the tax year that
        /// </remarks>
        public Task ChangeTheTaxYearAsync(int businessId, ChangeTheTaxYearQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/initialfinancialyear?year={request.Year}", Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public MyEditBusinessPaySlipApiModel GetPayslipConfiguration(int businessId)
        {
            return ApiRequest<MyEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get);
        }

        /// <summary>
        /// Get payslip configuration
        /// </summary>
        /// <remarks>
        /// Gets the payslip configuration for the specified business ID.
        /// </remarks>
        public Task<MyEditBusinessPaySlipApiModel> GetPayslipConfigurationAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyEditBusinessPaySlipApiModel>($"/business/{businessId}/payslip", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create payslip configuration
        /// </summary>
        /// <remarks>
        /// Creates the payslip configuration for the specified business ID.
        /// ShowLineNotes field must be enabled in order to enable the ShowLocationInLineNotes field.
        /// An example of what you would populate the EmailBodyMessage field with would be:
        /// <p>Hi {{FirstName}},</p><p>{{BusinessName}} has just processed your pay and a new pay slip is available.</p><p>Regards {{BusinessName}}</p>
        /// </remarks>
        public void CreatePayslipConfiguration(int businessId, MyEditBusinessPaySlipApiModel model)
        {
            ApiRequest($"/business/{businessId}/payslip", model, Method.Post);
        }

        /// <summary>
        /// Create payslip configuration
        /// </summary>
        /// <remarks>
        /// Creates the payslip configuration for the specified business ID.
        /// ShowLineNotes field must be enabled in order to enable the ShowLocationInLineNotes field.
        /// An example of what you would populate the EmailBodyMessage field with would be:
        /// <p>Hi {{FirstName}},</p><p>{{BusinessName}} has just processed your pay and a new pay slip is available.</p><p>Regards {{BusinessName}}</p>
        /// </remarks>
        public Task CreatePayslipConfigurationAsync(int businessId, MyEditBusinessPaySlipApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/payslip", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public TimesheetRoundingRulesModel GetRoundingRules(int businessId)
        {
            return ApiRequest<TimesheetRoundingRulesModel>($"/business/{businessId}/roundingrules", Method.Get);
        }

        /// <summary>
        /// Get Rounding Rules
        /// </summary>
        /// <remarks>
        /// Gets the rounding rules for the business.
        /// </remarks>
        public Task<TimesheetRoundingRulesModel> GetRoundingRulesAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TimesheetRoundingRulesModel>($"/business/{businessId}/roundingrules", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public void SetRoundingRules(int businessId, TimesheetRoundingRulesModel roundingRules)
        {
            ApiRequest($"/business/{businessId}/roundingrules", roundingRules, Method.Post);
        }

        /// <summary>
        /// Set Rounding Rules
        /// </summary>
        /// <remarks>
        /// Sets the rounding rules for the business.
        /// </remarks>
        public Task SetRoundingRulesAsync(int businessId, TimesheetRoundingRulesModel roundingRules, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/roundingrules", roundingRules, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Statutory Settings
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Settings for the business
        /// </remarks>
        public MyBusinessStatutorySettingsModel GetStatutorySettings(int businessId)
        {
            return ApiRequest<MyBusinessStatutorySettingsModel>($"/business/{businessId}/statutorysettings", Method.Get);
        }

        /// <summary>
        /// Get Statutory Settings
        /// </summary>
        /// <remarks>
        /// Gets the Statutory Settings for the business
        /// </remarks>
        public Task<MyBusinessStatutorySettingsModel> GetStatutorySettingsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessStatutorySettingsModel>($"/business/{businessId}/statutorysettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Set Statutory Settings
        /// </summary>
        /// <remarks>
        /// Sets the Statutory Settings for the business
        /// </remarks>
        public MyBusinessStatutorySettingsModel SetStatutorySettings(int businessId, MyBusinessStatutorySettingsModel model)
        {
            return ApiRequest<MyBusinessStatutorySettingsModel,MyBusinessStatutorySettingsModel>($"/business/{businessId}/statutorysettings", model, Method.Post);
        }

        /// <summary>
        /// Set Statutory Settings
        /// </summary>
        /// <remarks>
        /// Sets the Statutory Settings for the business
        /// </remarks>
        public Task<MyBusinessStatutorySettingsModel> SetStatutorySettingsAsync(int businessId, MyBusinessStatutorySettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessStatutorySettingsModel,MyBusinessStatutorySettingsModel>($"/business/{businessId}/statutorysettings", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get the timesheet settings for the business
        /// </summary>
        public void GetTheTimesheetSettingsForTheBusiness(int businessId)
        {
            ApiRequest($"/business/{businessId}/timesheetsettings", Method.Get);
        }

        /// <summary>
        /// Get the timesheet settings for the business
        /// </summary>
        public Task GetTheTimesheetSettingsForTheBusinessAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheetsettings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public void UpdateTheTimesheetSettingsForTheBusiness(int businessId, MyBusinessTimesheetSettingsModel model)
        {
            ApiRequest($"/business/{businessId}/timesheetsettings", model, Method.Put);
        }

        /// <summary>
        /// Update the timesheet settings for the business
        /// </summary>
        public Task UpdateTheTimesheetSettingsForTheBusinessAsync(int businessId, MyBusinessTimesheetSettingsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/timesheetsettings", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public MyBusinessExportModel GetBusinessDetailsByExternalId(GetBusinessDetailsByExternalIdQueryModel request)
        {
            return ApiRequest<MyBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get);
        }

        /// <summary>
        /// Get Business Details by External ID
        /// </summary>
        /// <remarks>
        /// Retrieves the details of the business with the specified external ID.
        /// </remarks>
        public Task<MyBusinessExportModel> GetBusinessDetailsByExternalIdAsync(GetBusinessDetailsByExternalIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyBusinessExportModel>($"/business/externalid?externalId={request.ExternalId}", Method.Get, cancellationToken);
        }
    }
}
