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
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2EthStakingAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EthStakingAccountV2UserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV2EthStakingAccountResponse> EthStakingAccountV2UserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/eth-staking/account"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2EthStakingAccountResponse>(),
            EthStakingAccountV2UserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get BETH rewards distribution history(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryRewardsHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBethRewardsDistributionHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1EthStakingEthHistoryRewardsHistoryResponse> GetBethRewardsDistributionHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/eth/history/rewardsHistory"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryRewardsHistoryResponse>(),
            GetBethRewardsDistributionHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get ETH redemption history (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryRedemptionHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetEthRedemptionHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1EthStakingEthHistoryRedemptionHistoryResponse> GetEthRedemptionHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/eth/history/redemptionHistory"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryRedemptionHistoryResponse>(),
            GetEthRedemptionHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get ETH staking history (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryStakingHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetEthStakingHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1EthStakingEthHistoryStakingHistoryResponse> GetEthStakingHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/eth/history/stakingHistory"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryStakingHistoryResponse>(),
            GetEthStakingHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get WBETH Rate History (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryRateHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetWbethRateHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1EthStakingEthHistoryRateHistoryResponse> GetWbethRateHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/eth/history/rateHistory"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryRateHistoryResponse>(),
            GetWbethRateHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get WBETH rewards history(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetWbethRewardsHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse> GetWbethRewardsHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/eth/history/wbethRewardsHistory"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthHistoryWbethRewardsHistoryResponse>(),
            GetWbethRewardsHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get WBETH unwrap history (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingWbethHistoryUnwrapHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetWbethUnwrapHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1EthStakingWbethHistoryUnwrapHistoryResponse> GetWbethUnwrapHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/wbeth/history/unwrapHistory"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingWbethHistoryUnwrapHistoryResponse>(),
            GetWbethUnwrapHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get WBETH wrap history (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingWbethHistoryWrapHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetWbethWrapHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1EthStakingWbethHistoryWrapHistoryResponse> GetWbethWrapHistoryUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/wbeth/history/wrapHistory"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingWbethHistoryWrapHistoryResponse>(),
            GetWbethWrapHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get current ETH staking quota (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthQuotaResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCurrentEthStakingQuotaUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 150
    /// </remarks>
    public Task<SapiV1EthStakingEthQuotaResponse> GetCurrentEthStakingQuotaUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/eth/quota"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthQuotaResponse>(),
            GetCurrentEthStakingQuotaUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Redeem ETH (TRADE)
    /// </summary>
    /// <param name="amount">Amount in BETH, limit 8 decimals</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset">WBETH or BETH, default to BETH</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingEthRedeemResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RedeemEthTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Redeem WBETH or BETH and get ETH
    /// <list type="bullet">
    ///   <item><description>You need to open Enable Spot &amp; Margin Trading permission for the API Key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingEthRedeemResponse> RedeemEthTrade(double amount,
        long timestamp,
        string signature,
        string? asset,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/eth/redeem"),
            [],
            [new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingEthRedeemResponse>(),
            RedeemEthTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe ETH Staking V2(TRADE)
    /// </summary>
    /// <param name="amount">Amount in ETH, limit 4 decimals</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2EthStakingEthStakeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubscribeEthStakingV2TradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Stake ETH to get WBETH
    /// <list type="bullet">
    ///   <item><description>You need to open Enable Spot &amp; Margin Trading permission for the API Key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV2EthStakingEthStakeResponse> SubscribeEthStakingV2Trade(double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/eth-staking/eth/stake"),
            [],
            [new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2EthStakingEthStakeResponse>(),
            SubscribeEthStakingV2TradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Wrap BETH(TRADE)
    /// </summary>
    /// <param name="amount">Amount in BETH, limit 4 decimals</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1EthStakingWbethWrapResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="WrapBethTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to open Enable Spot &amp; Margin Trading permission for the API Key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 150
    /// </para>
    /// </remarks>
    public Task<SapiV1EthStakingWbethWrapResponse> WrapBethTrade(double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/eth-staking/wbeth/wrap"),
            [],
            [new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1EthStakingWbethWrapResponse>(),
            WrapBethTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
