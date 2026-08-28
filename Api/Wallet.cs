using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core;
using Binance.Core.ErrorResponse;
using Binance.Core.Exceptions;
using Binance.Core.Models;
using Binance.Core.Request;
using Binance.Core.Response;
using Binance.Errors;
using Binance.Models;
using Binance.Models.AnyOf;
using Binance.Models.Enums;

namespace Binance.Api;

/// <summary>
/// Wallet Endpoints
/// </summary>
public sealed class Wallet
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Wallet(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Account API Trading Status (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountApiTradingStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AccountApiTradingStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch account API trading status with details.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AccountApiTradingStatusResponse> AccountApiTradingStatusUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/account/apiTradingStatus"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountApiTradingStatusResponse>(),
            AccountApiTradingStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Account Status (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AccountStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch account status detail.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AccountStatusResponse> AccountStatusUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/account/status"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountStatusResponse>(),
            AccountStatusUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Account info (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AccountInfoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch account info detail.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AccountInfoResponse> AccountInfoUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/account/info"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountInfoResponse>(),
            AccountInfoUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// All Coins' Information (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalConfigGetallResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AllCoinsInformationUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get information of coins (available for deposit and withdraw) for user.
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalConfigGetallResponse>> AllCoinsInformationUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/config/getall"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalConfigGetallResponse>>(),
            AllCoinsInformationUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Asset Detail (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetAssetDetailResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AssetDetailUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch details of assets supported on Binance.
    /// <list type="bullet">
    ///   <item><description>Please get network and other deposit or withdraw details from <c>GET /sapi/v1/capital/config/getall</c>.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetAssetDetailResponse> AssetDetailUserData(long timestamp,
        string signature,
        string? asset,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/assetDetail"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetAssetDetailResponse>(),
            AssetDetailUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Asset Dividend Record (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="limit"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetAssetDividendResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AssetDividendRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query asset Dividend Record
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetAssetDividendResponse> AssetDividendRecordUserData(long timestamp,
        string signature,
        string? asset,
        long? startTime,
        long? endTime,
        long? recvWindow,
        int? limit = 20,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/assetDividend"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetAssetDividendResponse>(),
            AssetDividendRecordUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Convert Transfer (USER_DATA)
    /// </summary>
    /// <param name="clientTranId">The unique flag, the min length is 20</param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="targetAsset">Target asset you want to convert</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetConvertTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ConvertTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Convert transfer, convert between BUSD and stablecoins.
    /// If the clientId has been used before, will not do the convert transfer, the original transfer will be returned.
    /// <para>
    /// Weight(UID): 5
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetConvertTransferResponse> ConvertTransferUserData(string clientTranId,
        string asset,
        double amount,
        string targetAsset,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/convert-transfer"),
            [],
            [new Param("clientTranId", clientTranId),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("targetAsset", targetAsset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetConvertTransferResponse>(),
            ConvertTransferUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Daily Account Snapshot (USER_DATA)
    /// </summary>
    /// <param name="type"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="limit"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountSnapshotResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DailyAccountSnapshotUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The query time period must be less than 30 days</description></item>
    ///   <item><description>Support query within the last one month only</description></item>
    ///   <item><description>If startTimeand endTime not sent, return records of the last 7 days by default</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 2400
    /// </para>
    /// </remarks>
    public Task<SapiV1AccountSnapshotResponse> DailyAccountSnapshotUserData(Type6 type,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        long? recvWindow,
        int? limit = 7,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/accountSnapshot"),
            [],
            [new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountSnapshotResponse>(),
            DailyAccountSnapshotUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Deposit Address (supporting network) (USER_DATA)
    /// </summary>
    /// <param name="coin">Coin name</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="network"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalDepositAddressResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DepositAddressSupportingNetworkUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch deposit address with network.
    /// <list type="bullet">
    ///   <item><description>If network is not send, return with default network of the coin.</description></item>
    ///   <item><description>You can get network and isDefault in networkList in the response of Get /sapi/v1/capital/config/getall (HMAC SHA256).</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1CapitalDepositAddressResponse> DepositAddressSupportingNetworkUserData(string coin,
        long timestamp,
        string signature,
        string? network,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/deposit/address"),
            [],
            [new Param("coin", coin),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("network", network),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalDepositAddressResponse>(),
            DepositAddressSupportingNetworkUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Deposit History(supporting network) (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="coin">Coin name</param>
    /// <param name="status">* <c>0</c> - pending * <c>6</c> - credited but cannot withdraw * <c>1</c> - success</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="offset"></param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalDepositHisrecResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DepositHistorySupportingNetworkUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch deposit history.
    /// <list type="bullet">
    ///   <item><description>Please notice the default <c>startTime</c> and <c>endTime</c> to make sure that time interval is within 0-90 days.</description></item>
    ///   <item><description>If both <c>startTime</c> and <c>endTime</c> are sent, time between <c>startTime</c> and <c>endTime</c> must be less than 90 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalDepositHisrecResponse>> DepositHistorySupportingNetworkUserData(long timestamp,
        string signature,
        string? coin,
        int? status,
        long? startTime,
        long? endTime,
        int? offset,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/deposit/hisrec"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("coin", coin),
                new Param("status", status),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("offset", offset),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalDepositHisrecResponse>>(),
            DepositHistorySupportingNetworkUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Disable Fast Withdraw Switch (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DisableFastWithdrawSwitchUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>This request will disable fastwithdraw switch under your account.</description></item>
    ///   <item><description>You need to enable "trade" option for the api key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<object> DisableFastWithdrawSwitchUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/account/disableFastWithdrawSwitch"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DisableFastWithdrawSwitchUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Dust Transfer (USER_DATA)
    /// </summary>
    /// <param name="asset">The asset being converted. For example, asset=BTC&amp;asset=USDT</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="accountType">SPOT or MARGIN, default SPOT</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetDustResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DustTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Convert dust assets to BNB.
    /// <para>
    /// Weight(UID): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetDustResponse> DustTransferUserData(IReadOnlyList<string> asset,
        long timestamp,
        string signature,
        AccountType? accountType,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/dust"),
            [],
            [new Param("asset", asset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("accountType", accountType),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetDustResponse>(),
            DustTransferUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// DustLog(USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="accountType">SPOT or MARGIN, default SPOT</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetDribbletResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DustLogUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1AssetDribbletResponse> DustLogUserData(long timestamp,
        string signature,
        AccountType? accountType,
        long? startTime,
        long? endTime,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/dribblet"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("accountType", accountType),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetDribbletResponse>(),
            DustLogUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Enable Fast Withdraw Switch (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableFastWithdrawSwitchUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>This request will enable fastwithdraw switch under your account. You need to enable "trade" option for the api key which requests this endpoint.</description></item>
    ///   <item><description>When Fast Withdraw Switch is on, transferring funds to a Binance account will be done instantly. There is no on-chain transaction, no transaction ID and no withdrawal fee.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<object> EnableFastWithdrawSwitchUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/account/enableFastWithdrawSwitch"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            EnableFastWithdrawSwitchUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch deposit address list with network (USER_DATA)
    /// </summary>
    /// <param name="coin"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="network"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalDepositAddressListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FetchDepositAddressListWithNetworkUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch deposit address list with network.
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalDepositAddressListResponse>> FetchDepositAddressListWithNetworkUserData(string coin,
        long timestamp,
        string signature,
        string? network,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/deposit/address/list"),
            [],
            [new Param("coin", coin),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("network", network),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalDepositAddressListResponse>>(),
            FetchDepositAddressListWithNetworkUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch withdraw address list (USER_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalWithdrawAddressListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FetchWithdrawAddressListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch withdraw address list
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalWithdrawAddressListResponse>> FetchWithdrawAddressListUserData(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/withdraw/address/list"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalWithdrawAddressListResponse>>(),
            FetchWithdrawAddressListUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Funding Wallet (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="needBtcValuation"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1AssetGetFundingAssetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FundingWalletUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Currently supports querying the following business assets：Binance Pay, Binance Card, Binance Gift Card, Stock Token</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1AssetGetFundingAssetResponse>> FundingWalletUserData(long timestamp,
        string signature,
        string? asset,
        NeedBtcValuation? needBtcValuation,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/get-funding-asset"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("needBtcValuation", needBtcValuation),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1AssetGetFundingAssetResponse>>(),
            FundingWalletUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get API Key Permission (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountApiRestrictionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetApiKeyPermissionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1AccountApiRestrictionsResponse> GetApiKeyPermissionUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/account/apiRestrictions"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountApiRestrictionsResponse>(),
            GetApiKeyPermissionUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Assets That Can Be Converted Into BNB (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="accountType">SPOT or MARGIN, default SPOT</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetDustBtcResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAssetsThatCanBeConvertedIntoBnbUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1AssetDustBtcResponse> GetAssetsThatCanBeConvertedIntoBnbUserData(long timestamp,
        string signature,
        AccountType? accountType,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/dust-btc"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("accountType", accountType),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetDustBtcResponse>(),
            GetAssetsThatCanBeConvertedIntoBnbUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Cloud-Mining payment and refund history (USER_DATA)
    /// </summary>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="tranId">The transaction id</param>
    /// <param name="clientTranId">The unique flag</param>
    /// <param name="asset">If it is blank, we will query all assets</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCloudMiningPaymentAndRefundHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The query of Cloud-Mining payment and refund history
    /// <para>
    /// Weight(UID): 600
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse> GetCloudMiningPaymentAndRefundHistoryUserData(long startTime,
        long endTime,
        long timestamp,
        string signature,
        long? tranId,
        string? clientTranId,
        string? asset,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/ledger-transfer/cloud-mining/queryByPage"),
            [],
            [new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("tranId", tranId),
                new Param("clientTranId", clientTranId),
                new Param("asset", asset),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse>(),
            GetCloudMiningPaymentAndRefundHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get symbols delist schedule for spot (MARKET_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SpotDelistScheduleResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSymbolsDelistScheduleForSpotMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get symbols delist schedule for spot
    /// <para>
    /// Weight(IP): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SpotDelistScheduleResponse>> GetSymbolsDelistScheduleForSpotMarketData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/spot/delist-schedule"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SpotDelistScheduleResponse>>(),
            GetSymbolsDelistScheduleForSpotMarketDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// One click arrival deposit apply (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="depositId">Deposit record Id, priority use</param>
    /// <param name="txId">Deposit txId, used when depositId is not specified</param>
    /// <param name="subAccountId"></param>
    /// <param name="subUserId"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalDepositCreditApplyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OneClickArrivalDepositApplyUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Apply deposit credit for expired address (One click arrival)
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1CapitalDepositCreditApplyResponse> OneClickArrivalDepositApplyUserData(long timestamp,
        string signature,
        long? depositId,
        string? txId,
        long? subAccountId,
        long? subUserId,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/deposit/credit-apply"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("depositId", depositId),
                new Param("txId", txId),
                new Param("subAccountId", subAccountId),
                new Param("subUserId", subUserId),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalDepositCreditApplyResponse>(),
            OneClickArrivalDepositApplyUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Convert Transfer (USER_DATA)
    /// </summary>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="tranId">The transaction id</param>
    /// <param name="asset">If it is blank, we will match deducted asset and target asset.</param>
    /// <param name="accountType">MAIN: main account. CARD: funding account. If it is blank, we will query spot and card wallet, otherwise, we just query the corresponding wallet</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetConvertTransferQueryByPageResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryConvertTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 5
    /// </remarks>
    public Task<SapiV1AssetConvertTransferQueryByPageResponse> QueryConvertTransferUserData(long startTime,
        long endTime,
        long timestamp,
        string signature,
        long? tranId,
        string? asset,
        AccountType3? accountType,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/convert-transfer/queryByPage"),
            [],
            [new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("tranId", tranId),
                new Param("asset", asset),
                new Param("accountType", accountType),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetConvertTransferQueryByPageResponse>(),
            QueryConvertTransferUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query User Delegation History(For Master Account) (USER_DATA)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <param name="asset"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="type"></param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetCustodyTransferHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryUserDelegationHistoryForMasterAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query User Delegation History
    /// <para>
    /// Weight(IP): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetCustodyTransferHistoryResponse> QueryUserDelegationHistoryForMasterAccountUserData(string email,
        long startTime,
        long endTime,
        string asset,
        long timestamp,
        string signature,
        string? type,
        int? current,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/custody/transfer-history"),
            [],
            [new Param("email", email),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("asset", asset),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("type", type),
                new Param("current", current),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetCustodyTransferHistoryResponse>(),
            QueryUserDelegationHistoryForMasterAccountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query User Universal Transfer History (USER_DATA)
    /// </summary>
    /// <param name="type">Universal transfer type</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="current">Current querying page. Start from 1. Default:1</param>
    /// <param name="size">Default:10 Max:100</param>
    /// <param name="fromSymbol">Must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN</param>
    /// <param name="toSymbol">Must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryUserUniversalTransferHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description><c>fromSymbol</c> must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN</description></item>
    ///   <item><description><c>toSymbol</c> must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN</description></item>
    ///   <item><description>Support query within the last 6 months only</description></item>
    ///   <item><description>If <c>startTime</c> and <c>endTime</c> not sent, return records of the last 7 days by default</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetTransferResponse> QueryUserUniversalTransferHistoryUserData(Type7 type,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? current,
        int? size,
        string? fromSymbol,
        string? toSymbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/transfer"),
            [],
            [new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("current", current),
                new Param("size", size),
                new Param("fromSymbol", fromSymbol),
                new Param("toSymbol", toSymbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetTransferResponse>(),
            QueryUserUniversalTransferHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query User Wallet Balance (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1AssetWalletBalanceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryUserWalletBalanceUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query User Wallet Balance
    /// <para>
    /// Weight(IP): 60
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1AssetWalletBalanceResponse>> QueryUserWalletBalanceUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/wallet/balance"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1AssetWalletBalanceResponse>>(),
            QueryUserWalletBalanceUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query auto-converting stable coins (USER_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalContractConvertibleCoinsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryAutoConvertingStableCoinsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a user's auto-conversion settings in deposit/withdrawal
    /// <para>
    /// Weight(UID): 600'
    /// </para>
    /// </remarks>
    public Task<SapiV1CapitalContractConvertibleCoinsResponse> QueryAutoConvertingStableCoinsUserData(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/contract/convertible-coins"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalContractConvertibleCoinsResponse>(),
            QueryAutoConvertingStableCoinsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Switch on/off BUSD and stable coins conversion (USER_DATA) (USER_DATA)
    /// </summary>
    /// <param name="coin">Must be USDC, USDP or TUSD</param>
    /// <param name="enable">true: turn on the auto-conversion. false: turn off the auto-conversion</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// User can use it to turn on or turn off the BUSD auto-conversion from/to a specific stable coin.
    /// <para>
    /// Weight(UID): 600'
    /// </para>
    /// </remarks>
    public Task<object> SwitchOnOffBusdAndStableCoinsConversionUserDataUserData(string coin,
        bool enable,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/contract/convertible-coins"),
            [],
            [new Param("coin", coin), new Param("enable", enable)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// System Status (System)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SystemStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch system status.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SystemStatusResponse> SystemStatusSystem(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/system/status"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SystemStatusResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Trade Fee (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="symbol">Trading symbol, e.g. BNBUSDT</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1AssetTradeFeeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TradeFeeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch trade fee
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1AssetTradeFeeResponse>> TradeFeeUserData(long timestamp,
        string signature,
        string? symbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/tradeFee"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("symbol", symbol),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1AssetTradeFeeResponse>>(),
            TradeFeeUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// User Asset (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="needBtcValuation"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV3AssetGetUserAssetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UserAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get user assets, just for positive data.
    /// <para>
    /// Weight(IP): 5
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV3AssetGetUserAssetResponse>> UserAssetUserData(long timestamp,
        string signature,
        string? asset,
        NeedBtcValuation? needBtcValuation,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v3/asset/getUserAsset"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("asset", asset),
                new Param("needBtcValuation", needBtcValuation),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV3AssetGetUserAssetResponse>>(),
            UserAssetUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// User Universal Transfer (USER_DATA)
    /// </summary>
    /// <param name="type">Universal transfer type</param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="fromSymbol">Must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN</param>
    /// <param name="toSymbol">Must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetTransferResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UserUniversalTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// You need to enable <c>Permits Universal Transfer</c> option for the api key which requests this endpoint.
    /// <list type="bullet">
    ///   <item><description><c>fromSymbol</c> must be sent when type are ISOLATEDMARGIN_MARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN</description></item>
    ///   <item><description><c>toSymbol</c> must be sent when type are MARGIN_ISOLATEDMARGIN and ISOLATEDMARGIN_ISOLATEDMARGIN</description></item>
    /// </list>
    /// <para>
    /// ENUM of transfer types:
    ///   - MAIN_UMFUTURE Spot account transfer to USDⓈ-M Futures account
    ///   - MAIN_CMFUTURE Spot account transfer to COIN-M Futures account
    ///   - MAIN_MARGIN Spot account transfer to Margin(cross)account
    ///   - UMFUTURE_MAIN USDⓈ-M Futures account transfer to Spot account
    ///   - UMFUTURE_MARGIN USDⓈ-M Futures account transfer to Margin(cross)account
    ///   - CMFUTURE_MAIN COIN-M Futures account transfer to Spot account
    ///   - CMFUTURE_MARGIN COIN-M Futures account transfer to Margin(cross) account
    ///   - MARGIN_MAIN Margin(cross)account transfer to Spot account
    ///   - MARGIN_UMFUTURE Margin(cross)account transfer to USDⓈ-M Futures
    ///   - MARGIN_CMFUTURE Margin(cross)account transfer to COIN-M Futures
    ///   - ISOLATEDMARGIN_MARGIN Isolated margin account transfer to Margin(cross) account
    ///   - MARGIN_ISOLATEDMARGIN Margin(cross) account transfer to Isolated margin account
    ///   - ISOLATEDMARGIN_ISOLATEDMARGIN Isolated margin account transfer to Isolated margin account
    ///   - MAIN_FUNDING Spot account transfer to Funding account
    ///   - FUNDING_MAIN Funding account transfer to Spot account
    ///   - FUNDING_UMFUTURE Funding account transfer to UMFUTURE account
    ///   - UMFUTURE_FUNDING UMFUTURE account transfer to Funding account
    ///   - MARGIN_FUNDING MARGIN account transfer to Funding account
    ///   - FUNDING_MARGIN Funding account transfer to Margin account
    ///   - FUNDING_CMFUTURE Funding account transfer to CMFUTURE account
    ///   - CMFUTURE_FUNDING CMFUTURE account transfer to Funding account
    ///   - MAIN_OPTION Spot account transfer to Options account
    ///   - OPTION_MAIN Options account transfer to Spot account
    ///   - UMFUTURE_OPTION USDⓈ-M Futures account transfer to Options account
    ///   - OPTION_UMFUTURE Options account transfer to USDⓈ-M Futures account
    ///   - MARGIN_OPTION Margin(cross)account transfer to Options account
    ///   - OPTION_MARGIN Options account transfer to Margin(cross)account
    ///   - FUNDING_OPTION Funding account transfer to Options account
    ///   - OPTION_FUNDING Options account transfer to Funding account
    ///   - MAIN_PORTFOLIO_MARGIN Spot account transfer to Portfolio Margin account
    ///   - PORTFOLIO_MARGIN_MAIN Portfolio Margin account transfer to Spot account
    ///   - MAIN_ISOLATED_MARGIN Spot account transfer to Isolated margin account
    ///   - ISOLATED_MARGIN_MAIN Isolated margin account transfer to Spot account
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetTransferResponse1> UserUniversalTransferUserData(Type7 type,
        string asset,
        double amount,
        long timestamp,
        string signature,
        string? fromSymbol,
        string? toSymbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/asset/transfer"),
            [],
            [new Param("type", type),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("fromSymbol", fromSymbol),
                new Param("toSymbol", toSymbol),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetTransferResponse1>(),
            UserUniversalTransferUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Withdraw (USER_DATA)
    /// </summary>
    /// <param name="coin">Coin name</param>
    /// <param name="address"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="withdrawOrderId">Client id for withdraw</param>
    /// <param name="network"></param>
    /// <param name="addressTag">Secondary address identifier for coins like XRP,XMR etc.</param>
    /// <param name="name"></param>
    /// <param name="walletType">The wallet type for withdraw，0-Spot wallet, 1- Funding wallet. Default is Spot wallet</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="transactionFeeFlag">When making internal transfer - <c>true</c> -&gt;  returning the fee to the destination account; - <c>false</c> -&gt; returning the fee back to the departure account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalWithdrawApplyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="WithdrawUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Submit a withdraw request.
    /// <list type="bullet">
    ///   <item><description>If <c>network</c> not send, return with default network of the coin.</description></item>
    ///   <item><description>You can get <c>network</c> and <c>isDefault</c> in <c>networkList</c> of a coin in the response of <c>Get /sapi/v1/capital/config/getall (HMAC SHA256)</c>.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1CapitalWithdrawApplyResponse> WithdrawUserData(string coin,
        string address,
        double amount,
        long timestamp,
        string signature,
        string? withdrawOrderId,
        string? network,
        string? addressTag,
        string? name,
        int? walletType,
        long? recvWindow,
        bool? transactionFeeFlag = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/withdraw/apply"),
            [],
            [new Param("coin", coin),
                new Param("address", address),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("withdrawOrderId", withdrawOrderId),
                new Param("network", network),
                new Param("addressTag", addressTag),
                new Param("transactionFeeFlag", transactionFeeFlag),
                new Param("name", name),
                new Param("walletType", walletType),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalWithdrawApplyResponse>(),
            WithdrawUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Withdraw History (supporting network) (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="coin">Coin name</param>
    /// <param name="withdrawOrderId"></param>
    /// <param name="status">* <c>0</c> - Email Sent * <c>1</c> - Cancelled * <c>2</c> - Awaiting Approval * <c>3</c> - Rejected * <c>4</c> - Processing * <c>5</c> - Failure * <c>6</c> - Completed</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="offset"></param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalWithdrawHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="WithdrawHistorySupportingNetworkUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch withdraw history.
    /// <para>
    /// This endpoint specifically uses per second UID rate limit, user's total second level IP rate limit is 180000/second. Response from the endpoint contains header key X-SAPI-USED-UID-WEIGHT-1S, which defines weight used by the current IP.
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>network</c> may not be in the response for old withdraw.</description></item>
    ///   <item><description>Please notice the default <c>startTime</c> and <c>endTime</c> to make sure that time interval is within 0-90 days.</description></item>
    ///   <item><description>If both <c>startTime</c> and <c>endTime</c> are sent, time between <c>startTime</c> and <c>endTime</c> must be less than 90 days</description></item>
    ///   <item><description>If withdrawOrderId is sent, time between startTime and endTime must be less than 7 days.</description></item>
    ///   <item><description>If withdrawOrderId is sent, startTime and endTime are not sent, will return last 7 days records by default.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 18000
    /// Request Limit: 10 requests per second
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalWithdrawHistoryResponse>> WithdrawHistorySupportingNetworkUserData(long timestamp,
        string signature,
        string? coin,
        string? withdrawOrderId,
        int? status,
        long? startTime,
        long? endTime,
        int? offset,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/withdraw/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("coin", coin),
                new Param("withdrawOrderId", withdrawOrderId),
                new Param("status", status),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("offset", offset),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalWithdrawHistoryResponse>>(),
            WithdrawHistorySupportingNetworkUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
