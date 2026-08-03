using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core;
using BinancePublicSpotApi.Core.Exceptions;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Core.Request;
using BinancePublicSpotApi.Core.Response;
using BinancePublicSpotApi.Errors;
using BinancePublicSpotApi.Models;
using BinancePublicSpotApi.Models.AnyOf;
using BinancePublicSpotApi.Models.Enums;

namespace BinancePublicSpotApi.Api;

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
    /// <param name="adjustmentAmount"></param>
    /// <param name="direction"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleAdjustLtvResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AdjustLtvFlexibleLoanAdjustLtvTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>API Key needs Spot &amp; Margin Trading permission for this endpoint</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleAdjustLtvResponse> AdjustLtvFlexibleLoanAdjustLtvTrade(double adjustmentAmount,
        Direction direction,
        long timestamp,
        string signature,
        string? loanCoin,
        string? collateralCoin,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/adjust/ltv"),
            [],
            [new Param("adjustmentAmount", adjustmentAmount),
                new Param("direction", direction),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleAdjustLtvResponse>(),
            AdjustLtvFlexibleLoanAdjustLtvTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Adjust LTV - Get Flexible Loan LTV Adjustment History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleLtvAdjustmentHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 90-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 180 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleLtvAdjustmentHistoryResponse> AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserData(long timestamp,
        string signature,
        string? loanCoin,
        string? collateralCoin,
        long? startTime,
        long? endTime,
        int? current,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/ltv/adjustment/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleLtvAdjustmentHistoryResponse>(),
            AdjustLtvGetFlexibleLoanLtvAdjustmentHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Borrow - Flexible Loan Borrow (TRADE)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="loanAmount">Loan amount</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="collateralAmount"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleBorrowResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BorrowFlexibleLoanBorrowTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Only available for master account</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleBorrowResponse> BorrowFlexibleLoanBorrowTrade(long timestamp,
        string signature,
        string? loanCoin,
        double? loanAmount,
        string? collateralCoin,
        double? collateralAmount,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/borrow"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("loanAmount", loanAmount),
                new Param("collateralCoin", collateralCoin),
                new Param("collateralAmount", collateralAmount),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleBorrowResponse>(),
            BorrowFlexibleLoanBorrowTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Borrow - Get Flexible Loan Borrow History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleBorrowHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BorrowGetFlexibleLoanBorrowHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 90-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 180 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleBorrowHistoryResponse> BorrowGetFlexibleLoanBorrowHistoryUserData(long timestamp,
        string signature,
        string? loanCoin,
        string? collateralCoin,
        long? startTime,
        long? endTime,
        int? current,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/borrow/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleBorrowHistoryResponse>(),
            BorrowGetFlexibleLoanBorrowHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Borrow - Get Flexible Loan Ongoing Orders (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleOngoingOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BorrowGetFlexibleLoanOngoingOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    ///
    /// Weight(IP): 300
    /// </remarks>
    public Task<SapiV2LoanFlexibleOngoingOrdersResponse> BorrowGetFlexibleLoanOngoingOrdersUserData(long timestamp,
        string signature,
        string? loanCoin,
        string? collateralCoin,
        int? current,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/ongoing/orders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleOngoingOrdersResponse>(),
            BorrowGetFlexibleLoanOngoingOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Check Collateral Repay Rate (USER_DATA)
    /// </summary>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="repayAmount">repay amount of loanCoin</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanRepayCollateralRateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckCollateralRepayRateUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the the rate of collateral coin / loan coin when using collateral repay, the rate will be valid within 8 second.
    /// <para>
    /// Weight(IP): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanRepayCollateralRateResponse> CheckCollateralRepayRateUserData(string loanCoin,
        string collateralCoin,
        double repayAmount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/repay/collateral/rate"),
            [],
            [new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("repayAmount", repayAmount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanRepayCollateralRateResponse>(),
            CheckCollateralRepayRateUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Loan Adjust LTV (TRADE)
    /// </summary>
    /// <param name="orderId">Order ID</param>
    /// <param name="amount">Amount</param>
    /// <param name="direction">'ADDITIONAL', 'REDUCED'</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanAdjustLtvResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CryptoLoanAdjustLtvTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 6000
    /// </remarks>
    public Task<SapiV1LoanAdjustLtvResponse> CryptoLoanAdjustLtvTrade(long orderId,
        double amount,
        Direction direction,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/adjust/ltv"),
            [],
            [new Param("orderId", orderId),
                new Param("amount", amount),
                new Param("direction", direction),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanAdjustLtvResponse>(),
            CryptoLoanAdjustLtvTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Loan Borrow (TRADE)
    /// </summary>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="loanTerm">7/14/30/90/180 days</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanAmount">Loan amount</param>
    /// <param name="collateralAmount"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanBorrowResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CryptoLoanBorrowTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 6000
    /// </remarks>
    public Task<SapiV1LoanBorrowResponse> CryptoLoanBorrowTrade(string loanCoin,
        string collateralCoin,
        int loanTerm,
        long timestamp,
        string signature,
        double? loanAmount,
        double? collateralAmount,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/borrow"),
            [],
            [new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("loanTerm", loanTerm),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanAmount", loanAmount),
                new Param("collateralAmount", collateralAmount),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanBorrowResponse>(),
            CryptoLoanBorrowTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Loan Customize Margin Call (TRADE)
    /// </summary>
    /// <param name="marginCall"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Mandatory when collateralCoin is empty. Send either orderId or collateralCoin, if both parameters are sent, take orderId only.</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanCustomizeMarginCallResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CryptoLoanCustomizeMarginCallTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Customize margin call for ongoing orders only.
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanCustomizeMarginCallResponse> CryptoLoanCustomizeMarginCallTrade(double marginCall,
        long timestamp,
        string signature,
        long? orderId,
        string? collateralCoin,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/customize/margin_call"),
            [],
            [new Param("marginCall", marginCall),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("collateralCoin", collateralCoin),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanCustomizeMarginCallResponse>(),
            CryptoLoanCustomizeMarginCallTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Loan Repay (TRADE)
    /// </summary>
    /// <param name="orderId">Order ID</param>
    /// <param name="amount">Repayment Amount</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="type">Default: 1. 1 for 'repay with borrowed coin'; 2 for 'repay with collateral'.</param>
    /// <param name="collateralReturn">Default: TRUE. TRUE: Return extra collateral to spot account; FALSE: Keep extra collateral in the order.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanRepayResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CryptoLoanRepayTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 6000
    /// </remarks>
    public Task<SapiV1LoanRepayResponse> CryptoLoanRepayTrade(long orderId,
        double amount,
        long timestamp,
        string signature,
        int? type,
        bool? collateralReturn,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/repay"),
            [],
            [new Param("orderId", orderId),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("type", type),
                new Param("collateralReturn", collateralReturn),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanRepayResponse>(),
            CryptoLoanRepayTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Collateral Assets Data (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="vipLevel">Defaults to user's vip level</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanCollateralDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCollateralAssetsDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get LTV information and collateral limit of collateral assets. The collateral limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanCollateralDataResponse> GetCollateralAssetsDataUserData(long timestamp,
        string signature,
        string? collateralCoin,
        int? vipLevel,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/collateral/data"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("collateralCoin", collateralCoin),
                new Param("vipLevel", vipLevel),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanCollateralDataResponse>(),
            GetCollateralAssetsDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Crypto Loans Borrow History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">orderId in POST /sapi/v1/loan/borrow</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">default 10, max 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanBorrowHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCryptoLoansBorrowHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 90-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 180 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanBorrowHistoryResponse> GetCryptoLoansBorrowHistoryUserData(long timestamp,
        string signature,
        long? orderId,
        string? loanCoin,
        string? collateralCoin,
        long? startTime,
        long? endTime,
        int? current,
        long? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/borrow/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanBorrowHistoryResponse>(),
            GetCryptoLoansBorrowHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Crypto Loans Income History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="type">All types will be returned by default.   * <c>borrowIn</c>   * <c>collateralSpent</c>   * <c>repayAmount</c>   * <c>collateralReturn</c> - Collateral return after repayment   * <c>addCollateral</c>   * <c>removeCollateral</c>   * <c>collateralReturnAfterLiquidation</c></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">default 20, max 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1LoanIncomeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCryptoLoansIncomeHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 7-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 30 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 6000
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1LoanIncomeResponse>> GetCryptoLoansIncomeHistoryUserData(long timestamp,
        string signature,
        string? asset,
        Type9? type,
        long? startTime,
        long? endTime,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/income"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("type", type),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1LoanIncomeResponse>>(),
            GetCryptoLoansIncomeHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Flexible Loan Assets Data (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleLoanableDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFlexibleLoanAssetsDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get interest rate and borrow limit of flexible loanable assets. The borrow limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleLoanableDataResponse> GetFlexibleLoanAssetsDataUserData(long timestamp,
        string signature,
        string? loanCoin,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/loanable/data"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleLoanableDataResponse>(),
            GetFlexibleLoanAssetsDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Flexible Loan Collateral Assets Data (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleCollateralDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFlexibleLoanCollateralAssetsDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get LTV information and collateral limit of flexible loan's collateral assets. The collateral limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleCollateralDataResponse> GetFlexibleLoanCollateralAssetsDataUserData(long timestamp,
        string signature,
        string? collateralCoin,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/collateral/data"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("collateralCoin", collateralCoin),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleCollateralDataResponse>(),
            GetFlexibleLoanCollateralAssetsDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Loan LTV Adjustment History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order ID</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">default 10, max 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanLtvAdjustmentHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLoanLtvAdjustmentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// If startTime and endTime are not sent, the recent 90-day data will be returned.
    /// The max interval between startTime and endTime is 180 days.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanLtvAdjustmentHistoryResponse> GetLoanLtvAdjustmentHistoryUserData(long timestamp,
        string signature,
        long? orderId,
        string? loanCoin,
        string? collateralCoin,
        long? startTime,
        long? endTime,
        int? current,
        long? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/ltv/adjustment/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanLtvAdjustmentHistoryResponse>(),
            GetLoanLtvAdjustmentHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Loan Ongoing Orders (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">orderId in POST /sapi/v1/loan/borrow</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="current">Current querying page. Start from 1; default:1, max:1000</param>
    /// <param name="limit">default 10, max 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanOngoingOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLoanOngoingOrdersUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 300
    /// </remarks>
    public Task<SapiV1LoanOngoingOrdersResponse> GetLoanOngoingOrdersUserData(long timestamp,
        string signature,
        long? orderId,
        string? loanCoin,
        string? collateralCoin,
        int? current,
        long? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/ongoing/orders"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanOngoingOrdersResponse>(),
            GetLoanOngoingOrdersUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Loan Repayment History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="orderId">Order ID</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">default 10, max 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanRepayHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLoanRepaymentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// If startTime and endTime are not sent, the recent 90-day data will be returned.
    /// The max interval between startTime and endTime is 180 days.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanRepayHistoryResponse> GetLoanRepaymentHistoryUserData(long timestamp,
        string signature,
        long? orderId,
        string? loanCoin,
        string? collateralCoin,
        long? startTime,
        long? endTime,
        int? current,
        long? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/repay/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("orderId", orderId),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanRepayHistoryResponse>(),
            GetLoanRepaymentHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Loanable Assets Data (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="vipLevel">Defaults to user's vip level</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1LoanLoanableDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLoanableAssetsDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get interest rate and borrow limit of loanable assets. The borrow limit is shown in USD value.
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV1LoanLoanableDataResponse> GetLoanableAssetsDataUserData(long timestamp,
        string signature,
        string? loanCoin,
        int? vipLevel,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/loan/loanable/data"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("vipLevel", vipLevel),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1LoanLoanableDataResponse>(),
            GetLoanableAssetsDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Repay - Flexible Loan Repay (TRADE)
    /// </summary>
    /// <param name="repayAmount">repay amount of loanCoin</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="collateralReturn">Default: TRUE. TRUE: Return extra collateral to earn account; FALSE: Keep extra collateral in the order, and lower LTV.</param>
    /// <param name="fullRepayment">Default: FALSE. TRUE: Full repayment; FALSE: Partial repayment, based on loanAmount</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleRepayResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RepayFlexibleLoanRepayTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>repayAmount is mandatory even fullRepayment = FALSE</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 6000
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleRepayResponse> RepayFlexibleLoanRepayTrade(double repayAmount,
        long timestamp,
        string signature,
        string? loanCoin,
        string? collateralCoin,
        bool? collateralReturn,
        bool? fullRepayment,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/repay"),
            [],
            [new Param("repayAmount", repayAmount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("collateralReturn", collateralReturn),
                new Param("fullRepayment", fullRepayment),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleRepayResponse>(),
            RepayFlexibleLoanRepayTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Repay - Get Flexible Loan Repayment History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="loanCoin">Coin loaned</param>
    /// <param name="collateralCoin">Coin used as collateral</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2LoanFlexibleRepayHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RepayGetFlexibleLoanRepaymentHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTime and endTime are not sent, the recent 90-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTime and endTime is 180 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 400
    /// </para>
    /// </remarks>
    public Task<SapiV2LoanFlexibleRepayHistoryResponse> RepayGetFlexibleLoanRepaymentHistoryUserData(long timestamp,
        string signature,
        string? loanCoin,
        string? collateralCoin,
        long? startTime,
        long? endTime,
        int? current,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/loan/flexible/repay/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("loanCoin", loanCoin),
                new Param("collateralCoin", collateralCoin),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2LoanFlexibleRepayHistoryResponse>(),
            RepayGetFlexibleLoanRepaymentHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
