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
using KeyPayV2.Uk.Models.EmployeeRecurringTransactions;

namespace KeyPayV2.Uk.Functions
{
    public class EmployeeRecurringTransactionsFunction : BaseFunction
    {
        public EmployeeRecurringTransactionsFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Employee Additional Earnings
        /// </summary>
        /// <remarks>
        /// Lists all the additional earnings for the employee
        /// </remarks>
        public List<AdditionalEarningsModel> ListEmployeeAdditionalEarnings(int businessId, int employeeId)
        {
            return ApiRequest<List<AdditionalEarningsModel>>($"/business/{businessId}/employee/{employeeId}/additional-earnings", Method.Get);
        }

        /// <summary>
        /// List Employee Additional Earnings
        /// </summary>
        /// <remarks>
        /// Lists all the additional earnings for the employee
        /// </remarks>
        public Task<List<AdditionalEarningsModel>> ListEmployeeAdditionalEarningsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AdditionalEarningsModel>>($"/business/{businessId}/employee/{employeeId}/additional-earnings", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Creates a new additional earning for the employee.
        /// </remarks>
        public AdditionalEarningsModel CreateEmployeeAdditionalEarning(int businessId, int employeeId, AdditionalEarningsInputModel model)
        {
            return ApiRequest<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Creates a new additional earning for the employee.
        /// </remarks>
        public Task<AdditionalEarningsModel> CreateEmployeeAdditionalEarningAsync(int businessId, int employeeId, AdditionalEarningsInputModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Additional Earning by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's additional earning with the specified ID.
        /// </remarks>
        public AdditionalEarningsModel GetEmployeeAdditionalEarningById(int businessId, int employeeId, int id)
        {
            return ApiRequest<AdditionalEarningsModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Additional Earning by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's additional earning with the specified ID.
        /// </remarks>
        public Task<AdditionalEarningsModel> GetEmployeeAdditionalEarningByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Updates the employee's additional earning with the specified ID.
        /// </remarks>
        public AdditionalEarningsModel UpdateEmployeeAdditionalEarning(int businessId, int employeeId, int id, AdditionalEarningsInputModel model)
        {
            return ApiRequest<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Updates the employee's additional earning with the specified ID.
        /// </remarks>
        public Task<AdditionalEarningsModel> UpdateEmployeeAdditionalEarningAsync(int businessId, int employeeId, int id, AdditionalEarningsInputModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<AdditionalEarningsModel,AdditionalEarningsInputModel>($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Deletes the employee's additional earning with the specified ID.
        /// </remarks>
        public void DeleteEmployeeAdditionalEarning(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Additional Earning
        /// </summary>
        /// <remarks>
        /// Deletes the employee's additional earning with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeAdditionalEarningAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/additional-earnings/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Deductions
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions for the employee
        /// </remarks>
        public List<UkEmployeeRecurringDeductionModel> ListEmployeeDeductions(int businessId, int employeeId)
        {
            return ApiRequest<List<UkEmployeeRecurringDeductionModel>>($"/business/{businessId}/employee/{employeeId}/deduction", Method.Get);
        }

        /// <summary>
        /// List Employee Deductions
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions for the employee
        /// </remarks>
        public Task<List<UkEmployeeRecurringDeductionModel>> ListEmployeeDeductionsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkEmployeeRecurringDeductionModel>>($"/business/{businessId}/employee/{employeeId}/deduction", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Deduction
        /// </summary>
        /// <remarks>
        /// Creates a new recurring deduction for the employee.
        /// </remarks>
        public UkEmployeeRecurringDeductionModel CreateEmployeeDeduction(int businessId, int employeeId, UkEmployeeRecurringDeductionModel model)
        {
            return ApiRequest<UkEmployeeRecurringDeductionModel,UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Deduction
        /// </summary>
        /// <remarks>
        /// Creates a new recurring deduction for the employee.
        /// </remarks>
        public Task<UkEmployeeRecurringDeductionModel> CreateEmployeeDeductionAsync(int businessId, int employeeId, UkEmployeeRecurringDeductionModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeRecurringDeductionModel,UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Deduction by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified external reference ID.
        /// </remarks>
        public UkEmployeeRecurringDeductionModel GetEmployeeDeductionByExternalReferenceId(int businessId, int employeeId, string externalReferenceId)
        {
            return ApiRequest<UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{externalReferenceId}", Method.Get);
        }

        /// <summary>
        /// Get Employee Deduction by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified external reference ID.
        /// </remarks>
        public Task<UkEmployeeRecurringDeductionModel> GetEmployeeDeductionByExternalReferenceIdAsync(int businessId, int employeeId, string externalReferenceId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{externalReferenceId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Employee Deduction by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified ID.
        /// </remarks>
        public UkEmployeeRecurringDeductionModel GetEmployeeDeductionById(int businessId, int employeeId, int id)
        {
            return ApiRequest<UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Deduction by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring deduction with the specified ID.
        /// </remarks>
        public Task<UkEmployeeRecurringDeductionModel> GetEmployeeDeductionByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Deduction
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring deduction with the specified ID.
        /// </remarks>
        public UkEmployeeRecurringDeductionModel UpdateEmployeeDeduction(int businessId, int employeeId, int id, UkEmployeeRecurringDeductionModel model)
        {
            return ApiRequest<UkEmployeeRecurringDeductionModel,UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Deduction
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring deduction with the specified ID.
        /// </remarks>
        public Task<UkEmployeeRecurringDeductionModel> UpdateEmployeeDeductionAsync(int businessId, int employeeId, int id, UkEmployeeRecurringDeductionModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEmployeeRecurringDeductionModel,UkEmployeeRecurringDeductionModel>($"/business/{businessId}/employee/{employeeId}/deduction/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring deduction with the specified ID.
        /// </remarks>
        public void DeleteEmployeeDeduction(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Deduction
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring deduction with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeDeductionAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/deduction/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employer liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employer liabilities for the employee
        /// </remarks>
        public List<EmployerRecurringLiabilityModel> ListEmployerLiabilities(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployerRecurringLiabilityModel>>($"/business/{businessId}/employee/{employeeId}/employerliability", Method.Get);
        }

        /// <summary>
        /// List Employer liabilities
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employer liabilities for the employee
        /// </remarks>
        public Task<List<EmployerRecurringLiabilityModel>> ListEmployerLiabilitiesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployerRecurringLiabilityModel>>($"/business/{businessId}/employee/{employeeId}/employerliability", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employer liability
        /// </summary>
        /// <remarks>
        /// Creates a new recurring employer liability for the employee.
        /// </remarks>
        public EmployerRecurringLiabilityModel CreateEmployerLiability(int businessId, int employeeId, EmployerRecurringLiabilityModel model)
        {
            return ApiRequest<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability", model, Method.Post);
        }

        /// <summary>
        /// Create Employer liability
        /// </summary>
        /// <remarks>
        /// Creates a new recurring employer liability for the employee.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> CreateEmployerLiabilityAsync(int businessId, int employeeId, EmployerRecurringLiabilityModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employer liability by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring employer liabilities with the specified ID.
        /// </remarks>
        public EmployerRecurringLiabilityModel GetEmployerLiabilityById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employer liability by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring employer liabilities with the specified ID.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> GetEmployerLiabilityByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employer liability
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring employer liability with the specified ID.
        /// </remarks>
        public EmployerRecurringLiabilityModel UpdateEmployerLiability(int businessId, int employeeId, int id, EmployerRecurringLiabilityModel model)
        {
            return ApiRequest<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employer liability
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring employer liability with the specified ID.
        /// </remarks>
        public Task<EmployerRecurringLiabilityModel> UpdateEmployerLiabilityAsync(int businessId, int employeeId, int id, EmployerRecurringLiabilityModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployerRecurringLiabilityModel,EmployerRecurringLiabilityModel>($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employer liability
        /// </summary>
        /// <remarks>
        /// Deletes the recurring employer liability with the specified ID.
        /// </remarks>
        public void DeleteEmployerLiability(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employer liability
        /// </summary>
        /// <remarks>
        /// Deletes the recurring employer liability with the specified ID.
        /// </remarks>
        public Task DeleteEmployerLiabilityAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/employerliability/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee expenses for the employee
        /// </remarks>
        public List<EmployeeRecurringExpenseModel> ListEmployeeExpenses(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringExpenseModel>>($"/business/{businessId}/employee/{employeeId}/expense", Method.Get);
        }

        /// <summary>
        /// List Employee Expenses
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee expenses for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringExpenseModel>> ListEmployeeExpensesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringExpenseModel>>($"/business/{businessId}/employee/{employeeId}/expense", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Expense
        /// </summary>
        /// <remarks>
        /// Creates a new recurring expense for the employee.
        /// </remarks>
        public EmployeeRecurringExpenseModel CreateEmployeeExpense(int businessId, int employeeId, EmployeeRecurringExpenseModel model)
        {
            return ApiRequest<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Expense
        /// </summary>
        /// <remarks>
        /// Creates a new recurring expense for the employee.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> CreateEmployeeExpenseAsync(int businessId, int employeeId, EmployeeRecurringExpenseModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Expense by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring expense with the specified ID.
        /// </remarks>
        public EmployeeRecurringExpenseModel GetEmployeeExpenseById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Expense by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring expense with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> GetEmployeeExpenseByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Expense
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring expense with the specified ID.
        /// </remarks>
        public EmployeeRecurringExpenseModel UpdateEmployeeExpense(int businessId, int employeeId, int id, EmployeeRecurringExpenseModel model)
        {
            return ApiRequest<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Expense
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring expense with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringExpenseModel> UpdateEmployeeExpenseAsync(int businessId, int employeeId, int id, EmployeeRecurringExpenseModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringExpenseModel,EmployeeRecurringExpenseModel>($"/business/{businessId}/employee/{employeeId}/expense/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring expense with the specified ID.
        /// </remarks>
        public void DeleteEmployeeExpense(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Expense
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring expense with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeExpenseAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/expense/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Hmrc Adjustments
        /// </summary>
        /// <remarks>
        /// List all the HMRC adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringHmrcAdjustmentModel> ListHmrcAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringHmrcAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment", Method.Get);
        }

        /// <summary>
        /// List Hmrc Adjustments
        /// </summary>
        /// <remarks>
        /// List all the HMRC adjustments for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringHmrcAdjustmentModel>> ListHmrcAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringHmrcAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Or Update Employee HMRC Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a recurring HMRC adjustment for an employee
        /// </remarks>
        public EmployeeRecurringHmrcAdjustmentModel CreateOrUpdateEmployeeHmrcAdjustment(int businessId, int employeeId, EmployeeRecurringHmrcAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringHmrcAdjustmentModel,EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment", model, Method.Post);
        }

        /// <summary>
        /// Create Or Update Employee HMRC Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a recurring HMRC adjustment for an employee
        /// </remarks>
        public Task<EmployeeRecurringHmrcAdjustmentModel> CreateOrUpdateEmployeeHmrcAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringHmrcAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringHmrcAdjustmentModel,EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee HMRC adjustment by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring HMRC adjustment with the specified external reference ID.
        /// </remarks>
        public EmployeeRecurringHmrcAdjustmentModel GetEmployeeHmrcAdjustmentByExternalReferenceId(int businessId, int employeeId, string externalReferenceId)
        {
            return ApiRequest<EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{externalReferenceId}", Method.Get);
        }

        /// <summary>
        /// Get Employee HMRC adjustment by External Reference Id
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring HMRC adjustment with the specified external reference ID.
        /// </remarks>
        public Task<EmployeeRecurringHmrcAdjustmentModel> GetEmployeeHmrcAdjustmentByExternalReferenceIdAsync(int businessId, int employeeId, string externalReferenceId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{externalReferenceId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Hmrc Adjustment By Id
        /// </summary>
        /// <remarks>
        /// Gets a HMRC adjustment by a specific ID
        /// </remarks>
        public EmployeeRecurringHmrcAdjustmentModel GetHmrcAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{id}", Method.Get);
        }

        /// <summary>
        /// Get Hmrc Adjustment By Id
        /// </summary>
        /// <remarks>
        /// Gets a HMRC adjustment by a specific ID
        /// </remarks>
        public Task<EmployeeRecurringHmrcAdjustmentModel> GetHmrcAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringHmrcAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Hmrc Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee HMRC adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeHmrcAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Hmrc Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee HMRC adjustment with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeHmrcAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/hmrcadjustment/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Tax Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax adjustments for the employee
        /// </remarks>
        public List<EmployeeRecurringTaxAdjustmentModel> ListEmployeeTaxAdjustments(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeRecurringTaxAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxadjustment", Method.Get);
        }

        /// <summary>
        /// List Employee Tax Adjustments
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee tax adjustments for the employee
        /// </remarks>
        public Task<List<EmployeeRecurringTaxAdjustmentModel>> ListEmployeeTaxAdjustmentsAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeRecurringTaxAdjustmentModel>>($"/business/{businessId}/employee/{employeeId}/taxadjustment", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Create Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring tax adjustment for the employee.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel CreateEmployeeTaxAdjustment(int businessId, int employeeId, EmployeeRecurringTaxAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment", model, Method.Post);
        }

        /// <summary>
        /// Create Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Creates a new recurring tax adjustment for the employee.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> CreateEmployeeTaxAdjustmentAsync(int businessId, int employeeId, EmployeeRecurringTaxAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Get Employee Tax Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel GetEmployeeTaxAdjustmentById(int businessId, int employeeId, int id)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.Get);
        }

        /// <summary>
        /// Get Employee Tax Adjustment by ID
        /// </summary>
        /// <remarks>
        /// Gets the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> GetEmployeeTaxAdjustmentByIdAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public EmployeeRecurringTaxAdjustmentModel UpdateEmployeeTaxAdjustment(int businessId, int employeeId, int id, EmployeeRecurringTaxAdjustmentModel model)
        {
            return ApiRequest<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", model, Method.Put);
        }

        /// <summary>
        /// Update Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Updates the employee's recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task<EmployeeRecurringTaxAdjustmentModel> UpdateEmployeeTaxAdjustmentAsync(int businessId, int employeeId, int id, EmployeeRecurringTaxAdjustmentModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeRecurringTaxAdjustmentModel,EmployeeRecurringTaxAdjustmentModel>($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring tax adjustment with the specified ID.
        /// </remarks>
        public void DeleteEmployeeTaxAdjustment(int businessId, int employeeId, int id)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.Delete);
        }

        /// <summary>
        /// Delete Employee Tax Adjustment
        /// </summary>
        /// <remarks>
        /// Deletes the employee recurring tax adjustment with the specified ID.
        /// </remarks>
        public Task DeleteEmployeeTaxAdjustmentAsync(int businessId, int employeeId, int id, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/taxadjustment/{id}", Method.Delete, cancellationToken);
        }

        /// <summary>
        /// List Employee Deductions By External Reference Id
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions that have a matching external reference ID
        /// </remarks>
        public List<UkEmployeeRecurringDeductionModel> ListEmployeeDeductionsByExternalReferenceId(int businessId, IList<String> externalReferenceIds)
        {
            return ApiRequest<List<UkEmployeeRecurringDeductionModel>,IList<String>>($"/business/{businessId}/employee/deduction", externalReferenceIds, Method.Post);
        }

        /// <summary>
        /// List Employee Deductions By External Reference Id
        /// </summary>
        /// <remarks>
        /// Lists all the recurring employee deductions that have a matching external reference ID
        /// </remarks>
        public Task<List<UkEmployeeRecurringDeductionModel>> ListEmployeeDeductionsByExternalReferenceIdAsync(int businessId, IList<String> externalReferenceIds, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkEmployeeRecurringDeductionModel>,IList<String>>($"/business/{businessId}/employee/deduction", externalReferenceIds, Method.Post, cancellationToken);
        }
    }
}
