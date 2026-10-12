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
using Binance.Models.AnyOf;
using Binance.Requests.CryptoLoans;

namespace Binance.Api;

/// <summary>
/// Crypto Loans Endpoints
/// </summary>
public sealed class CryptoLoans
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CryptoLoans(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Adjust LTV - Flexible Loan Adjust LTV (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleAdjustLtvResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AdjustLtvFlexibleLoanAdjustLtvTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>API Key needs Spot &amp; Margin Trading permission for this endpoint</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleAdjustLtvResponse> AdjustLtvFlexibleLoanAdjustLtvTrade(AdjustLtvFlexibleLoanAdjustLtvTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/adjust/ltv"),
            [],
            [
                new Param("adjustmentAmount", request.AdjustmentAmount),
                new Param("direction", request.Direction),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleAdjustLtvResponse>(),
            AdjustLtvFlexibleLoanAdjustLtvTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Adjust LTV - Get Flexible Loan LTV Adjustment History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleLtvAdjustmentHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 90-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 180 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleLtvAdjustmentHistoryResponse> AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData(AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/ltv/adjustment/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleLtvAdjustmentHistoryResponse>(),
            AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Borrow - Flexible Loan Borrow (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleBorrowResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BorrowFlexibleLoanBorrowTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Only available for master account</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleBorrowResponse> BorrowFlexibleLoanBorrowTrade(BorrowFlexibleLoanBorrowTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/borrow"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("loanAmount", request.LoanAmount),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("collateralAmount", request.CollateralAmount),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleBorrowResponse>(),
            BorrowFlexibleLoanBorrowTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Borrow - Get Flexible Loan Borrow History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleBorrowHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BorrowGetFlexibleLoanBorrowHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 90-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 180 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleBorrowHistoryResponse> BorrowGetFlexibleLoanBorrowHistoryUserData(BorrowGetFlexibleLoanBorrowHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/borrow/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleBorrowHistoryResponse>(),
            BorrowGetFlexibleLoanBorrowHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Borrow - Get Flexible Loan Ongoing Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleOngoingOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BorrowGetFlexibleLoanOngoingOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 300
    /// </remarks>
    public Task<SapiV2LoanFlexibleOngoingOrdersResponse> BorrowGetFlexibleLoanOngoingOrdersUserData(BorrowGetFlexibleLoanOngoingOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/ongoing/orders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleOngoingOrdersResponse>(),
            BorrowGetFlexibleLoanOngoingOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Check Collateral Repay Rate (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanRepayCollateralRateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CheckCollateralRepayRateUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the the rate of collateral coin / loan coin when using collateral repay, the rate will be valid within 8 second.
    /// <para>
    /// Weight(IP): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanRepayCollateralRateResponse> CheckCollateralRepayRateUserData(CheckCollateralRepayRateUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/repay/collateral/rate"),
            [],
            [
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("repayAmount", request.RepayAmount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanRepayCollateralRateResponse>(),
            CheckCollateralRepayRateUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Crypto Loan Adjust LTV (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanAdjustLtvResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CryptoLoanAdjustLtvTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 6000
    /// </remarks>
    public Task<SapiV1LoanAdjustLtvResponse> CryptoLoanAdjustLtvTrade(CryptoLoanAdjustLtvTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/adjust/ltv"),
            [],
            [
                new Param("orderId", request.OrderId),
                new Param("amount", request.Amount),
                new Param("direction", request.Direction),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanAdjustLtvResponse>(),
            CryptoLoanAdjustLtvTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Crypto Loan Borrow (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanBorrowResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CryptoLoanBorrowTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 6000
    /// </remarks>
    public Task<SapiV1LoanBorrowResponse> CryptoLoanBorrowTrade(CryptoLoanBorrowTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/borrow"),
            [],
            [
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("loanTerm", request.LoanTerm),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanAmount", request.LoanAmount),
                new Param("collateralAmount", request.CollateralAmount),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanBorrowResponse>(),
            CryptoLoanBorrowTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Crypto Loan Customize Margin Call (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanCustomizeMarginCallResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CryptoLoanCustomizeMarginCallTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Customize margin call for ongoing orders only.
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanCustomizeMarginCallResponse> CryptoLoanCustomizeMarginCallTrade(CryptoLoanCustomizeMarginCallTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/customize/margin_call"),
            [],
            [
                new Param("marginCall", request.MarginCall),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanCustomizeMarginCallResponse>(),
            CryptoLoanCustomizeMarginCallTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Crypto Loan Repay (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanRepayResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CryptoLoanRepayTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 6000
    /// </remarks>
    public Task<SapiV1LoanRepayResponse> CryptoLoanRepayTrade(CryptoLoanRepayTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/repay"),
            [],
            [
                new Param("orderId", request.OrderId),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("type", request.Type),
                new Param("collateralReturn", request.CollateralReturn),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanRepayResponse>(),
            CryptoLoanRepayTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Collateral Assets Data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanCollateralDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCollateralAssetsDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get LTV information and collateral limit of collateral assets. The collateral limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanCollateralDataResponse> GetCollateralAssetsDataUserData(GetCollateralAssetsDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/collateral/data"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("vipLevel", request.VipLevel),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanCollateralDataResponse>(),
            GetCollateralAssetsDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Crypto Loans Borrow History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanBorrowHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCryptoLoansBorrowHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 90-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 180 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanBorrowHistoryResponse> GetCryptoLoansBorrowHistoryUserData(GetCryptoLoansBorrowHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/borrow/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanBorrowHistoryResponse>(),
            GetCryptoLoansBorrowHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Crypto Loans Income History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LoanIncomeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCryptoLoansIncomeHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 7-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 30 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LoanIncomeResponse>> GetCryptoLoansIncomeHistoryUserData(GetCryptoLoansIncomeHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/income"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("type", request.Type),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LoanIncomeResponse>>(),
            GetCryptoLoansIncomeHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Flexible Loan Assets Data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleLoanableDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFlexibleLoanAssetsDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get interest rate and borrow limit of flexible loanable assets. The borrow limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleLoanableDataResponse> GetFlexibleLoanAssetsDataUserData(GetFlexibleLoanAssetsDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/loanable/data"),
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
            JsonResponse.Create<SapiV2LoanFlexibleLoanableDataResponse>(),
            GetFlexibleLoanAssetsDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Flexible Loan Collateral Assets Data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleCollateralDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFlexibleLoanCollateralAssetsDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get LTV information and collateral limit of flexible loan's collateral assets. The collateral limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleCollateralDataResponse> GetFlexibleLoanCollateralAssetsDataUserData(GetFlexibleLoanCollateralAssetsDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/collateral/data"),
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
            JsonResponse.Create<SapiV2LoanFlexibleCollateralDataResponse>(),
            GetFlexibleLoanCollateralAssetsDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Loan LTV Adjustment History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanLtvAdjustmentHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLoanLtvAdjustmentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// If startTime and endTime are not sent, the recent 90-day data will be returned.
    /// The max interval between startTime and endTime is 180 days.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanLtvAdjustmentHistoryResponse> GetLoanLtvAdjustmentHistoryUserData(GetLoanLtvAdjustmentHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/ltv/adjustment/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanLtvAdjustmentHistoryResponse>(),
            GetLoanLtvAdjustmentHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Loan Ongoing Orders (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanOngoingOrdersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLoanOngoingOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 300
    /// </remarks>
    public Task<SapiV1LoanOngoingOrdersResponse> GetLoanOngoingOrdersUserData(GetLoanOngoingOrdersUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/ongoing/orders"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanOngoingOrdersResponse>(),
            GetLoanOngoingOrdersUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Loan Repayment History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanRepayHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLoanRepaymentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// If startTime and endTime are not sent, the recent 90-day data will be returned.
    /// The max interval between startTime and endTime is 180 days.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanRepayHistoryResponse> GetLoanRepaymentHistoryUserData(GetLoanRepaymentHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/repay/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("orderId", request.OrderId),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanRepayHistoryResponse>(),
            GetLoanRepaymentHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Loanable Assets Data (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanLoanableDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLoanableAssetsDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get interest rate and borrow limit of loanable assets. The borrow limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanLoanableDataResponse> GetLoanableAssetsDataUserData(GetLoanableAssetsDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/loan/loanable/data"),
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
            JsonResponse.Create<SapiV1LoanLoanableDataResponse>(),
            GetLoanableAssetsDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Repay - Flexible Loan Repay (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleRepayResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RepayFlexibleLoanRepayTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>repayAmount is mandatory even fullRepayment = FALSE</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleRepayResponse> RepayFlexibleLoanRepayTrade(RepayFlexibleLoanRepayTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/repay"),
            [],
            [
                new Param("repayAmount", request.RepayAmount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("collateralReturn", request.CollateralReturn),
                new Param("fullRepayment", request.FullRepayment),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleRepayResponse>(),
            RepayFlexibleLoanRepayTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Repay - Get Flexible Loan Repayment History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleRepayHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RepayGetFlexibleLoanRepaymentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 90-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 180 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleRepayHistoryResponse> RepayGetFlexibleLoanRepaymentHistoryUserData(RepayGetFlexibleLoanRepaymentHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/loan/flexible/repay/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("loanCoin", request.LoanCoin),
                new Param("collateralCoin", request.CollateralCoin),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleRepayHistoryResponse>(),
            RepayGetFlexibleLoanRepaymentHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
