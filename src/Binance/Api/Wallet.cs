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
using Binance.Requests.Wallet;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountApiTradingStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountApiTradingStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch account API trading status with details.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AccountApiTradingStatusResponse> AccountApiTradingStatusUserData(AccountApiTradingStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/account/apiTradingStatus"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountApiTradingStatusResponse>(),
            AccountApiTradingStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Account Status (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountStatusUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch account status detail.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AccountStatusResponse> AccountStatusUserData(AccountStatusUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/account/status"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountStatusResponse>(),
            AccountStatusUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Account info (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AccountInfoUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch account info detail.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AccountInfoResponse> AccountInfoUserData(AccountInfoUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/account/info"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountInfoResponse>(),
            AccountInfoUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// All Coins' Information (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalConfigGetallResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AllCoinsInformationUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get information of coins (available for deposit and withdraw) for user.
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalConfigGetallResponse>> AllCoinsInformationUserData(AllCoinsInformationUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/config/getall"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalConfigGetallResponse>>(),
            AllCoinsInformationUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Asset Detail (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetAssetDetailResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AssetDetailUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch details of assets supported on Binance.
    /// <list type="bullet">
    ///   <item><description>Please get network and other deposit or withdraw details from <c>GET /sapi/v1/capital/config/getall</c>.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetAssetDetailResponse> AssetDetailUserData(AssetDetailUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/assetDetail"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetAssetDetailResponse>(),
            AssetDetailUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Asset Dividend Record (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetAssetDividendResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AssetDividendRecordUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query asset Dividend Record
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetAssetDividendResponse> AssetDividendRecordUserData(AssetDividendRecordUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/assetDividend"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetAssetDividendResponse>(),
            AssetDividendRecordUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Convert Transfer (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetConvertTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ConvertTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Convert transfer, convert between BUSD and stablecoins.
    /// If the clientId has been used before, will not do the convert transfer, the original transfer will be returned.
    /// <para>
    /// Weight(UID): 5
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetConvertTransferResponse> ConvertTransferUserData(ConvertTransferUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/convert-transfer"),
            [],
            [
                new Param("clientTranId", request.ClientTranId),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("targetAsset", request.TargetAsset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetConvertTransferResponse>(),
            ConvertTransferUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Daily Account Snapshot (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountSnapshotResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DailyAccountSnapshotUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1AccountSnapshotResponse> DailyAccountSnapshotUserData(DailyAccountSnapshotUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/accountSnapshot"),
            [],
            [
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountSnapshotResponse>(),
            DailyAccountSnapshotUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deposit Address (supporting network) (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalDepositAddressResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DepositAddressSupportingNetworkUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1CapitalDepositAddressResponse> DepositAddressSupportingNetworkUserData(DepositAddressSupportingNetworkUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/deposit/address"),
            [],
            [
                new Param("coin", request.Coin),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("network", request.Network),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalDepositAddressResponse>(),
            DepositAddressSupportingNetworkUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deposit History(supporting network) (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalDepositHisrecResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DepositHistorySupportingNetworkUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<SapiV1CapitalDepositHisrecResponse>> DepositHistorySupportingNetworkUserData(DepositHistorySupportingNetworkUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/deposit/hisrec"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("coin", request.Coin),
                new Param("status", request.Status),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("offset", request.Offset),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalDepositHisrecResponse>>(),
            DepositHistorySupportingNetworkUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Disable Fast Withdraw Switch (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DisableFastWithdrawSwitchUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>This request will disable fastwithdraw switch under your account.</description></item>
    ///   <item><description>You need to enable "trade" option for the api key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<object> DisableFastWithdrawSwitchUserData(DisableFastWithdrawSwitchUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/account/disableFastWithdrawSwitch"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DisableFastWithdrawSwitchUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Dust Transfer (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetDustResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DustTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Convert dust assets to BNB.
    /// <para>
    /// Weight(UID): 10
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetDustResponse> DustTransferUserData(DustTransferUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/dust"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("accountType", request.AccountType),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetDustResponse>(),
            DustTransferUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DustLog(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetDribbletResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DustLogUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1AssetDribbletResponse> DustLogUserData(DustLogUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/dribblet"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("accountType", request.AccountType),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetDribbletResponse>(),
            DustLogUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Enable Fast Withdraw Switch (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EnableFastWithdrawSwitchUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>This request will enable fastwithdraw switch under your account. You need to enable "trade" option for the api key which requests this endpoint.</description></item>
    ///   <item><description>When Fast Withdraw Switch is on, transferring funds to a Binance account will be done instantly. There is no on-chain transaction, no transaction ID and no withdrawal fee.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<object> EnableFastWithdrawSwitchUserData(EnableFastWithdrawSwitchUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/account/enableFastWithdrawSwitch"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            EnableFastWithdrawSwitchUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Fetch deposit address list with network (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalDepositAddressListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FetchDepositAddressListWithNetworkUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch deposit address list with network.
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalDepositAddressListResponse>> FetchDepositAddressListWithNetworkUserData(FetchDepositAddressListWithNetworkUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/deposit/address/list"),
            [],
            [
                new Param("coin", request.Coin),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("network", request.Network),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalDepositAddressListResponse>>(),
            FetchDepositAddressListWithNetworkUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Fetch withdraw address list (USER_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalWithdrawAddressListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FetchWithdrawAddressListUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch withdraw address list
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalWithdrawAddressListResponse>> FetchWithdrawAddressListUserData(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/withdraw/address/list"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalWithdrawAddressListResponse>>(),
            FetchWithdrawAddressListUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Funding Wallet (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1AssetGetFundingAssetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FundingWalletUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Currently supports querying the following business assets：Binance Pay, Binance Card, Binance Gift Card, Stock Token</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1AssetGetFundingAssetResponse>> FundingWalletUserData(FundingWalletUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/get-funding-asset"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("needBtcValuation", request.NeedBtcValuation),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1AssetGetFundingAssetResponse>>(),
            FundingWalletUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get API Key Permission (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AccountApiRestrictionsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetApiKeyPermissionUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1AccountApiRestrictionsResponse> GetApiKeyPermissionUserData(GetApiKeyPermissionUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/account/apiRestrictions"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AccountApiRestrictionsResponse>(),
            GetApiKeyPermissionUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Assets That Can Be Converted Into BNB (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetDustBtcResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAssetsThatCanBeConvertedIntoBnbUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1AssetDustBtcResponse> GetAssetsThatCanBeConvertedIntoBnbUserData(GetAssetsThatCanBeConvertedIntoBnbUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/dust-btc"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("accountType", request.AccountType),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetDustBtcResponse>(),
            GetAssetsThatCanBeConvertedIntoBnbUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Cloud-Mining payment and refund history (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCloudMiningPaymentAndRefundHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The query of Cloud-Mining payment and refund history
    /// <para>
    /// Weight(UID): 600
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse> GetCloudMiningPaymentAndRefundHistoryUserData(GetCloudMiningPaymentAndRefundHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/ledger-transfer/cloud-mining/queryByPage"),
            [],
            [
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("tranId", request.TranId),
                new Param("clientTranId", request.ClientTranId),
                new Param("asset", request.Asset),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetLedgerTransferCloudMiningQueryByPageResponse>(),
            GetCloudMiningPaymentAndRefundHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get symbols delist schedule for spot (MARKET_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SpotDelistScheduleResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSymbolsDelistScheduleForSpotMarketDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get symbols delist schedule for spot
    /// <para>
    /// Weight(IP): 100
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SpotDelistScheduleResponse>> GetSymbolsDelistScheduleForSpotMarketData(GetSymbolsDelistScheduleForSpotMarketDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/spot/delist-schedule"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SpotDelistScheduleResponse>>(),
            GetSymbolsDelistScheduleForSpotMarketDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// One click arrival deposit apply (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalDepositCreditApplyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="OneClickArrivalDepositApplyUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Apply deposit credit for expired address (One click arrival)
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1CapitalDepositCreditApplyResponse> OneClickArrivalDepositApplyUserData(OneClickArrivalDepositApplyUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/deposit/credit-apply"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("depositId", request.DepositId),
                new Param("txId", request.TxId),
                new Param("subAccountId", request.SubAccountId),
                new Param("subUserId", request.SubUserId),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalDepositCreditApplyResponse>(),
            OneClickArrivalDepositApplyUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Convert Transfer (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetConvertTransferQueryByPageResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryConvertTransferUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 5
    /// </remarks>
    public Task<SapiV1AssetConvertTransferQueryByPageResponse> QueryConvertTransferUserData(QueryConvertTransferUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/convert-transfer/queryByPage"),
            [],
            [
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("tranId", request.TranId),
                new Param("asset", request.Asset),
                new Param("accountType", request.AccountType),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetConvertTransferQueryByPageResponse>(),
            QueryConvertTransferUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query User Delegation History(For Master Account) (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetCustodyTransferHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryUserDelegationHistoryForMasterAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query User Delegation History
    /// <para>
    /// Weight(IP): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1AssetCustodyTransferHistoryResponse> QueryUserDelegationHistoryForMasterAccountUserData(QueryUserDelegationHistoryForMasterAccountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/custody/transfer-history"),
            [],
            [
                new Param("email", request.Email),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("asset", request.Asset),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("type", request.Type),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetCustodyTransferHistoryResponse>(),
            QueryUserDelegationHistoryForMasterAccountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query User Universal Transfer History (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryUserUniversalTransferHistoryUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1AssetTransferResponse> QueryUserUniversalTransferHistoryUserData(QueryUserUniversalTransferHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/transfer"),
            [],
            [
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("current", request.Current),
                new Param("size", request.Size),
                new Param("fromSymbol", request.FromSymbol),
                new Param("toSymbol", request.ToSymbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetTransferResponse>(),
            QueryUserUniversalTransferHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query User Wallet Balance (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1AssetWalletBalanceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryUserWalletBalanceUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query User Wallet Balance
    /// <para>
    /// Weight(IP): 60
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1AssetWalletBalanceResponse>> QueryUserWalletBalanceUserData(QueryUserWalletBalanceUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/wallet/balance"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1AssetWalletBalanceResponse>>(),
            QueryUserWalletBalanceUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query auto-converting stable coins (USER_DATA)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalContractConvertibleCoinsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryAutoConvertingStableCoinsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a user's auto-conversion settings in deposit/withdrawal
    /// <para>
    /// Weight(UID): 600'
    /// </para>
    /// </remarks>
    public Task<SapiV1CapitalContractConvertibleCoinsResponse> QueryAutoConvertingStableCoinsUserData(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/contract/convertible-coins"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalContractConvertibleCoinsResponse>(),
            QueryAutoConvertingStableCoinsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Switch on/off BUSD and stable coins conversion (USER_DATA) (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// User can use it to turn on or turn off the BUSD auto-conversion from/to a specific stable coin.
    /// <para>
    /// Weight(UID): 600'
    /// </para>
    /// </remarks>
    public Task<object> SwitchOnOffBusdAndStableCoinsConversionUserDataUserData(SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/contract/convertible-coins"),
            [],
            [new Param("coin", request.Coin), new Param("enable", request.Enable)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            SwitchOnOffBusdAndStableCoinsConversionUserDataUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// System Status (System)
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SystemStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch system status.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SystemStatusResponse> SystemStatusSystem(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/system/status"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SystemStatusResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Trade Fee (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1AssetTradeFeeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TradeFeeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch trade fee
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1AssetTradeFeeResponse>> TradeFeeUserData(TradeFeeUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/tradeFee"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("symbol", request.Symbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1AssetTradeFeeResponse>>(),
            TradeFeeUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// User Asset (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV3AssetGetUserAssetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UserAssetUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get user assets, just for positive data.
    /// <para>
    /// Weight(IP): 5
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV3AssetGetUserAssetResponse>> UserAssetUserData(UserAssetUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v3/asset/getUserAsset"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("asset", request.Asset),
                new Param("needBtcValuation", request.NeedBtcValuation),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV3AssetGetUserAssetResponse>>(),
            UserAssetUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// User Universal Transfer (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1AssetTransferResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UserUniversalTransferUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1AssetTransferResponse1> UserUniversalTransferUserData(UserUniversalTransferUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/asset/transfer"),
            [],
            [
                new Param("type", request.Type),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("fromSymbol", request.FromSymbol),
                new Param("toSymbol", request.ToSymbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1AssetTransferResponse1>(),
            UserUniversalTransferUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Withdraw (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalWithdrawApplyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="WithdrawUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1CapitalWithdrawApplyResponse> WithdrawUserData(WithdrawUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/withdraw/apply"),
            [],
            [
                new Param("coin", request.Coin),
                new Param("address", request.Address),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("withdrawOrderId", request.WithdrawOrderId),
                new Param("network", request.Network),
                new Param("addressTag", request.AddressTag),
                new Param("transactionFeeFlag", request.TransactionFeeFlag),
                new Param("name", request.Name),
                new Param("walletType", request.WalletType),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalWithdrawApplyResponse>(),
            WithdrawUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Withdraw History (supporting network) (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalWithdrawHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="WithdrawHistorySupportingNetworkUserDataError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<SapiV1CapitalWithdrawHistoryResponse>> WithdrawHistorySupportingNetworkUserData(WithdrawHistorySupportingNetworkUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/withdraw/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("coin", request.Coin),
                new Param("withdrawOrderId", request.WithdrawOrderId),
                new Param("status", request.Status),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("offset", request.Offset),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalWithdrawHistoryResponse>>(),
            WithdrawHistorySupportingNetworkUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
