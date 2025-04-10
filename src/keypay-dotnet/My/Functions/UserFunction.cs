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
using KeyPayV2.My.Models.User;

namespace KeyPayV2.My.Functions
{
    public class UserFunction : BaseFunction
    {
        public UserFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get User Details
        /// </summary>
        /// <remarks>
        /// Gets details about the user.
        /// </remarks>
        public UserModel GetUserDetails()
        {
            return ApiRequest<UserModel>($"/user", Method.Get);
        }

        /// <summary>
        /// Get User Details
        /// </summary>
        /// <remarks>
        /// Gets details about the user.
        /// </remarks>
        public Task<UserModel> GetUserDetailsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UserModel>($"/user", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>
        /// This is currently restricted to updating the user's "email confirmation" status only.
        /// The API user (brand manager or reseller) must have brand exclusive access to the user
        /// i.e. the user must only have access to businesses/employees that the API user manages.
        /// </remarks>
        public UserUpdatedModel UpdateUser(UpdateUserModel model)
        {
            return ApiRequest<UserUpdatedModel,UpdateUserModel>($"/user", model, Method.Put);
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>
        /// This is currently restricted to updating the user's "email confirmation" status only.
        /// The API user (brand manager or reseller) must have brand exclusive access to the user
        /// i.e. the user must only have access to businesses/employees that the API user manages.
        /// </remarks>
        public Task<UserUpdatedModel> UpdateUserAsync(UpdateUserModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UserUpdatedModel,UpdateUserModel>($"/user", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create New User
        /// </summary>
        /// <remarks>
        /// Creates a new user and sends an email to inform the user.
        /// In order to make sure that the correct brand details are included in the email, be sure to `POST` the API request to `https://{yourbrand}.yourpayroll.com.au`.<br />
        /// To prevent sending of the new user email, set `apiOnly` to `true` in the request.
        /// </remarks>
        public NewUserCreatedModel CreateNewUser(NewUserModel model)
        {
            return ApiRequest<NewUserCreatedModel,NewUserModel>($"/user", model, Method.Post);
        }

        /// <summary>
        /// Create New User
        /// </summary>
        /// <remarks>
        /// Creates a new user and sends an email to inform the user.
        /// In order to make sure that the correct brand details are included in the email, be sure to `POST` the API request to `https://{yourbrand}.yourpayroll.com.au`.<br />
        /// To prevent sending of the new user email, set `apiOnly` to `true` in the request.
        /// </remarks>
        public Task<NewUserCreatedModel> CreateNewUserAsync(NewUserModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NewUserCreatedModel,NewUserModel>($"/user", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Related Businesses And Employees
        /// </summary>
        /// <remarks>
        /// List account information with businesses and employees linked to user.
        /// </remarks>
        public MyUserAccountMetadata ListRelatedBusinessesAndEmployees()
        {
            return ApiRequest<MyUserAccountMetadata>($"/user/account/metadata", Method.Get);
        }

        /// <summary>
        /// List Related Businesses And Employees
        /// </summary>
        /// <remarks>
        /// List account information with businesses and employees linked to user.
        /// </remarks>
        public Task<MyUserAccountMetadata> ListRelatedBusinessesAndEmployeesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<MyUserAccountMetadata>($"/user/account/metadata", Method.Get, cancellationToken);
        }
    }
}
