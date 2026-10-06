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
using Binance.Requests.Staking;

namespace Binance.Api;

public sealed class Staking
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Staking(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ETH Staking account V2(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2EthStakingAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EthStakingAccountV2UserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV2EthStakingAccountResponse> EthStakingAccountV2UserData(EthStakingAccountV2UserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/eth-staking/account"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2EthStakingAccountResponse>(),
            EthStakingAccountV2UserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get BETH rewards distribution history(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryRewardsHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBethRewardsDistributionHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The time between startTime and endTime cannot be longer than 3 months.</description></item>
    ///   <item><description>If startTime and endTime are both not sent, then the last 30 days' data will be returned.</description></item>
    ///   <item><description>If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.</description></item>
    ///   <item><description>If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingEthHistoryRewardsHistoryResponse> GetBethRewardsDistributionHistoryUserData(GetBethRewardsDistributionHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/eth/history/rewardsHistory"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryRewardsHistoryResponse>(),
            GetBethRewardsDistributionHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get ETH redemption history (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryRedemptionHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEthRedemptionHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The time between startTime and endTime cannot be longer than 3 months.</description></item>
    ///   <item><description>If startTime and endTime are both not sent, then the last 30 days' data will be returned.</description></item>
    ///   <item><description>If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.</description></item>
    ///   <item><description>If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingEthHistoryRedemptionHistoryResponse> GetEthRedemptionHistoryUserData(GetEthRedemptionHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/eth/history/redemptionHistory"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryRedemptionHistoryResponse>(),
            GetEthRedemptionHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get ETH staking history (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryStakingHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEthStakingHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The time between startTime and endTime cannot be longer than 3 months.</description></item>
    ///   <item><description>If startTime and endTime are both not sent, then the last 30 days' data will be returned.</description></item>
    ///   <item><description>If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.</description></item>
    ///   <item><description>If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingEthHistoryStakingHistoryResponse> GetEthStakingHistoryUserData(GetEthStakingHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/eth/history/stakingHistory"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryStakingHistoryResponse>(),
            GetEthStakingHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get WBETH Rate History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryRateHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetWbethRateHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The time between startTime and endTime cannot be longer than 3 months.</description></item>
    ///   <item><description>If startTime and endTime are both not sent, then the last 30 days' data will be returned.</description></item>
    ///   <item><description>If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.</description></item>
    ///   <item><description>If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingEthHistoryRateHistoryResponse> GetWbethRateHistoryUserData(GetWbethRateHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/eth/history/rateHistory"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryRateHistoryResponse>(),
            GetWbethRateHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get WBETH rewards history(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetWbethRewardsHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The time between startTime and endTime cannot be longer than 3 months.</description></item>
    ///   <item><description>If startTime and endTime are both not sent, then the last 30 days' data will be returned.</description></item>
    ///   <item><description>If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.</description></item>
    ///   <item><description>If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse> GetWbethRewardsHistoryUserData(GetWbethRewardsHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/eth/history/wbethRewardsHistory"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse>(),
            GetWbethRewardsHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get WBETH unwrap history (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingWbethHistoryUnwrapHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetWbethUnwrapHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The time between startTime and endTime cannot be longer than 3 months.</description></item>
    ///   <item><description>If startTime and endTime are both not sent, then the last 30 days' data will be returned.</description></item>
    ///   <item><description>If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.</description></item>
    ///   <item><description>If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingWbethHistoryUnwrapHistoryResponse> GetWbethUnwrapHistoryUserData(GetWbethUnwrapHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/wbeth/history/unwrapHistory"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingWbethHistoryUnwrapHistoryResponse>(),
            GetWbethUnwrapHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get WBETH wrap history (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingWbethHistoryWrapHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetWbethWrapHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The time between startTime and endTime cannot be longer than 3 months.</description></item>
    ///   <item><description>If startTime and endTime are both not sent, then the last 30 days' data will be returned.</description></item>
    ///   <item><description>If startTime is sent but endTime is not sent, the next 30 days' data beginning from startTime will be returned.</description></item>
    ///   <item><description>If endTime is sent but startTime is not sent, the 30 days' data before endTime will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingWbethHistoryWrapHistoryResponse> GetWbethWrapHistoryUserData(GetWbethWrapHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/wbeth/history/wrapHistory"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingWbethHistoryWrapHistoryResponse>(),
            GetWbethWrapHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get current ETH staking quota (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthQuotaResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCurrentEthStakingQuotaUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1EthStakingEthQuotaResponse> GetCurrentEthStakingQuotaUserData(GetCurrentEthStakingQuotaUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/eth/quota"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthQuotaResponse>(),
            GetCurrentEthStakingQuotaUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Redeem ETH (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthRedeemResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RedeemEthTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Redeem WBETH or BETH and get ETH
    /// <list type="bullet">
    ///   <item><description>You need to open Enable Spot &amp; Margin Trading permission for the API Key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingEthRedeemResponse> RedeemEthTrade(RedeemEthTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/eth/redeem"),
            [],
            [
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthRedeemResponse>(),
            RedeemEthTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Subscribe ETH Staking V2(TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2EthStakingEthStakeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubscribeEthStakingV2TradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Stake ETH to get WBETH
    /// <list type="bullet">
    ///   <item><description>You need to open Enable Spot &amp; Margin Trading permission for the API Key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV2EthStakingEthStakeResponse> SubscribeEthStakingV2Trade(SubscribeEthStakingV2TradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/eth-staking/eth/stake"),
            [],
            [
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2EthStakingEthStakeResponse>(),
            SubscribeEthStakingV2TradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Wrap BETH(TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingWbethWrapResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="WrapBethTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to open Enable Spot &amp; Margin Trading permission for the API Key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingWbethWrapResponse> WrapBethTrade(WrapBethTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/eth-staking/wbeth/wrap"),
            [],
            [
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingWbethWrapResponse>(),
            WrapBethTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
