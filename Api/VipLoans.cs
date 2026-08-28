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
using Binance.Models.Enums;

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
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order id</param>
    /// <param name="collateralAccountId"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipCollateralAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckLockedValueOfVipCollateralAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(IP): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipCollateralAccountResponse> CheckLockedValueOfVipCollateralAccountUserData(long timestamp,
        string signature,
        long? orderId,
        long? collateralAccountId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/collateral/account"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("collateralAccountId", collateralAccountId),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipCollateralAccountResponse>(),
            CheckLockedValueOfVipCollateralAccountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Borrow Interest Rate (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Max 10 assets, Multiple split by ","</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LoanVipRequestInterestRateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBorrowInterestRateUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get borrow interest rate.
    /// <para>
    /// Weight(UID): 400
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LoanVipRequestInterestRateResponse>> GetBorrowInterestRateUserData(long timestamp,
        string signature,
        string? loanCoin,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/request/interestRate"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LoanVipRequestInterestRateResponse>>(),
            GetBorrowInterestRateUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Collateral Asset Data (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipCollateralDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCollateralAssetDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get collateral asset data.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipCollateralDataResponse> GetCollateralAssetDataUserData(long timestamp,
        string signature,
        string? collateralCoin,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/collateral/data"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("collateralCoin", collateralCoin),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipCollateralDataResponse>(),
            GetCollateralAssetDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Loanable Assets Data
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="vipLevel">Defaults to user's vip level</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipLoanableDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLoanableAssetsDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get interest rate and borrow limit of loanable assets. The borrow limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipLoanableDataResponse> GetLoanableAssetsData(long timestamp,
        string signature,
        string? loanCoin,
        int? vipLevel,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/loanable/data"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("vipLevel", vipLevel),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipLoanableDataResponse>(),
            GetLoanableAssetsDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get VIP Loan Ongoing Orders (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order id</param>
    /// <param name="collateralAccountId"></param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">Default 10; max 100.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipOngoingOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVipLoanOngoingOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipOngoingOrdersResponse> GetVipLoanOngoingOrdersUserData(long timestamp,
        string signature,
        long? orderId,
        long? collateralAccountId,
        string? loanCoin,
        string? collateralCoin,
        int? current,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/ongoing/orders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("collateralAccountId", collateralAccountId),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipOngoingOrdersResponse>(),
            GetVipLoanOngoingOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get VIP Loan Repayment History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order id</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">Default 10; max 100.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipRepayHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVipLoanRepaymentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipRepayHistoryResponse> GetVipLoanRepaymentHistoryUserData(long timestamp,
        string signature,
        long? orderId,
        string? loanCoin,
        long? startTime,
        long? endTime,
        int? current,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/repay/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("loanCoin", loanCoin),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipRepayHistoryResponse>(),
            GetVipLoanRepaymentHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Application Status (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipRequestDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryApplicationStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Application Status
    /// <para>
    /// Weight(UID): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipRequestDataResponse> QueryApplicationStatusUserData(long timestamp,
        string signature,
        int? current,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/request/data"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipRequestDataResponse>(),
            QueryApplicationStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// VIP Loan Borrow
    /// </summary>
    /// <param name="loanAccountId"></param>
    /// <param name="loanAmount"></param>
    /// <param name="collateralAccountId"></param>
    /// <param name="collateralCoin"></param>
    /// <param name="isFlexibleRate"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="loanTerm"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipBorrowResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VipLoanBorrowError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipBorrowResponse> VipLoanBorrow(long loanAccountId,
        double loanAmount,
        string collateralAccountId,
        string collateralCoin,
        IsFlexibleRate isFlexibleRate,
        long timestamp,
        string signature,
        string? loanCoin,
        int? loanTerm,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/borrow"),
            [],
            [new Param("loanAccountId", loanAccountId),
                new Param("loanAmount", loanAmount),
                new Param("collateralAccountId", collateralAccountId),
                new Param("collateralCoin", collateralCoin),
                new Param("isFlexibleRate", isFlexibleRate),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("loanTerm", loanTerm),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipBorrowResponse>(),
            VipLoanBorrowErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// VIP Loan Renew
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order id</param>
    /// <param name="loanTerm"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipRenewResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VipLoanRenewError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipRenewResponse> VipLoanRenew(long timestamp,
        string signature,
        long? orderId,
        int? loanTerm,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/renew"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("loanTerm", loanTerm),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipRenewResponse>(),
            VipLoanRenewErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// VIP Loan Repay (TRADE)
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order id</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanVipRepayResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VipLoanRepayTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// VIP loan is available for VIP users only.
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanVipRepayResponse> VipLoanRepayTrade(double amount,
        long timestamp,
        string signature,
        long? orderId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/vip/repay"),
            [],
            [new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanVipRepayResponse>(),
            VipLoanRepayTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
