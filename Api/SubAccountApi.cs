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
using Binance.Requests.SubAccountApi;

namespace Binance.Api;

/// <summary>
/// Sub-account Endpoints
/// </summary>
public sealed class SubAccountApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SubAccountApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a Virtual Sub-account(For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountVirtualSubAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateAVirtualSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>This request will generate a virtual sub account under your master account.</description></item>
    ///   <item><description>You need to enable "trade" option for the api key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountVirtualSubAccountResponse> CreateAVirtualSubAccountForMasterAccount(CreateAVirtualSubAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/virtualSubAccount"),
            [],
            [
                new Param("subAccountString", request.SubAccountString),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountVirtualSubAccountResponse>(),
            CreateAVirtualSubAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete IP List for a Sub-account API Key (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteIpListForASubAccountApiKeyForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 3000
    /// </remarks>
    public Task<SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse> DeleteIpListForASubAccountApiKeyForMasterAccount(DeleteIpListForASubAccountApiKeyForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/subAccountApi/ipRestriction/ipList"),
            [],
            [
                new Param("email", request.Email),
                new Param("subAccountApiKey", request.SubAccountApiKey),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("ipAddress", request.IpAddress),
                new Param("thirdPartyName", request.ThirdPartyName),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse>(),
            DeleteIpListForASubAccountApiKeyForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deposit assets into the managed sub-account(For Investor Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountDepositResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1ManagedSubaccountDepositResponse> DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount(DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/deposit"),
            [],
            [
                new Param("toEmail", request.ToEmail),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountDepositResponse>(),
            DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Detail on Sub-account's Futures Account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DetailOnSubAccountSFuturesAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1SubAccountFuturesAccountResponse> DetailOnSubAccountSFuturesAccountForMasterAccount(DetailOnSubAccountSFuturesAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/futures/account"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesAccountResponse>(),
            DetailOnSubAccountSFuturesAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Detail on Sub-account's Futures Account V2 (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2SubAccountFuturesAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DetailOnSubAccountSFuturesAccountV2ForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV2SubAccountFuturesAccountResponse> DetailOnSubAccountSFuturesAccountV2ForMasterAccount(DetailOnSubAccountSFuturesAccountV2ForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/sub-account/futures/account"),
            [],
            [
                new Param("email", request.Email),
                new Param("futuresType", request.FuturesType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2SubAccountFuturesAccountResponse>(),
            DetailOnSubAccountSFuturesAccountV2ForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Detail on Sub-account's Margin Account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountMarginAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DetailOnSubAccountSMarginAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1SubAccountMarginAccountResponse> DetailOnSubAccountSMarginAccountForMasterAccount(DetailOnSubAccountSMarginAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/margin/account"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountMarginAccountResponse>(),
            DetailOnSubAccountSMarginAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Enable Futures for Sub-account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesEnableResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EnableFuturesForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountFuturesEnableResponse> EnableFuturesForSubAccountForMasterAccount(EnableFuturesForSubAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/futures/enable"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesEnableResponse>(),
            EnableFuturesForSubAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Enable Leverage Token for Sub-account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountBlvtEnableResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EnableLeverageTokenForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountBlvtEnableResponse> EnableLeverageTokenForSubAccountForMasterAccount(EnableLeverageTokenForSubAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/blvt/enable"),
            [],
            [
                new Param("email", request.Email),
                new Param("enableBlvt", request.EnableBlvt),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountBlvtEnableResponse>(),
            EnableLeverageTokenForSubAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Enable Margin for Sub-account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountMarginEnableResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EnableMarginForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountMarginEnableResponse> EnableMarginForSubAccountForMasterAccount(EnableMarginForSubAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/margin/enable"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountMarginEnableResponse>(),
            EnableMarginForSubAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Enable Options for Sub-account (For Master Account)(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountEoptionsEnableResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EnableOptionsForSubAccountForMasterAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable Options for Sub-account (For Master Account).
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountEoptionsEnableResponse> EnableOptionsForSubAccountForMasterAccountUserData(EnableOptionsForSubAccountForMasterAccountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/eoptions/enable"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountEoptionsEnableResponse>(),
            EnableOptionsForSubAccountForMasterAccountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Futures Position-Risk of Sub-account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountFuturesPositionRiskResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FuturesPositionRiskOfSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountFuturesPositionRiskResponse>> FuturesPositionRiskOfSubAccountForMasterAccount(FuturesPositionRiskOfSubAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/futures/positionRisk"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountFuturesPositionRiskResponse>>(),
            FuturesPositionRiskOfSubAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Futures Position-Risk of Sub-account V2 (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2SubAccountFuturesPositionRiskResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FuturesPositionRiskOfSubAccountV2ForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV2SubAccountFuturesPositionRiskResponse> FuturesPositionRiskOfSubAccountV2ForMasterAccount(FuturesPositionRiskOfSubAccountV2ForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/sub-account/futures/positionRisk"),
            [],
            [
                new Param("email", request.Email),
                new Param("futuresType", request.FuturesType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2SubAccountFuturesPositionRiskResponse>(),
            FuturesPositionRiskOfSubAccountV2ForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get IP Restriction for a Sub-account API Key (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountSubAccountApiIpRestrictionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetIpRestrictionForASubAccountApiKeyForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 3000
    /// </remarks>
    public Task<SapiV1SubAccountSubAccountApiIpRestrictionResponse> GetIpRestrictionForASubAccountApiKeyForMasterAccount(GetIpRestrictionForASubAccountApiKeyForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/subAccountApi/ipRestriction"),
            [],
            [
                new Param("email", request.Email),
                new Param("subAccountApiKey", request.SubAccountApiKey),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountSubAccountApiIpRestrictionResponse>(),
            GetIpRestrictionForASubAccountApiKeyForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Managed Sub-account Deposit Address (For Investor Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountDepositAddressResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetManagedSubAccountDepositAddressForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get investor's managed sub-account deposit address
    /// <para>
    /// Weight(UID): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountDepositAddressResponse> GetManagedSubAccountDepositAddressForInvestorMasterAccount(GetManagedSubAccountDepositAddressForInvestorMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/deposit/address"),
            [],
            [
                new Param("email", request.Email),
                new Param("coin", request.Coin),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("network", request.Network),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountDepositAddressResponse>(),
            GetManagedSubAccountDepositAddressForInvestorMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Managed sub-account asset details(For Investor Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1ManagedSubaccountAssetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ManagedSubAccountAssetDetailsForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1ManagedSubaccountAssetResponse>> ManagedSubAccountAssetDetailsForInvestorMasterAccount(ManagedSubAccountAssetDetailsForInvestorMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/asset"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1ManagedSubaccountAssetResponse>>(),
            ManagedSubAccountAssetDetailsForInvestorMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Managed sub-account snapshot (For Investor Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountAccountSnapshotResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ManagedSubAccountSnapshotForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The query time period must be less then 30 days</description></item>
    ///   <item><description>Support query within the last one month only</description></item>
    ///   <item><description>If <c>startTime</c> and <c>endTime</c> not sent, return records of the last 7 days by default</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 2400
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountAccountSnapshotResponse> ManagedSubAccountSnapshotForInvestorMasterAccount(ManagedSubAccountSnapshotForInvestorMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/accountSnapshot"),
            [],
            [
                new Param("email", request.Email),
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
            JsonResponse.Create<SapiV1ManagedSubaccountAccountSnapshotResponse>(),
            ManagedSubAccountSnapshotForInvestorMasterAccountError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Margin Transfer for Sub-account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountMarginTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="MarginTransferForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountMarginTransferResponse> MarginTransferForSubAccountForMasterAccount(MarginTransferForSubAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/margin/transfer"),
            [],
            [
                new Param("email", request.Email),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountMarginTransferResponse>(),
            MarginTransferForSubAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Managed Sub Account Transfer Log (For Investor Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountQueryTransLogForInvestorResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryManagedSubAccountTransferLogForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Investor can use this api to query managed sub account transfer log. This endpoint is available for investor of Managed Sub-Account. A Managed Sub-Account is an account type for investors who value flexibility in asset allocation and account application, while delegating trades to a professional trading team.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountQueryTransLogForInvestorResponse> QueryManagedSubAccountTransferLogForInvestorMasterAccount(QueryManagedSubAccountTransferLogForInvestorMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/queryTransLogForInvestor"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("transfers", request.Transfers),
                new Param("transferFunctionAccountType", request.TransferFunctionAccountType),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountQueryTransLogForInvestorResponse>(),
            QueryManagedSubAccountTransferLogForInvestorMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Managed Sub Account Transfer Log (For Trading Team Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Trading team can use this api to query managed sub account transfer log. This endpoint is available for trading team of Managed Sub-Account. A Managed Sub-Account is an account type for investors who value flexibility in asset allocation and account application, while delegating trades to a professional trading team
    /// <para>
    /// Weight(IP): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse> QueryManagedSubAccountTransferLogForTradingTeamMasterAccount(QueryManagedSubAccountTransferLogForTradingTeamMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/queryTransLogForTradeParent"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("transfers", request.Transfers),
                new Param("transferFunctionAccountType", request.TransferFunctionAccountType),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse>(),
            QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Managed Sub Account Transfer Log (For Trading Team Sub Account)(USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountQueryTransLogResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Managed Sub Account Transfer Log (For Trading Team Sub Account)
    /// <para>
    /// Weight(UID): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountQueryTransLogResponse> QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData(QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/query-trans-log"),
            [],
            [
                new Param("transfers", request.Transfers),
                new Param("transferFunctionAccountType", request.TransferFunctionAccountType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountQueryTransLogResponse>(),
            QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Managed Sub-account Futures Asset Details (For Investor Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountFetchFutureAssetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Investor can use this api to query managed sub account futures asset details
    /// </remarks>
    public Task<SapiV1ManagedSubaccountFetchFutureAssetResponse> QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount(QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/fetch-future-asset"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountFetchFutureAssetResponse>(),
            QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Managed Sub-account List (For Investor)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountInfoResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryManagedSubAccountListForInvestorError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get investor's managed sub-account list.
    /// <para>
    /// Weight(UID): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountInfoResponse> QueryManagedSubAccountListForInvestor(QueryManagedSubAccountListForInvestorRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/info"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountInfoResponse>(),
            QueryManagedSubAccountListForInvestorError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Managed Sub-account Margin Asset Details (For Investor Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountMarginAssetResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Investor can use this api to query managed sub account margin asset details
    /// </remarks>
    public Task<SapiV1ManagedSubaccountMarginAssetResponse> QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount(QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/marginAsset"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountMarginAssetResponse>(),
            QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Sub-account Assets (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV4SubAccountAssetsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QuerySubAccountAssetsForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch sub-account assets
    /// <para>
    /// Weight(UID): 60
    /// </para>
    /// </remarks>
    public Task<SapiV4SubAccountAssetsResponse> QuerySubAccountAssetsForMasterAccount(QuerySubAccountAssetsForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v4/sub-account/assets"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV4SubAccountAssetsResponse>(),
            QuerySubAccountAssetsForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Sub-account List (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QuerySubAccountListForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountListResponse> QuerySubAccountListForMasterAccount(QuerySubAccountListForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/list"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("email", request.Email),
                new Param("isFreeze", request.IsFreeze),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountListResponse>(),
            QuerySubAccountListForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Query Sub-account Transaction Statistics (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountTransactionStatisticsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="QuerySubAccountTransactionStatisticsForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Sub-account Transaction statistics (For Master Account).
    /// <para>
    /// Weight(UID): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountTransactionStatisticsResponse> QuerySubAccountTransactionStatisticsForMasterAccount(QuerySubAccountTransactionStatisticsForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/transaction-statistics"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountTransactionStatisticsResponse>(),
            QuerySubAccountTransactionStatisticsForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account Assets (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV3SubAccountAssetsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountAssetsForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch sub-account assets
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV3SubAccountAssetsResponse> SubAccountAssetsForMasterAccount(SubAccountAssetsForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v3/sub-account/assets"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV3SubAccountAssetsResponse>(),
            SubAccountAssetsForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account Deposit History (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalDepositSubHisrecResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountDepositHistoryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch sub-account deposit history
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalDepositSubHisrecResponse>> SubAccountDepositHistoryForMasterAccount(SubAccountDepositHistoryForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/deposit/subHisrec"),
            [],
            [
                new Param("email", request.Email),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("coin", request.Coin),
                new Param("status", request.Status),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("limit", request.Limit),
                new Param("offset", request.Offset),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalDepositSubHisrecResponse>>(),
            SubAccountDepositHistoryForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account Futures Asset Transfer (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesInternalTransferResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountFuturesAssetTransferForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Master account can transfer max 2000 times a minute</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountFuturesInternalTransferResponse1> SubAccountFuturesAssetTransferForMasterAccount(SubAccountFuturesAssetTransferForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/futures/internalTransfer"),
            [],
            [
                new Param("fromEmail", request.FromEmail),
                new Param("toEmail", request.ToEmail),
                new Param("futuresType", request.FuturesType),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesInternalTransferResponse1>(),
            SubAccountFuturesAssetTransferForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account Futures Asset Transfer History (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesInternalTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountFuturesAssetTransferHistoryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountFuturesInternalTransferResponse> SubAccountFuturesAssetTransferHistoryForMasterAccount(SubAccountFuturesAssetTransferHistoryForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/futures/internalTransfer"),
            [],
            [
                new Param("email", request.Email),
                new Param("futuresType", request.FuturesType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesInternalTransferResponse>(),
            SubAccountFuturesAssetTransferHistoryForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account Spot Asset Transfer History (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountSubTransferHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountSpotAssetTransferHistoryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>fromEmail and toEmail cannot be sent at the same time.</description></item>
    ///   <item><description>Return fromEmail equal master account email by default.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountSubTransferHistoryResponse>> SubAccountSpotAssetTransferHistoryForMasterAccount(SubAccountSpotAssetTransferHistoryForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/sub/transfer/history"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("fromEmail", request.FromEmail),
                new Param("toEmail", request.ToEmail),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountSubTransferHistoryResponse>>(),
            SubAccountSpotAssetTransferHistoryForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account Spot Assets Summary (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountSpotSummaryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountSpotAssetsSummaryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get BTC valued asset summary of subaccounts.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountSpotSummaryResponse> SubAccountSpotAssetsSummaryForMasterAccount(SubAccountSpotAssetsSummaryForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/spotSummary"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("email", request.Email),
                new Param("page", request.Page),
                new Param("size", request.Size),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountSpotSummaryResponse>(),
            SubAccountSpotAssetsSummaryForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account Spot Assets Summary (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalDepositSubAddressResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountSpotAssetsSummaryForMasterAccount2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch sub-account deposit address
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1CapitalDepositSubAddressResponse> SubAccountSpotAssetsSummaryForMasterAccount2(SubAccountSpotAssetsSummaryForMasterAccount2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/capital/deposit/subAddress"),
            [],
            [
                new Param("email", request.Email),
                new Param("coin", request.Coin),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("network", request.Network),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalDepositSubAddressResponse>(),
            SubAccountSpotAssetsSummaryForMasterAccount2Error.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account Transfer History (For Sub-account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountTransferSubUserHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountTransferHistoryForSubAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>type</c> is not sent, the records of type 2: transfer out will be returned by default.</description></item>
    ///   <item><description>If <c>startTime</c> and <c>endTime</c> are not sent, the recent 30-day data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountTransferSubUserHistoryResponse>> SubAccountTransferHistoryForSubAccount(SubAccountTransferHistoryForSubAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/transfer/subUserHistory"),
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
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountTransferSubUserHistoryResponse>>(),
            SubAccountTransferHistoryForSubAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sub-account's Status on Margin/Futures (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubAccountSStatusOnMarginFuturesForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If no <c>email</c> sent, all sub-accounts' information will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountStatusResponse>> SubAccountSStatusOnMarginFuturesForMasterAccount(SubAccountSStatusOnMarginFuturesForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/status"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("email", request.Email),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountStatusResponse>>(),
            SubAccountSStatusOnMarginFuturesForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Summary of Sub-account's Futures Account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesAccountSummaryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SummaryOfSubAccountSFuturesAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountFuturesAccountSummaryResponse> SummaryOfSubAccountSFuturesAccountForMasterAccount(SummaryOfSubAccountSFuturesAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/futures/accountSummary"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesAccountSummaryResponse>(),
            SummaryOfSubAccountSFuturesAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Summary of Sub-account's Futures Account V2 (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2SubAccountFuturesAccountSummaryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV2SubAccountFuturesAccountSummaryResponse> SummaryOfSubAccountSFuturesAccountV2ForMasterAccount(SummaryOfSubAccountSFuturesAccountV2ForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/sub-account/futures/accountSummary"),
            [],
            [
                new Param("futuresType", request.FuturesType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2SubAccountFuturesAccountSummaryResponse>(),
            SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Summary of Sub-account's Margin Account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountMarginAccountSummaryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SummaryOfSubAccountSMarginAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1SubAccountMarginAccountSummaryResponse> SummaryOfSubAccountSMarginAccountForMasterAccount(SummaryOfSubAccountSMarginAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/margin/accountSummary"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountMarginAccountSummaryResponse>(),
            SummaryOfSubAccountSMarginAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Transfer for Sub-account (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TransferForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountFuturesTransferResponse> TransferForSubAccountForMasterAccount(TransferForSubAccountForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/futures/transfer"),
            [],
            [
                new Param("email", request.Email),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("type", request.Type),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesTransferResponse>(),
            TransferForSubAccountForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Transfer to Master (For Sub-account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountTransferSubToMasterResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TransferToMasterForSubAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountTransferSubToMasterResponse> TransferToMasterForSubAccount(TransferToMasterForSubAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/transfer/subToMaster"),
            [],
            [
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountTransferSubToMasterResponse>(),
            TransferToMasterForSubAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Transfer to Sub-account of Same Master (For Sub-account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountTransferSubToSubResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="TransferToSubAccountOfSameMasterForSubAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountTransferSubToSubResponse> TransferToSubAccountOfSameMasterForSubAccount(TransferToSubAccountOfSameMasterForSubAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/transfer/subToSub"),
            [],
            [
                new Param("toEmail", request.ToEmail),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountTransferSubToSubResponse>(),
            TransferToSubAccountOfSameMasterForSubAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Universal Transfer (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountUniversalTransferResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UniversalTransferForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>You need to enable "internal transfer" option for the api key which requests this endpoint.</description></item>
    ///   <item><description>Transfer from master account by default if fromEmail is not sent.</description></item>
    ///   <item><description>Transfer to master account by default if toEmail is not sent.</description></item>
    ///   <item><description>Supported transfer scenarios:
    ///     <list type="bullet">
    ///       <item><description>Master account SPOT transfer to sub-account SPOT,USDT_FUTURE,COIN_FUTURE,MARGIN(Cross),ISOLATED_MARGIN</description></item>
    ///       <item><description>Sub-account SPOT,USDT_FUTURE,COIN_FUTURE,MARGIN(Cross),ISOLATED_MARGIN transfer to master account SPOT</description></item>
    ///       <item><description>Transfer between two sub-account SPOT accounts</description></item>
    ///     </list>
    ///   </description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountUniversalTransferResponse1> UniversalTransferForMasterAccount(UniversalTransferForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/universalTransfer"),
            [],
            [
                new Param("fromAccountType", request.FromAccountType),
                new Param("toAccountType", request.ToAccountType),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("fromEmail", request.FromEmail),
                new Param("toEmail", request.ToEmail),
                new Param("clientTranId", request.ClientTranId),
                new Param("symbol", request.Symbol),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountUniversalTransferResponse1>(),
            UniversalTransferForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Universal Transfer History (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountUniversalTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UniversalTransferHistoryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description><c>fromEmail</c> and <c>toEmail</c> cannot be sent at the same time.</description></item>
    ///   <item><description>Return <c>fromEmail</c> equal master account email by default.</description></item>
    ///   <item><description>The query time period must be less then 30 days.</description></item>
    ///   <item><description>If startTime and endTime not sent, return records of the last 30 days by default.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountUniversalTransferResponse>> UniversalTransferHistoryForMasterAccount(UniversalTransferHistoryForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/sub-account/universalTransfer"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("fromEmail", request.FromEmail),
                new Param("toEmail", request.ToEmail),
                new Param("clientTranId", request.ClientTranId),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("limit", request.Limit),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountUniversalTransferResponse>>(),
            UniversalTransferHistoryForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update IP Restriction for Sub-Account API key (For Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2SubAccountSubAccountApiIpRestrictionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update IP Restriction for Sub-Account API key
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV2SubAccountSubAccountApiIpRestrictionResponse> UpdateIpRestrictionForSubAccountApiKeyForMasterAccount(UpdateIpRestrictionForSubAccountApiKeyForMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v2/sub-account/subAccountApi/ipRestriction"),
            [],
            [
                new Param("email", request.Email),
                new Param("subAccountApiKey", request.SubAccountApiKey),
                new Param("status", request.Status),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("thirdPartyName", request.ThirdPartyName),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2SubAccountSubAccountApiIpRestrictionResponse>(),
            UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Withdrawl assets from the managed sub-account(For Investor Master Account)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountWithdrawResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1ManagedSubaccountWithdrawResponse> WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount(WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/managed-subaccount/withdraw"),
            [],
            [
                new Param("fromEmail", request.FromEmail),
                new Param("asset", request.Asset),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("transferDate", request.TransferDate),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountWithdrawResponse>(),
            WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
