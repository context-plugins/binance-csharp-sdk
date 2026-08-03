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
    /// <param name="subAccountString">Please input a string. We will create a virtual email using that string for you to register</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountVirtualSubAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateAVirtualSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>This request will generate a virtual sub account under your master account.</description></item>
    ///   <item><description>You need to enable "trade" option for the api key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountVirtualSubAccountResponse> CreateAVirtualSubAccountForMasterAccount(string subAccountString,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/virtualSubAccount"),
            [],
            [new Param("subAccountString", subAccountString),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountVirtualSubAccountResponse>(),
            CreateAVirtualSubAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete IP List for a Sub-account API Key (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="subAccountApiKey"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="ipAddress">Can be added in batches, separated by commas</param>
    /// <param name="thirdPartyName">third party IP list name</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteIpListForASubAccountApiKeyForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 3000
    /// </remarks>
    public Task<SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse> DeleteIpListForASubAccountApiKeyForMasterAccount(string email,
        string subAccountApiKey,
        long timestamp,
        string signature,
        string? ipAddress,
        string? thirdPartyName,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/subAccountApi/ipRestriction/ipList"),
            [],
            [new Param("email", email),
                new Param("subAccountApiKey", subAccountApiKey),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("ipAddress", ipAddress),
                new Param("thirdPartyName", thirdPartyName),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountSubAccountApiIpRestrictionIpListResponse>(),
            DeleteIpListForASubAccountApiKeyForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Deposit assets into the managed sub-account(For Investor Master Account)
    /// </summary>
    /// <param name="toEmail">Recipient email</param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountDepositResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1ManagedSubaccountDepositResponse> DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccount(string toEmail,
        string asset,
        double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/deposit"),
            [],
            [new Param("toEmail", toEmail),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountDepositResponse>(),
            DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Detail on Sub-account's Futures Account (For Master Account)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DetailOnSubAccountSFuturesAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1SubAccountFuturesAccountResponse> DetailOnSubAccountSFuturesAccountForMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/futures/account"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesAccountResponse>(),
            DetailOnSubAccountSFuturesAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Detail on Sub-account's Futures Account V2 (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="futuresType">* <c>1</c> - USDT Margined Futures * <c>2</c> - COIN Margined Futures</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2SubAccountFuturesAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DetailOnSubAccountSFuturesAccountV2ForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV2SubAccountFuturesAccountResponse> DetailOnSubAccountSFuturesAccountV2ForMasterAccount(string email,
        int futuresType,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/sub-account/futures/account"),
            [],
            [new Param("email", email),
                new Param("futuresType", futuresType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2SubAccountFuturesAccountResponse>(),
            DetailOnSubAccountSFuturesAccountV2ForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Detail on Sub-account's Margin Account (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountMarginAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DetailOnSubAccountSMarginAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1SubAccountMarginAccountResponse> DetailOnSubAccountSMarginAccountForMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/margin/account"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountMarginAccountResponse>(),
            DetailOnSubAccountSMarginAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Enable Futures for Sub-account (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesEnableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableFuturesForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountFuturesEnableResponse> EnableFuturesForSubAccountForMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/futures/enable"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesEnableResponse>(),
            EnableFuturesForSubAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Enable Leverage Token for Sub-account (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="enableBlvt">Only true for now</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountBlvtEnableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableLeverageTokenForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountBlvtEnableResponse> EnableLeverageTokenForSubAccountForMasterAccount(string email,
        bool enableBlvt,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/blvt/enable"),
            [],
            [new Param("email", email),
                new Param("enableBlvt", enableBlvt),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountBlvtEnableResponse>(),
            EnableLeverageTokenForSubAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Enable Margin for Sub-account (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountMarginEnableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableMarginForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountMarginEnableResponse> EnableMarginForSubAccountForMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/margin/enable"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountMarginEnableResponse>(),
            EnableMarginForSubAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Enable Options for Sub-account (For Master Account)(USER_DATA)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountEoptionsEnableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EnableOptionsForSubAccountForMasterAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable Options for Sub-account (For Master Account).
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountEoptionsEnableResponse> EnableOptionsForSubAccountForMasterAccountUserData(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/eoptions/enable"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountEoptionsEnableResponse>(),
            EnableOptionsForSubAccountForMasterAccountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Futures Position-Risk of Sub-account (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountFuturesPositionRiskResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FuturesPositionRiskOfSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountFuturesPositionRiskResponse>> FuturesPositionRiskOfSubAccountForMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/futures/positionRisk"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountFuturesPositionRiskResponse>>(),
            FuturesPositionRiskOfSubAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Futures Position-Risk of Sub-account V2 (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="futuresType">* <c>1</c> - USDT Margined Futures * <c>2</c> - COIN Margined Futures</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2SubAccountFuturesPositionRiskResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FuturesPositionRiskOfSubAccountV2ForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV2SubAccountFuturesPositionRiskResponse> FuturesPositionRiskOfSubAccountV2ForMasterAccount(string email,
        int futuresType,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/sub-account/futures/positionRisk"),
            [],
            [new Param("email", email),
                new Param("futuresType", futuresType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2SubAccountFuturesPositionRiskResponse>(),
            FuturesPositionRiskOfSubAccountV2ForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get IP Restriction for a Sub-account API Key (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="subAccountApiKey"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountSubAccountApiIpRestrictionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetIpRestrictionForASubAccountApiKeyForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(UID): 3000
    /// </remarks>
    public Task<SapiV1SubAccountSubAccountApiIpRestrictionResponse> GetIpRestrictionForASubAccountApiKeyForMasterAccount(string email,
        string subAccountApiKey,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/subAccountApi/ipRestriction"),
            [],
            [new Param("email", email),
                new Param("subAccountApiKey", subAccountApiKey),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountSubAccountApiIpRestrictionResponse>(),
            GetIpRestrictionForASubAccountApiKeyForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Managed Sub-account Deposit Address (For Investor Master Account)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="coin">Coin name</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="network"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountDepositAddressResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetManagedSubAccountDepositAddressForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get investor's managed sub-account deposit address
    /// <para>
    /// Weight(UID): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountDepositAddressResponse> GetManagedSubAccountDepositAddressForInvestorMasterAccount(string email,
        string coin,
        long timestamp,
        string signature,
        string? network,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/deposit/address"),
            [],
            [new Param("email", email),
                new Param("coin", coin),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("network", network),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountDepositAddressResponse>(),
            GetManagedSubAccountDepositAddressForInvestorMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Managed sub-account asset details(For Investor Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1ManagedSubaccountAssetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ManagedSubAccountAssetDetailsForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<IReadOnlyList<SapiV1ManagedSubaccountAssetResponse>> ManagedSubAccountAssetDetailsForInvestorMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/asset"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1ManagedSubaccountAssetResponse>>(),
            ManagedSubAccountAssetDetailsForInvestorMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Managed sub-account snapshot (For Investor Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="type">"SPOT", "MARGIN"(cross), "FUTURES"(UM)</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">min 7, max 30, default 7</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountAccountSnapshotResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ManagedSubAccountSnapshotForInvestorMasterAccountError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1ManagedSubaccountAccountSnapshotResponse> ManagedSubAccountSnapshotForInvestorMasterAccount(string email,
        string type,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/accountSnapshot"),
            [],
            [new Param("email", email),
                new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountAccountSnapshotResponse>(),
            ManagedSubAccountSnapshotForInvestorMasterAccountErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Margin Transfer for Sub-account (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="type">* <c>1</c> - transfer from subaccount's spot account to margin account * <c>2</c> - transfer from subaccount's margin account to its spot account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountMarginTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MarginTransferForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountMarginTransferResponse> MarginTransferForSubAccountForMasterAccount(string email,
        string asset,
        double amount,
        int type,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/margin/transfer"),
            [],
            [new Param("email", email),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountMarginTransferResponse>(),
            MarginTransferForSubAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Managed Sub Account Transfer Log (For Investor Master Account)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="transfers">Transfer Direction (FROM/TO)</param>
    /// <param name="transferFunctionAccountType">Transfer function account type (SPOT/MARGIN/ISOLATED_MARGIN/USDT_FUTURE/COIN_FUTURE)</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountQueryTransLogForInvestorResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryManagedSubAccountTransferLogForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Investor can use this api to query managed sub account transfer log. This endpoint is available for investor of Managed Sub-Account. A Managed Sub-Account is an account type for investors who value flexibility in asset allocation and account application, while delegating trades to a professional trading team.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountQueryTransLogForInvestorResponse> QueryManagedSubAccountTransferLogForInvestorMasterAccount(string email,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? page,
        int? limit,
        string? transfers,
        string? transferFunctionAccountType,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/queryTransLogForInvestor"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("limit", limit),
                new Param("transfers", transfers),
                new Param("transferFunctionAccountType", transferFunctionAccountType),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountQueryTransLogForInvestorResponse>(),
            QueryManagedSubAccountTransferLogForInvestorMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Managed Sub Account Transfer Log (For Trading Team Master Account)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="transfers">Transfer Direction (FROM/TO)</param>
    /// <param name="transferFunctionAccountType">Transfer function account type (SPOT/MARGIN/ISOLATED_MARGIN/USDT_FUTURE/COIN_FUTURE)</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryManagedSubAccountTransferLogForTradingTeamMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Trading team can use this api to query managed sub account transfer log. This endpoint is available for trading team of Managed Sub-Account. A Managed Sub-Account is an account type for investors who value flexibility in asset allocation and account application, while delegating trades to a professional trading team
    /// <para>
    /// Weight(IP): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse> QueryManagedSubAccountTransferLogForTradingTeamMasterAccount(string email,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? page,
        int? limit,
        string? transfers,
        string? transferFunctionAccountType,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/queryTransLogForTradeParent"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("limit", limit),
                new Param("transfers", transfers),
                new Param("transferFunctionAccountType", transferFunctionAccountType),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountQueryTransLogForTradeParentResponse>(),
            QueryManagedSubAccountTransferLogForTradingTeamMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Managed Sub Account Transfer Log (For Trading Team Sub Account)(USER_DATA)
    /// </summary>
    /// <param name="transfers">Transfer Direction</param>
    /// <param name="transferFunctionAccountType">Transfer function account type</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountQueryTransLogResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Managed Sub Account Transfer Log (For Trading Team Sub Account)
    /// <para>
    /// Weight(UID): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountQueryTransLogResponse> QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserData(Transfers transfers,
        TransferFunctionAccountType transferFunctionAccountType,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? page,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/query-trans-log"),
            [],
            [new Param("transfers", transfers),
                new Param("transferFunctionAccountType", transferFunctionAccountType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountQueryTransLogResponse>(),
            QueryManagedSubAccountTransferLogForTradingTeamSubAccountUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Managed Sub-account Futures Asset Details (For Investor Master Account)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountFetchFutureAssetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Investor can use this api to query managed sub account futures asset details
    /// </remarks>
    public Task<SapiV1ManagedSubaccountFetchFutureAssetResponse> QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/fetch-future-asset"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountFetchFutureAssetResponse>(),
            QueryManagedSubAccountFuturesAssetDetailsForInvestorMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Managed Sub-account List (For Investor)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryManagedSubAccountListForInvestorError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get investor's managed sub-account list.
    /// <para>
    /// Weight(UID): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1ManagedSubaccountInfoResponse> QueryManagedSubAccountListForInvestor(string email,
        long timestamp,
        string signature,
        int? page,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/info"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("page", page),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountInfoResponse>(),
            QueryManagedSubAccountListForInvestorErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Managed Sub-account Margin Asset Details (For Investor Master Account)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountMarginAssetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Investor can use this api to query managed sub account margin asset details
    /// </remarks>
    public Task<SapiV1ManagedSubaccountMarginAssetResponse> QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/marginAsset"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountMarginAssetResponse>(),
            QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Sub-account Assets (For Master Account)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV4SubAccountAssetsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QuerySubAccountAssetsForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch sub-account assets
    /// <para>
    /// Weight(UID): 60
    /// </para>
    /// </remarks>
    public Task<SapiV4SubAccountAssetsResponse> QuerySubAccountAssetsForMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v4/sub-account/assets"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV4SubAccountAssetsResponse>(),
            QuerySubAccountAssetsForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Sub-account List (For Master Account)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="email">Sub-account email</param>
    /// <param name="isFreeze"></param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default 1; max 200</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QuerySubAccountListForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountListResponse> QuerySubAccountListForMasterAccount(long timestamp,
        string signature,
        string? email,
        IsFreeze? isFreeze,
        int? page,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/list"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("email", email),
                new Param("isFreeze", isFreeze),
                new Param("page", page),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountListResponse>(),
            QuerySubAccountListForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Query Sub-account Transaction Statistics (For Master Account)
    /// </summary>
    /// <param name="email"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountTransactionStatisticsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QuerySubAccountTransactionStatisticsForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query Sub-account Transaction statistics (For Master Account).
    /// <para>
    /// Weight(UID): 60
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountTransactionStatisticsResponse> QuerySubAccountTransactionStatisticsForMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/transaction-statistics"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountTransactionStatisticsResponse>(),
            QuerySubAccountTransactionStatisticsForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account Assets (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV3SubAccountAssetsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountAssetsForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch sub-account assets
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV3SubAccountAssetsResponse> SubAccountAssetsForMasterAccount(string email,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v3/sub-account/assets"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV3SubAccountAssetsResponse>(),
            SubAccountAssetsForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account Deposit History (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="coin">Coin name</param>
    /// <param name="status">0(0:pending,6: credited but cannot withdraw, 1:success)</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1CapitalDepositSubHisrecResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountDepositHistoryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch sub-account deposit history
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1CapitalDepositSubHisrecResponse>> SubAccountDepositHistoryForMasterAccount(string email,
        long timestamp,
        string signature,
        string? coin,
        int? status,
        long? startTime,
        long? endTime,
        long? limit,
        int? offset,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/deposit/subHisrec"),
            [],
            [new Param("email", email),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("coin", coin),
                new Param("status", status),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("limit", limit),
                new Param("offset", offset),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1CapitalDepositSubHisrecResponse>>(),
            SubAccountDepositHistoryForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account Futures Asset Transfer (For Master Account)
    /// </summary>
    /// <param name="fromEmail">Sender email</param>
    /// <param name="toEmail">Recipient email</param>
    /// <param name="futuresType">1:USDT-margined Futures,2: Coin-margined Futures</param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesInternalTransferResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountFuturesAssetTransferForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>Master account can transfer max 2000 times a minute</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountFuturesInternalTransferResponse1> SubAccountFuturesAssetTransferForMasterAccount(string fromEmail,
        string toEmail,
        int futuresType,
        string asset,
        double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/futures/internalTransfer"),
            [],
            [new Param("fromEmail", fromEmail),
                new Param("toEmail", toEmail),
                new Param("futuresType", futuresType),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesInternalTransferResponse1>(),
            SubAccountFuturesAssetTransferForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account Futures Asset Transfer History (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="futuresType">1:USDT-margined Futures, 2: Coin-margined Futures</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default value: 50, Max value: 500</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesInternalTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountFuturesAssetTransferHistoryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountFuturesInternalTransferResponse> SubAccountFuturesAssetTransferHistoryForMasterAccount(string email,
        int futuresType,
        long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? page,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/futures/internalTransfer"),
            [],
            [new Param("email", email),
                new Param("futuresType", futuresType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesInternalTransferResponse>(),
            SubAccountFuturesAssetTransferHistoryForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account Spot Asset Transfer History (For Master Account)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="fromEmail">Sub-account email</param>
    /// <param name="toEmail">Sub-account email</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default 1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountSubTransferHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountSpotAssetTransferHistoryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>fromEmail and toEmail cannot be sent at the same time.</description></item>
    ///   <item><description>Return fromEmail equal master account email by default.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountSubTransferHistoryResponse>> SubAccountSpotAssetTransferHistoryForMasterAccount(long timestamp,
        string signature,
        string? fromEmail,
        string? toEmail,
        long? startTime,
        long? endTime,
        int? page,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/sub/transfer/history"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("fromEmail", fromEmail),
                new Param("toEmail", toEmail),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountSubTransferHistoryResponse>>(),
            SubAccountSpotAssetTransferHistoryForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account Spot Assets Summary (For Master Account)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="email">Sub-account email</param>
    /// <param name="page">Default 1</param>
    /// <param name="size">Default:10 Max:20</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountSpotSummaryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountSpotAssetsSummaryForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get BTC valued asset summary of subaccounts.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1SubAccountSpotSummaryResponse> SubAccountSpotAssetsSummaryForMasterAccount(long timestamp,
        string signature,
        string? email,
        int? page,
        int? size,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/spotSummary"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("email", email),
                new Param("page", page),
                new Param("size", size),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountSpotSummaryResponse>(),
            SubAccountSpotAssetsSummaryForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account Spot Assets Summary (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="coin">Coin name</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="network"></param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1CapitalDepositSubAddressResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountSpotAssetsSummaryForMasterAccount2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch sub-account deposit address
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1CapitalDepositSubAddressResponse> SubAccountSpotAssetsSummaryForMasterAccount2(string email,
        string coin,
        long timestamp,
        string signature,
        string? network,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/capital/deposit/subAddress"),
            [],
            [new Param("email", email),
                new Param("coin", coin),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("network", network),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1CapitalDepositSubAddressResponse>(),
            SubAccountSpotAssetsSummaryForMasterAccount2ErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account Transfer History (For Sub-account)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="asset"></param>
    /// <param name="type">* <c>1</c> - transfer in * <c>2</c> - transfer out</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="limit">Default 500; max 1000.</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountTransferSubUserHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountTransferHistoryForSubAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If <c>type</c> is not sent, the records of type 2: transfer out will be returned by default.</description></item>
    ///   <item><description>If <c>startTime</c> and <c>endTime</c> are not sent, the recent 30-day data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountTransferSubUserHistoryResponse>> SubAccountTransferHistoryForSubAccount(long timestamp,
        string signature,
        string? asset,
        int? type,
        long? startTime,
        long? endTime,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/transfer/subUserHistory"),
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
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountTransferSubUserHistoryResponse>>(),
            SubAccountTransferHistoryForSubAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Sub-account's Status on Margin/Futures (For Master Account)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="email">Sub-account email</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubAccountSStatusOnMarginFuturesForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If no <c>email</c> sent, all sub-accounts' information will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 10
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<SapiV1SubAccountStatusResponse>> SubAccountSStatusOnMarginFuturesForMasterAccount(long timestamp,
        string signature,
        string? email,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/status"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("email", email),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountStatusResponse>>(),
            SubAccountSStatusOnMarginFuturesForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Summary of Sub-account's Futures Account (For Master Account)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesAccountSummaryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SummaryOfSubAccountSFuturesAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountFuturesAccountSummaryResponse> SummaryOfSubAccountSFuturesAccountForMasterAccount(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/futures/accountSummary"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesAccountSummaryResponse>(),
            SummaryOfSubAccountSFuturesAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Summary of Sub-account's Futures Account V2 (For Master Account)
    /// </summary>
    /// <param name="futuresType">* <c>1</c> - USDT Margined Futures * <c>2</c> - COIN Margined Futures</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default 10, Max 20</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2SubAccountFuturesAccountSummaryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SummaryOfSubAccountSFuturesAccountV2ForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV2SubAccountFuturesAccountSummaryResponse> SummaryOfSubAccountSFuturesAccountV2ForMasterAccount(int futuresType,
        long timestamp,
        string signature,
        int? page,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/sub-account/futures/accountSummary"),
            [],
            [new Param("futuresType", futuresType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("page", page),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2SubAccountFuturesAccountSummaryResponse>(),
            SummaryOfSubAccountSFuturesAccountV2ForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Summary of Sub-account's Margin Account (For Master Account)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountMarginAccountSummaryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SummaryOfSubAccountSMarginAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 10
    /// </remarks>
    public Task<SapiV1SubAccountMarginAccountSummaryResponse> SummaryOfSubAccountSMarginAccountForMasterAccount(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/margin/accountSummary"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountMarginAccountSummaryResponse>(),
            SummaryOfSubAccountSMarginAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Transfer for Sub-account (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="type">* <c>1</c> - transfer from subaccount's spot account to its USDT-margined futures account * <c>2</c> - transfer from subaccount's USDT-margined futures account to its spot account * <c>3</c> - transfer from subaccount's spot account to its COIN-margined futures account * <c>4</c> - transfer from subaccount's COIN-margined futures account to its spot account</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountFuturesTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TransferForSubAccountForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountFuturesTransferResponse> TransferForSubAccountForMasterAccount(string email,
        string asset,
        double amount,
        int type,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/futures/transfer"),
            [],
            [new Param("email", email),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("type", type),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountFuturesTransferResponse>(),
            TransferForSubAccountForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Transfer to Master (For Sub-account)
    /// </summary>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountTransferSubToMasterResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TransferToMasterForSubAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountTransferSubToMasterResponse> TransferToMasterForSubAccount(string asset,
        double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/transfer/subToMaster"),
            [],
            [new Param("asset", asset),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountTransferSubToMasterResponse>(),
            TransferToMasterForSubAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Transfer to Sub-account of Same Master (For Sub-account)
    /// </summary>
    /// <param name="toEmail">Recipient email</param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountTransferSubToSubResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TransferToSubAccountOfSameMasterForSubAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1SubAccountTransferSubToSubResponse> TransferToSubAccountOfSameMasterForSubAccount(string toEmail,
        string asset,
        double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/transfer/subToSub"),
            [],
            [new Param("toEmail", toEmail),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountTransferSubToSubResponse>(),
            TransferToSubAccountOfSameMasterForSubAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Universal Transfer (For Master Account)
    /// </summary>
    /// <param name="fromAccountType"></param>
    /// <param name="toAccountType"></param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="fromEmail">Sub-account email</param>
    /// <param name="toEmail">Sub-account email</param>
    /// <param name="clientTranId"></param>
    /// <param name="symbol">Only supported under ISOLATED_MARGIN type</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1SubAccountUniversalTransferResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UniversalTransferForMasterAccountError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1SubAccountUniversalTransferResponse1> UniversalTransferForMasterAccount(FromAccountType fromAccountType,
        ToAccountType toAccountType,
        string asset,
        double amount,
        long timestamp,
        string signature,
        string? fromEmail,
        string? toEmail,
        string? clientTranId,
        string? symbol,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/universalTransfer"),
            [],
            [new Param("fromAccountType", fromAccountType),
                new Param("toAccountType", toAccountType),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("fromEmail", fromEmail),
                new Param("toEmail", toEmail),
                new Param("clientTranId", clientTranId),
                new Param("symbol", symbol),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1SubAccountUniversalTransferResponse1>(),
            UniversalTransferForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Universal Transfer History (For Master Account)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="fromEmail">Sub-account email</param>
    /// <param name="toEmail">Sub-account email</param>
    /// <param name="clientTranId"></param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="limit">Default 500, Max 500</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="SapiV1SubAccountUniversalTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UniversalTransferHistoryForMasterAccountError"/> when the server returns an error response.</exception>
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
    public Task<IReadOnlyList<SapiV1SubAccountUniversalTransferResponse>> UniversalTransferHistoryForMasterAccount(long timestamp,
        string signature,
        string? fromEmail,
        string? toEmail,
        string? clientTranId,
        long? startTime,
        long? endTime,
        int? page,
        int? limit,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/sub-account/universalTransfer"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("fromEmail", fromEmail),
                new Param("toEmail", toEmail),
                new Param("clientTranId", clientTranId),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("limit", limit),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<SapiV1SubAccountUniversalTransferResponse>>(),
            UniversalTransferHistoryForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update IP Restriction for Sub-Account API key (For Master Account)
    /// </summary>
    /// <param name="email">Sub-account email</param>
    /// <param name="subAccountApiKey"></param>
    /// <param name="status">IP Restriction status. 1 = IP Unrestricted. 2 = Restrict access to trusted IPs only. 3 = Restrict access to users' trusted third party IPs only</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="thirdPartyName">third party IP list name</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV2SubAccountSubAccountApiIpRestrictionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateIpRestrictionForSubAccountApiKeyForMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update IP Restriction for Sub-Account API key
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV2SubAccountSubAccountApiIpRestrictionResponse> UpdateIpRestrictionForSubAccountApiKeyForMasterAccount(string email,
        string subAccountApiKey,
        string status,
        long timestamp,
        string signature,
        string? thirdPartyName,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v2/sub-account/subAccountApi/ipRestriction"),
            [],
            [new Param("email", email),
                new Param("subAccountApiKey", subAccountApiKey),
                new Param("status", status),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("thirdPartyName", thirdPartyName),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV2SubAccountSubAccountApiIpRestrictionResponse>(),
            UpdateIpRestrictionForSubAccountApiKeyForMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Withdrawl assets from the managed sub-account(For Investor Master Account)
    /// </summary>
    /// <param name="fromEmail">Sender email</param>
    /// <param name="asset"></param>
    /// <param name="amount"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="transferDate">Withdrawals is automatically occur on the transfer date(UTC0). If a date is not selected, the withdrawal occurs right now</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1ManagedSubaccountWithdrawResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Weight(IP): 1
    /// </remarks>
    public Task<SapiV1ManagedSubaccountWithdrawResponse> WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccount(string fromEmail,
        string asset,
        double amount,
        long timestamp,
        string signature,
        long? transferDate,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/managed-subaccount/withdraw"),
            [],
            [new Param("fromEmail", fromEmail),
                new Param("asset", asset),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("transferDate", transferDate),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1ManagedSubaccountWithdrawResponse>(),
            WithdrawlAssetsFromTheManagedSubAccountForInvestorMasterAccountErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
