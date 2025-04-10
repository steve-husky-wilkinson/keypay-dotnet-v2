using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Models.Authentication;

namespace KeyPayV2.Uk.Functions
{
    public class AuthenticationFunction : BaseFunction
    {
        public AuthenticationFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(int businessId, int employeeId, SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/employee/{employeeId}/singlesignon", model, Method.Post);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public Task<SingleSignOnResponseModel> SingleSignOnAsync(int businessId, int employeeId, SingleSignOnRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/employee/{employeeId}/singlesignon", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(int businessId, SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/singlesignon", model, Method.Post);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public Task<SingleSignOnResponseModel> SingleSignOnAsync(int businessId, SingleSignOnRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/business/{businessId}/singlesignon", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public SingleSignOnResponseModel SingleSignOn(SingleSignOnRequestModel model)
        {
            return ApiRequest<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/singlesignon", model, Method.Post);
        }

        /// <summary>
        /// Single Sign On
        /// </summary>
        /// <remarks>
        /// Request for SSO URL that provides authenticated access to KeyPay. See the guide on <a href="http://api.keypay.com.au/guides/SSO">SSO Requests</a> for more details.
        /// </remarks>
        public Task<SingleSignOnResponseModel> SingleSignOnAsync(SingleSignOnRequestModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SingleSignOnResponseModel,SingleSignOnRequestModel>($"/singlesignon", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// OAuth Token
        /// </summary>
        /// <remarks>
        /// See the guide on <a href="http://api.keypay.com.au/guides/OAuth2">OAuth2 authentication</a> for more details.
        /// </remarks>
        public void OauthToken(OauthTokenQueryModel request)
        {
            ApiRequest($"/oauth/token?request={request.Request}", Method.Post);
        }

        /// <summary>
        /// OAuth Token
        /// </summary>
        /// <remarks>
        /// See the guide on <a href="http://api.keypay.com.au/guides/OAuth2">OAuth2 authentication</a> for more details.
        /// </remarks>
        public Task OauthTokenAsync(OauthTokenQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/oauth/token?request={request.Request}", Method.Post, cancellationToken);
        }
    }
}
