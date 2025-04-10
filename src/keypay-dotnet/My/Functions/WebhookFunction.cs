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
using KeyPayV2.My.Models.Webhook;

namespace KeyPayV2.My.Functions
{
    public class WebhookFunction : BaseFunction
    {
        public WebhookFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Web Hook Registrations
        /// </summary>
        /// <remarks>
        /// Returns a collection containing the registered web hook instances for the user.
        /// </remarks>
        public List<WebHook> ListWebHookRegistrations(int businessId)
        {
            return ApiRequest<List<WebHook>>($"/business/{businessId}/webhookregistrations", Method.Get);
        }

        /// <summary>
        /// List Web Hook Registrations
        /// </summary>
        /// <remarks>
        /// Returns a collection containing the registered web hook instances for the user.
        /// </remarks>
        public Task<List<WebHook>> ListWebHookRegistrationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<WebHook>>($"/business/{businessId}/webhookregistrations", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Register Web Hook
        /// </summary>
        /// <remarks>
        /// Registers a new web hook.
        /// </remarks>
        public WebHook RegisterWebHook(int businessId, WebHook webHook)
        {
            return ApiRequest<WebHook,WebHook>($"/business/{businessId}/webhookregistrations", webHook, Method.Post);
        }

        /// <summary>
        /// Register Web Hook
        /// </summary>
        /// <remarks>
        /// Registers a new web hook.
        /// </remarks>
        public Task<WebHook> RegisterWebHookAsync(int businessId, WebHook webHook, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<WebHook,WebHook>($"/business/{businessId}/webhookregistrations", webHook, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Delete all Web Hook Registrations
        /// </summary>
        /// <remarks>
        /// Deletes all the web hook registrations.
        /// </remarks>
        public void DeleteAllWebHookRegistrations(int businessId)
        {
            ApiRequest($"/business/{businessId}/webhookregistrations", Method.Delete);
        }

        /// <summary>
        /// Delete all Web Hook Registrations
        /// </summary>
        /// <remarks>
        /// Deletes all the web hook registrations.
        /// </remarks>
        public Task DeleteAllWebHookRegistrationsAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/webhookregistrations", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Get Web Hook Registration by ID
        /// </summary>
        /// <remarks>
        /// Gets the registered web hook instance with the specified ID.
        /// </remarks>
        public WebHook GetWebHookRegistrationById(int businessId, string id)
        {
            return ApiRequest<WebHook>($"/business/{businessId}/webhookregistrations/{id}", Method.Get);
        }

        /// <summary>
        /// Get Web Hook Registration by ID
        /// </summary>
        /// <remarks>
        /// Gets the registered web hook instance with the specified ID.
        /// </remarks>
        public Task<WebHook> GetWebHookRegistrationByIdAsync(int businessId, string id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<WebHook>($"/business/{businessId}/webhookregistrations/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Web Hook Registration
        /// </summary>
        /// <remarks>
        /// Updates the web hook registration with the specified ID.
        /// </remarks>
        public void UpdateWebHookRegistration(int businessId, string id, WebHook webHook)
        {
            ApiRequest($"/business/{businessId}/webhookregistrations/{id}", webHook, Method.Put);
        }

        /// <summary>
        /// Update Web Hook Registration
        /// </summary>
        /// <remarks>
        /// Updates the web hook registration with the specified ID.
        /// </remarks>
        public Task UpdateWebHookRegistrationAsync(int businessId, string id, WebHook webHook, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/webhookregistrations/{id}", webHook, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Web Hook Registration
        /// </summary>
        /// <remarks>
        /// Deletes the web hook registration with the specified ID.
        /// </remarks>
        public void DeleteWebHookRegistration(int businessId, string id)
        {
            ApiRequest($"/business/{businessId}/webhookregistrations/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Web Hook Registration
        /// </summary>
        /// <remarks>
        /// Deletes the web hook registration with the specified ID.
        /// </remarks>
        public Task DeleteWebHookRegistrationAsync(int businessId, string id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/webhookregistrations/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// Test Web Hook
        /// </summary>
        /// <remarks>
        /// Tests a web hook given a registration ID and a filter string.
        /// </remarks>
        public void TestWebHook(int businessId, string id, TestWebHookQueryModel request)
        {
            ApiRequest($"/business/{businessId}/webhookregistrations/{id}/test?filter={request.Filter}", Method.Get);
        }

        /// <summary>
        /// Test Web Hook
        /// </summary>
        /// <remarks>
        /// Tests a web hook given a registration ID and a filter string.
        /// </remarks>
        public Task TestWebHookAsync(int businessId, string id, TestWebHookQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/webhookregistrations/{id}/test?filter={request.Filter}", Method.Get, cancellationToken);
        }
    }
}
