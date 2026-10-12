using System;
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
using Binance.Requests.Mining;

namespace Binance.Api;

/// <summary>
/// Mining Endpoints
/// </summary>
public sealed class Mining
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Mining(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Account List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningStatisticsUserListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningStatisticsUserListResponse> AccountListUserData(AccountListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/statistics/user/list"),
            [],
            [
                new Param("algo", request.Algo),
                new Param("userName", request.UserName),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningStatisticsUserListResponse>(),
            AccountListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Acquiring Algorithm (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPubAlgoListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AcquiringAlgorithmMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1MiningPubAlgoListResponse> AcquiringAlgorithmMarketData(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/pub/algoList"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPubAlgoListResponse>(),
            AcquiringAlgorithmMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Acquiring CoinName (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPubCoinListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AcquiringCoinNameMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1MiningPubCoinListResponse> AcquiringCoinNameMarketData(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/pub/coinList"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPubCoinListResponse>(),
            AcquiringCoinNameMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel Hashrate Resale configuration (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningHashTransferConfigCancelResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelHashrateResaleConfigurationUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningHashTransferConfigCancelResponse> CancelHashrateResaleConfigurationUserData(CancelHashrateResaleConfigurationUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/hash-transfer/config/cancel"),
            [],
            [
                new Param("configId", request.ConfigId),
                new Param("userName", request.UserName),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningHashTransferConfigCancelResponse>(),
            CancelHashrateResaleConfigurationUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Earnings List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPaymentListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EarningsListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningPaymentListResponse> EarningsListUserData(EarningsListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/payment/list"),
            [],
            [
                new Param("algo", request.Algo),
                new Param("userName", request.UserName),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("coin", request.Coin),
                new Param("startDate", request.StartDate),
                new Param("endDate", request.EndDate),
                new Param("pageIndex", request.PageIndex),
                new Param("pageSize", request.PageSize),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPaymentListResponse>(),
            EarningsListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Extra Bonus List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPaymentOtherResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ExtraBonusListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningPaymentOtherResponse> ExtraBonusListUserData(ExtraBonusListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/payment/other"),
            [],
            [
                new Param("algo", request.Algo),
                new Param("userName", request.UserName),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("coin", request.Coin),
                new Param("startDate", request.StartDate),
                new Param("endDate", request.EndDate),
                new Param("pageIndex", request.PageIndex),
                new Param("pageSize", request.PageSize),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPaymentOtherResponse>(),
            ExtraBonusListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Hashrate Resale Details (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningHashTransferProfitDetailsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="HashrateResaleDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningHashTransferProfitDetailsResponse> HashrateResaleDetailsUserData(HashrateResaleDetailsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/hash-transfer/profit/details"),
            [],
            [
                new Param("configId", request.ConfigId),
                new Param("userName", request.UserName),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("pageIndex", request.PageIndex),
                new Param("pageSize", request.PageSize),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningHashTransferProfitDetailsResponse>(),
            HashrateResaleDetailsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Hashrate Resale List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningHashTransferConfigDetailsListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="HashrateResaleListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningHashTransferConfigDetailsListResponse> HashrateResaleListUserData(HashrateResaleListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/hash-transfer/config/details/list"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("pageIndex", request.PageIndex),
                new Param("pageSize", request.PageSize),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningHashTransferConfigDetailsListResponse>(),
            HashrateResaleListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Hashrate Resale Request (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningHashTransferConfigResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="HashrateResaleRequestUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningHashTransferConfigResponse> HashrateResaleRequestUserData(HashrateResaleRequestUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/hash-transfer/config"),
            [],
            [
                new Param("userName", request.UserName),
                new Param("algo", request.Algo),
                new Param("toPoolUser", request.ToPoolUser),
                new Param("hashRate", request.HashRate),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startDate", request.StartDate),
                new Param("endDate", request.EndDate),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningHashTransferConfigResponse>(),
            HashrateResaleRequestUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Mining Account Earning (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPaymentUidResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MiningAccountEarningUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningPaymentUidResponse> MiningAccountEarningUserData(MiningAccountEarningUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/payment/uid"),
            [],
            [
                new Param("algo", request.Algo),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startDate", request.StartDate),
                new Param("endDate", request.EndDate),
                new Param("pageIndex", request.PageIndex),
                new Param("pageSize", request.PageSize),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPaymentUidResponse>(),
            MiningAccountEarningUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Request for Detail Miner List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningWorkerDetailResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RequestForDetailMinerListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningWorkerDetailResponse> RequestForDetailMinerListUserData(RequestForDetailMinerListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/worker/detail"),
            [],
            [
                new Param("algo", request.Algo),
                new Param("userName", request.UserName),
                new Param("workerName", request.WorkerName),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningWorkerDetailResponse>(),
            RequestForDetailMinerListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Request for Miner List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningWorkerListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RequestForMinerListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningWorkerListResponse> RequestForMinerListUserData(RequestForMinerListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/worker/list"),
            [],
            [
                new Param("algo", request.Algo),
                new Param("userName", request.UserName),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("pageIndex", request.PageIndex),
                new Param("sort", request.Sort),
                new Param("sortColumn", request.SortColumn),
                new Param("workerStatus", request.WorkerStatus),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningWorkerListResponse>(),
            RequestForMinerListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Statistic List (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningStatisticsUserStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="StatisticListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningStatisticsUserStatusResponse> StatisticListUserData(StatisticListUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/mining/statistics/user/status"),
            [],
            [
                new Param("algo", request.Algo),
                new Param("userName", request.UserName),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningStatisticsUserStatusResponse>(),
            StatisticListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
