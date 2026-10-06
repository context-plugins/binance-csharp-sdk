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
using Binance.Requests.PortfolioMargin;

namespace Binance.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioBnbTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BnbTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// BNB transfer can be between Margin Account and USDM Account
    /// <para>
    /// Weight(IP): 1500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioBnbTransferResponse> BnbTransferUserData(BnbTransferUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/bnb-transfer"),
            [],
            [
                new Param("transferSide", request.TransferSide),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioBnbTransferResponse>(),
            BnbTransferUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Change Auto-repay-futures Status (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioRepayFuturesSwitchResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ChangeAutoRepayFuturesStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Change Auto-repay-futures Status
    /// <para>
    /// Weight(IP): 1500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioRepayFuturesSwitchResponse> ChangeAutoRepayFuturesStatusUserData(ChangeAutoRepayFuturesStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/repay-futures-switch"),
            [],
            [
                new Param("autoRepay", request.AutoRepay),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioRepayFuturesSwitchResponse>(),
            ChangeAutoRepayFuturesStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Fund Auto-collection (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioAutoCollectionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FundAutoCollectionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transfers all assets from Futures Account to Margin account
    /// <para>
    /// Weight(IP): 1500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioAutoCollectionResponse> FundAutoCollectionUserData(FundAutoCollectionUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/auto-collection"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioAutoCollectionResponse>(),
            FundAutoCollectionUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Fund Collection by Asset (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioAssetCollectionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FundCollectionByAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transfers specific asset from Futures Account to Margin account
    /// <para>
    /// Weight(IP): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioAssetCollectionResponse> FundCollectionByAssetUserData(FundCollectionByAssetUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/asset-collection"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioAssetCollectionResponse>(),
            FundCollectionByAssetUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Auto-repay-futures Status (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioRepayFuturesSwitchResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAutoRepayFuturesStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Auto-repay-futures Status
    /// <para>
    /// Weight(IP): 30
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioRepayFuturesSwitchResponse1> GetAutoRepayFuturesStatusUserData(GetAutoRepayFuturesStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/repay-futures-switch"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioRepayFuturesSwitchResponse1>(),
            GetAutoRepayFuturesStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Portfolio Margin Asset Leverage (USER_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1PortfolioMarginAssetLeverageResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPortfolioMarginAssetLeverageUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 50
    /// </remarks>
    public Task<IReadOnlyList<SapiV1PortfolioMarginAssetLeverageResponse>> GetPortfolioMarginAssetLeverageUserData(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/margin-asset-leverage"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1PortfolioMarginAssetLeverageResponse>>(),
            GetPortfolioMarginAssetLeverageUserDataError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Portfolio Margin Account (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PortfolioMarginAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the account info
    /// <para>
    /// 'Weight(IP): 1'
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioAccountResponse> PortfolioMarginAccountUserData(PortfolioMarginAccountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/account"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioAccountResponse>(),
            PortfolioMarginAccountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Portfolio Margin Bankruptcy Loan Amount (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioPmLoanResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PortfolioMarginBankruptcyLoanAmountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Portfolio Margin Bankruptcy Loan Amount.
    /// <para>
    /// Weight(UID): 500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioPmLoanResponse> PortfolioMarginBankruptcyLoanAmountUserData(PortfolioMarginBankruptcyLoanAmountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/pmLoan"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioPmLoanResponse>(),
            PortfolioMarginBankruptcyLoanAmountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Portfolio Margin Bankruptcy Loan Repay (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioRepayResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PortfolioMarginBankruptcyLoanRepayUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Repay Portfolio Margin Bankruptcy Loan.
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioRepayResponse> PortfolioMarginBankruptcyLoanRepayUserData(PortfolioMarginBankruptcyLoanRepayUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/repay"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("from", request.From),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioRepayResponse>(),
            PortfolioMarginBankruptcyLoanRepayUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Portfolio Margin Collateral Rate (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1PortfolioCollateralRateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PortfolioMarginCollateralRateMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Portfolio Margin Collateral Rate.
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1PortfolioCollateralRateResponse>> PortfolioMarginCollateralRateMarketData(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/collateralRate"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1PortfolioCollateralRateResponse>>(),
            PortfolioMarginCollateralRateMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Portfolio Margin Pro Tiered Collateral Rate(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV2PortfolioCollateralRateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PortfolioMarginProTieredCollateralRateUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Portfolio Margin PRO Tiered Collateral Rate
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV2PortfolioCollateralRateResponse>> PortfolioMarginProTieredCollateralRateUserData(PortfolioMarginProTieredCollateralRateUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/portfolio/collateralRate"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV2PortfolioCollateralRateResponse>>(),
            PortfolioMarginProTieredCollateralRateUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Classic Portfolio Margin Negative Balance Interest History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1PortfolioInterestHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query interest history of negative balance for portfolio margin.
    /// <para>
    /// Weight(IP): 50
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1PortfolioInterestHistoryResponse>> QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserData(QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/interest-history"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1PortfolioInterestHistoryResponse>>(),
            QueryClassicPortfolioMarginNegativeBalanceInterestHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Portfolio Margin Asset Index Price (MARKET_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1PortfolioAssetIndexPriceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryPortfolioMarginAssetIndexPriceMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Portfolio Margin Asset Index Price
    /// <para>
    /// Weight(IP):
    /// - 1 if send asset
    /// - 50 if not send asset
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>> QueryPortfolioMarginAssetIndexPriceMarketData(QueryPortfolioMarginAssetIndexPriceMarketDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/asset-index-price"),
            [],
            [new Param("asset", request.Asset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1PortfolioAssetIndexPriceResponse>>(),
            QueryPortfolioMarginAssetIndexPriceMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Repay futures Negative Balance (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1PortfolioRepayFuturesNegativeBalanceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RepayFuturesNegativeBalanceUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Repay futures Negative Balance
    /// <para>
    /// Weight(IP): 1500
    /// </para>
    /// </remarks>
    public Task<SapiV1PortfolioRepayFuturesNegativeBalanceResponse> RepayFuturesNegativeBalanceUserData(RepayFuturesNegativeBalanceUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/portfolio/repay-futures-negative-balance"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1PortfolioRepayFuturesNegativeBalanceResponse>(),
            RepayFuturesNegativeBalanceUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
