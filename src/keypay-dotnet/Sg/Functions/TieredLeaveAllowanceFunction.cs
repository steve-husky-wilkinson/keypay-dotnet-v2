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
using KeyPayV2.Sg.Models.TieredLeaveAllowance;

namespace KeyPayV2.Sg.Functions
{
    public class TieredLeaveAllowanceFunction : BaseFunction
    {
        public TieredLeaveAllowanceFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Tiered Leave Allowance Templates
        /// </summary>
        /// <remarks>
        /// Lists all the Tiered Leave Allowance templates for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<TieredLeaveAllowanceTemplateApiModel> ListTieredLeaveAllowanceTemplates(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<TieredLeaveAllowanceTemplateApiModel>>($"/business/{businessId}/tieredleaveallowancetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get);
        }

        /// <summary>
        /// List Tiered Leave Allowance Templates
        /// </summary>
        /// <remarks>
        /// Lists all the Tiered Leave Allowance templates for this business.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public Task<List<TieredLeaveAllowanceTemplateApiModel>> ListTieredLeaveAllowanceTemplatesAsync(int businessId, ODataQuery oDataQuery = null, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TieredLeaveAllowanceTemplateApiModel>>($"/business/{businessId}/tieredleaveallowancetemplate{ODataQuery.ToQueryString(oDataQuery, "?")}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Creates a new Tiered Leave Allowance template for the business.
        /// </remarks>
        public TieredLeaveAllowanceTemplateApiModel CreateTieredLeaveAllowanceTemplate(int businessId, TieredLeaveAllowanceTemplateApiModel tieredLeaveAllowanceTemplate)
        {
            return ApiRequest<TieredLeaveAllowanceTemplateApiModel,TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate", tieredLeaveAllowanceTemplate, Method.Post);
        }

        /// <summary>
        /// Create Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Creates a new Tiered Leave Allowance template for the business.
        /// </remarks>
        public Task<TieredLeaveAllowanceTemplateApiModel> CreateTieredLeaveAllowanceTemplateAsync(int businessId, TieredLeaveAllowanceTemplateApiModel tieredLeaveAllowanceTemplate, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TieredLeaveAllowanceTemplateApiModel,TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate", tieredLeaveAllowanceTemplate, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Tiered Leave Allowance Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public TieredLeaveAllowanceTemplateApiModel GetTieredLeaveAllowanceTemplateById(int businessId, int id)
        {
            return ApiRequest<TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate/{id}", Method.Get);
        }

        /// <summary>
        /// Get Tiered Leave Allowance Template by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public Task<TieredLeaveAllowanceTemplateApiModel> GetTieredLeaveAllowanceTemplateByIdAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Updates the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public TieredLeaveAllowanceTemplateApiModel UpdateTieredLeaveAllowanceTemplate(int businessId, int id, TieredLeaveAllowanceTemplateApiModel tieredLeaveAllowanceTemplate)
        {
            return ApiRequest<TieredLeaveAllowanceTemplateApiModel,TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate/{id}", tieredLeaveAllowanceTemplate, Method.Put);
        }

        /// <summary>
        /// Update Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Updates the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public Task<TieredLeaveAllowanceTemplateApiModel> UpdateTieredLeaveAllowanceTemplateAsync(int businessId, int id, TieredLeaveAllowanceTemplateApiModel tieredLeaveAllowanceTemplate, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<TieredLeaveAllowanceTemplateApiModel,TieredLeaveAllowanceTemplateApiModel>($"/business/{businessId}/tieredleaveallowancetemplate/{id}", tieredLeaveAllowanceTemplate, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Deletes the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public void DeleteTieredLeaveAllowanceTemplate(int businessId, int id)
        {
            ApiRequest($"/business/{businessId}/tieredleaveallowancetemplate/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Tiered Leave Allowance Template
        /// </summary>
        /// <remarks>
        /// Deletes the Tiered Leave Allowance template with the specified ID.
        /// </remarks>
        public Task DeleteTieredLeaveAllowanceTemplateAsync(int businessId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/tieredleaveallowancetemplate/{id}", Method.Delete, cancellationToken);
        }
    }
}
