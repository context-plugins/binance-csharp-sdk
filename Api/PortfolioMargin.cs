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
using BinancePublicSpotApi.Models.Enums;

namespace BinancePublicSpotApi.Api;

/// <summary>
/// Portfolio Margin Endpoints
/// </summary>
public sealed class PortfolioMargin
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PortfolioMargin(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BNB Transfer (USER_DATA)
    /// </summary>
    /// <param name="transferSide"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioBnbTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BnbTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// BNB transfer can be between Margin Account and USDM Account
    /// <para>
    /// Weight(IP): 1500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioBnbTransferResponse> BnbTransferUserData(TransferSide transferSide,
        double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/bnb-transfer"),
            [],
            [new Param("transferSide", transferSide),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioBnbTransferResponse>(),
            BnbTransferUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Change Auto-repay-futures Status (USER_DATA)
    /// </summary>
    /// <param name="autoRepay"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioRepayFuturesSwitchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ChangeAutoRepayFuturesStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Change Auto-repay-futures Status
    /// <para>
    /// Weight(IP): 1500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioRepayFuturesSwitchResponse> ChangeAutoRepayFuturesStatusUserData(bool autoRepay,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/repay-futures-switch"),
            [],
            [new Param("autoRepay", autoRepay),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioRepayFuturesSwitchResponse>(),
            ChangeAutoRepayFuturesStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Fund Auto-collection (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioAutoCollectionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FundAutoCollectionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transfers all assets from Futures Account to Margin account
    /// <para>
    /// Weight(IP): 1500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioAutoCollectionResponse> FundAutoCollectionUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/auto-collection"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioAutoCollectionResponse>(),
            FundAutoCollectionUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Fund Collection by Asset (USER_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioAssetCollectionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FundCollectionByAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transfers specific asset from Futures Account to Margin account
    /// <para>
    /// Weight(IP): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioAssetCollectionResponse> FundCollectionByAssetUserData(string asset,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/asset-collection"),
            [],
            [new Param("asset", asset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioAssetCollectionResponse>(),
            FundCollectionByAssetUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Auto-repay-futures Status (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioRepayFuturesSwitchResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAutoRepayFuturesStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Auto-repay-futures Status
    /// <para>
    /// Weight(IP): 30
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioRepayFuturesSwitchResponse1> GetAutoRepayFuturesStatusUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/repay-futures-switch"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioRepayFuturesSwitchResponse1>(),
            GetAutoRepayFuturesStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Portfolio Margin Asset Leverage (USER_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1PortfolioMarginAssetLeverageResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPortfolioMarginAssetLeverageUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 50
    /// </remarks>
    public Task<IReadOnlyList<SapiV1PortfolioMarginAssetLeverageResponse>> GetPortfolioMarginAssetLeverageUserData(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/margin-asset-leverage"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1PortfolioMarginAssetLeverageResponse>>(),
            GetPortfolioMarginAssetLeverageUserDataErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Portfolio Margin Account (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PortfolioMarginAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the account info
    /// <para>
    /// 'Weight(IP): 1'
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioAccountResponse> PortfolioMarginAccountUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/account"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioAccountResponse>(),
            PortfolioMarginAccountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Portfolio Margin Bankruptcy Loan Amount (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioPmLoanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PortfolioMarginBankruptcyLoanAmountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Portfolio Margin Bankruptcy Loan Amount.
    /// <para>
    /// Weight(UID): 500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioPmLoanResponse> PortfolioMarginBankruptcyLoanAmountUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/pmLoan"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioPmLoanResponse>(),
            PortfolioMarginBankruptcyLoanAmountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Portfolio Margin Bankruptcy Loan Repay (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="from"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioRepayResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PortfolioMarginBankruptcyLoanRepayUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Repay Portfolio Margin Bankruptcy Loan.
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioRepayResponse> PortfolioMarginBankruptcyLoanRepayUserData(long timestamp,
        string signature,
        string? from,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/repay"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("from", from),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioRepayResponse>(),
            PortfolioMarginBankruptcyLoanRepayUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Portfolio Margin Collateral Rate (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1PortfolioCollateralRateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PortfolioMarginCollateralRateMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Portfolio Margin Collateral Rate.
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1PortfolioCollateralRateResponse>> PortfolioMarginCollateralRateMarketData(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/collateralRate"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1PortfolioCollateralRateResponse>>(),
            PortfolioMarginCollateralRateMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Portfolio Margin Pro Tiered Collateral Rate(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV2PortfolioCollateralRateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PortfolioMarginProTieredCollateralRateUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Portfolio Margin PRO Tiered Collateral Rate
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV2PortfolioCollateralRateResponse>> PortfolioMarginProTieredCollateralRateUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/portfolio/collateralRate"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV2PortfolioCollateralRateResponse>>(),
            PortfolioMarginProTieredCollateralRateUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Classic Portfolio Margin Negative Balance Interest History (USER_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1PortfolioInterestHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query interest history of negative balance for portfolio margin.
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1PortfolioInterestHistoryResponse>> QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData(string asset,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/interest-history"),
            [],
            [new Param("asset", asset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1PortfolioInterestHistoryResponse>>(),
            QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Portfolio Margin Asset Index Price (MARKET_DATA)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1PortfolioAssetIndexPriceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryPortfolioMarginAssetIndexPriceMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Portfolio Margin Asset Index Price
    /// <para>
    /// Weight(IP):
    /// - 1 if send asset
    /// - 50 if not send asset
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>> QueryPortfolioMarginAssetIndexPriceMarketData(string? asset,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/asset-index-price"),
            [],
            [new Param("asset", asset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>>(),
            QueryPortfolioMarginAssetIndexPriceMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Repay futures Negative Balance (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioRepayFuturesNegativeBalanceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RepayFuturesNegativeBalanceUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Repay futures Negative Balance
    /// <para>
    /// Weight(IP): 1500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioRepayFuturesNegativeBalanceResponse> RepayFuturesNegativeBalanceUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/portfolio/repay-futures-negative-balance"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioRepayFuturesNegativeBalanceResponse>(),
            RepayFuturesNegativeBalanceUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
