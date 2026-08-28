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
    /// <param name="algo">Algorithm(sha256)</param>
    /// <param name="userName">Mining Account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningStatisticsUserListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AccountListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningStatisticsUserListResponse> AccountListUserData(string algo,
        string userName,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/statistics/user/list"),
            [],
            [new Param("algo", algo),
                new Param("userName", userName),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningStatisticsUserListResponse>(),
            AccountListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Acquiring Algorithm (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPubAlgoListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AcquiringAlgorithmMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1MiningPubAlgoListResponse> AcquiringAlgorithmMarketData(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/pub/algoList"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPubAlgoListResponse>(),
            AcquiringAlgorithmMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Acquiring CoinName (MARKET_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPubCoinListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AcquiringCoinNameMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1MiningPubCoinListResponse> AcquiringCoinNameMarketData(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/pub/coinList"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPubCoinListResponse>(),
            AcquiringCoinNameMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel Hashrate Resale configuration (USER_DATA)
    /// </summary>
    /// <param name="configId">Mining ID</param>
    /// <param name="userName">Mining Account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningHashTransferConfigCancelResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelHashrateResaleConfigurationUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningHashTransferConfigCancelResponse> CancelHashrateResaleConfigurationUserData(string configId,
        string userName,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/hash-transfer/config/cancel"),
            [],
            [new Param("configId", configId),
                new Param("userName", userName),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningHashTransferConfigCancelResponse>(),
            CancelHashrateResaleConfigurationUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Earnings List (USER_DATA)
    /// </summary>
    /// <param name="algo">Algorithm(sha256)</param>
    /// <param name="userName">Mining Account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="coin">Coin name</param>
    /// <param name="startDate">Search date, millisecond timestamp, while empty query all</param>
    /// <param name="endDate">Search date, millisecond timestamp, while empty query all</param>
    /// <param name="pageIndex">Page number, default is first page, start form 1</param>
    /// <param name="pageSize">Number of pages, minimum 10, maximum 200</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPaymentListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EarningsListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningPaymentListResponse> EarningsListUserData(string algo,
        string userName,
        long timestamp,
        string signature,
        string? coin,
        string? startDate,
        string? endDate,
        int? pageIndex,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/payment/list"),
            [],
            [new Param("algo", algo),
                new Param("userName", userName),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("coin", coin),
                new Param("startDate", startDate),
                new Param("endDate", endDate),
                new Param("pageIndex", pageIndex),
                new Param("pageSize", pageSize),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPaymentListResponse>(),
            EarningsListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Extra Bonus List (USER_DATA)
    /// </summary>
    /// <param name="algo">Algorithm(sha256)</param>
    /// <param name="userName">Mining Account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="coin">Coin name</param>
    /// <param name="startDate">Search date, millisecond timestamp, while empty query all</param>
    /// <param name="endDate">Search date, millisecond timestamp, while empty query all</param>
    /// <param name="pageIndex">Page number, default is first page, start form 1</param>
    /// <param name="pageSize">Number of pages, minimum 10, maximum 200</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPaymentOtherResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ExtraBonusListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningPaymentOtherResponse> ExtraBonusListUserData(string algo,
        string userName,
        long timestamp,
        string signature,
        string? coin,
        string? startDate,
        string? endDate,
        int? pageIndex,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/payment/other"),
            [],
            [new Param("algo", algo),
                new Param("userName", userName),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("coin", coin),
                new Param("startDate", startDate),
                new Param("endDate", endDate),
                new Param("pageIndex", pageIndex),
                new Param("pageSize", pageSize),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPaymentOtherResponse>(),
            ExtraBonusListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Hashrate Resale Details (USER_DATA)
    /// </summary>
    /// <param name="configId">Mining ID</param>
    /// <param name="userName">Mining Account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="pageIndex">Page number, default is first page, start form 1</param>
    /// <param name="pageSize">Number of pages, minimum 10, maximum 200</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningHashTransferProfitDetailsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="HashrateResaleDetailsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningHashTransferProfitDetailsResponse> HashrateResaleDetailsUserData(string configId,
        string userName,
        long timestamp,
        string signature,
        int? pageIndex,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/hash-transfer/profit/details"),
            [],
            [new Param("configId", configId),
                new Param("userName", userName),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("pageIndex", pageIndex),
                new Param("pageSize", pageSize),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningHashTransferProfitDetailsResponse>(),
            HashrateResaleDetailsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Hashrate Resale List (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="pageIndex">Page number, default is first page, start form 1</param>
    /// <param name="pageSize">Number of pages, minimum 10, maximum 200</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningHashTransferConfigDetailsListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="HashrateResaleListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningHashTransferConfigDetailsListResponse> HashrateResaleListUserData(long timestamp,
        string signature,
        int? pageIndex,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/hash-transfer/config/details/list"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("pageIndex", pageIndex),
                new Param("pageSize", pageSize),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningHashTransferConfigDetailsListResponse>(),
            HashrateResaleListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Hashrate Resale Request (USER_DATA)
    /// </summary>
    /// <param name="userName">Mining Account</param>
    /// <param name="algo">Algorithm(sha256)</param>
    /// <param name="toPoolUser">Mining Account</param>
    /// <param name="hashRate">Resale hashrate h/s must be transferred (BTC is greater than 500000000000 ETH is greater than 500000)</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startDate">Search date, millisecond timestamp, while empty query all</param>
    /// <param name="endDate">Search date, millisecond timestamp, while empty query all</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningHashTransferConfigResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="HashrateResaleRequestUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningHashTransferConfigResponse> HashrateResaleRequestUserData(string userName,
        string algo,
        string toPoolUser,
        string hashRate,
        long timestamp,
        string signature,
        string? startDate,
        string? endDate,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/hash-transfer/config"),
            [],
            [new Param("userName", userName),
                new Param("algo", algo),
                new Param("toPoolUser", toPoolUser),
                new Param("hashRate", hashRate),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startDate", startDate),
                new Param("endDate", endDate),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningHashTransferConfigResponse>(),
            HashrateResaleRequestUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Mining Account Earning (USER_DATA)
    /// </summary>
    /// <param name="algo">Algorithm(sha256)</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startDate">Search date, millisecond timestamp, while empty query all</param>
    /// <param name="endDate">Search date, millisecond timestamp, while empty query all</param>
    /// <param name="pageIndex">Page number, default is first page, start form 1</param>
    /// <param name="pageSize">Number of pages, minimum 10, maximum 200</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningPaymentUidResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MiningAccountEarningUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningPaymentUidResponse> MiningAccountEarningUserData(string algo,
        long timestamp,
        string signature,
        string? startDate,
        string? endDate,
        int? pageIndex,
        string? pageSize,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/payment/uid"),
            [],
            [new Param("algo", algo),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startDate", startDate),
                new Param("endDate", endDate),
                new Param("pageIndex", pageIndex),
                new Param("pageSize", pageSize),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningPaymentUidResponse>(),
            MiningAccountEarningUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Request for Detail Miner List (USER_DATA)
    /// </summary>
    /// <param name="algo">Algorithm(sha256)</param>
    /// <param name="userName">Mining Account</param>
    /// <param name="workerName">Miner’s name</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningWorkerDetailResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RequestForDetailMinerListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningWorkerDetailResponse> RequestForDetailMinerListUserData(string algo,
        string userName,
        string workerName,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/worker/detail"),
            [],
            [new Param("algo", algo),
                new Param("userName", userName),
                new Param("workerName", workerName),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningWorkerDetailResponse>(),
            RequestForDetailMinerListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Request for Miner List (USER_DATA)
    /// </summary>
    /// <param name="algo">Algorithm(sha256)</param>
    /// <param name="userName">Mining Account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="pageIndex">Page number, default is first page, start form 1</param>
    /// <param name="sort">sort sequence(default=0)0 positive sequence, 1 negative sequence</param>
    /// <param name="sortColumn">Sort by( default 1): 1: miner name, 2: real-time computing power, 3: daily average computing power, 4: real-time rejection rate, 5: last submission time</param>
    /// <param name="workerStatus">miners status(default=0)0 all, 1 valid, 2 invalid, 3 failure</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningWorkerListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RequestForMinerListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningWorkerListResponse> RequestForMinerListUserData(string algo,
        string userName,
        long timestamp,
        string signature,
        int? pageIndex,
        int? sort,
        int? sortColumn,
        int? workerStatus,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/worker/list"),
            [],
            [new Param("algo", algo),
                new Param("userName", userName),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("pageIndex", pageIndex),
                new Param("sort", sort),
                new Param("sortColumn", sortColumn),
                new Param("workerStatus", workerStatus),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningWorkerListResponse>(),
            RequestForMinerListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Statistic List (USER_DATA)
    /// </summary>
    /// <param name="algo">Algorithm(sha256)</param>
    /// <param name="userName">Mining Account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1MiningStatisticsUserStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="StatisticListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 5
    /// </remarks>
    public Task<SapiV1MiningStatisticsUserStatusResponse> StatisticListUserData(string algo,
        string userName,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/mining/statistics/user/status"),
            [],
            [new Param("algo", algo),
                new Param("userName", userName),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1MiningStatisticsUserStatusResponse>(),
            StatisticListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
