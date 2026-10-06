using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core;
using Binance.Core.Exceptions;
using Binance.Core.Models;
using Binance.Core.Request;
using Binance.Core.Response;
using Binance.Errors;
using Binance.Models;
using Binance.Requests.VipLoans;

namespace Binance.Api;

/// <summary>
/// VIP Loans Endpoints
/// </summary>
public sealed class VipLoans
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VipLoans(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Check Locked Value of VIP Collateral Account (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipCollateralAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CheckLockedValueOfVipCollateralAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(IP): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipCollateralAccountResponse> CheckLockedValueOfVipCollateralAccountUserData(CheckLockedValueOfVipCollateralAccountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/collateral/account"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("collateralAccountId", request.CollateralAccountId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipCollateralAccountResponse>(),
            CheckLockedValueOfVipCollateralAccountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Borrow Interest Rate (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LoanVipRequestInterestRateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBorrowInterestRateUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get borrow interest rate.
    /// <para>
    /// Weight(UID): 400
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LoanVipRequestInterestRateResponse>> GetBorrowInterestRateUserData(GetBorrowInterestRateUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/request/interestRate"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LoanVipRequestInterestRateResponse>>(),
            GetBorrowInterestRateUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Collateral Asset Data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipCollateralDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCollateralAssetDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get collateral asset data.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipCollateralDataResponse> GetCollateralAssetDataUserData(GetCollateralAssetDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/collateral/data"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipCollateralDataResponse>(),
            GetCollateralAssetDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Loanable Assets Data
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipLoanableDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLoanableAssetsDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get interest rate and borrow limit of loanable assets. The borrow limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipLoanableDataResponse> GetLoanableAssetsData(GetLoanableAssetsDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/loanable/data"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("vipLevel", request.VipLevel),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipLoanableDataResponse>(),
            GetLoanableAssetsDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get VIP Loan Ongoing Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipOngoingOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetVipLoanOngoingOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipOngoingOrdersResponse> GetVipLoanOngoingOrdersUserData(GetVipLoanOngoingOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/ongoing/orders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("collateralAccountId", request.CollateralAccountId),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipOngoingOrdersResponse>(),
            GetVipLoanOngoingOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get VIP Loan Repayment History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipRepayHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetVipLoanRepaymentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipRepayHistoryResponse> GetVipLoanRepaymentHistoryUserData(GetVipLoanRepaymentHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/repay/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("loanCoin", request.LoanCoin),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipRepayHistoryResponse>(),
            GetVipLoanRepaymentHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Application Status (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipRequestDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryApplicationStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Application Status
    /// <para>
    /// Weight(UID): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipRequestDataResponse> QueryApplicationStatusUserData(QueryApplicationStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/request/data"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipRequestDataResponse>(),
            QueryApplicationStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// VIP Loan Borrow
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipBorrowResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="VipLoanBorrowError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipBorrowResponse> VipLoanBorrow(VipLoanBorrowRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/borrow"),
            [],
            [
                new Param("loanAccountId", request.LoanAccountId),
                new Param("loanAmount", request.LoanAmount),
                new Param("collateralAccountId", request.CollateralAccountId),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("isFlexibleRate", request.IsFlexibleRate),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("loanTerm", request.LoanTerm),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipBorrowResponse>(),
            VipLoanBorrowError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// VIP Loan Renew
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipRenewResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="VipLoanRenewError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipRenewResponse> VipLoanRenew(VipLoanRenewRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/renew"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("loanTerm", request.LoanTerm),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipRenewResponse>(),
            VipLoanRenewError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// VIP Loan Repay (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipRepayResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="VipLoanRepayTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipRepayResponse> VipLoanRepayTrade(VipLoanRepayTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/vip/repay"),
            [],
            [
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipRepayResponse>(),
            VipLoanRepayTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
