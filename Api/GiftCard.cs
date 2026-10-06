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
using Binance.Requests.GiftCard;

namespace Binance.Api;

/// <summary>
/// Gift Card Endpoints
/// </summary>
public sealed class GiftCard
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GiftCard(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Buy a Binance Code (TRADE)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardBuyCodeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="BuyABinanceCodeTradeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is for buying a fixed-value Binance Code, which means your Binance Code will be redeemable to a token that is different to the token that you are paying in. If the token you’re paying and the redeemable token are the same, please use the Create Binance Code endpoint.
    /// You can use supported crypto currency or fiat token as baseToken to buy Binance Code that is redeemable to your chosen faceToken.
    /// Once successfully purchased, the amount of baseToken would be deducted from your funding wallet.
    /// <para>
    /// To get started with, please make sure:
    /// - You have a Binance account
    /// - You have passed kyc
    /// - You have a sufficient balance in your Binance funding wallet
    /// - You need Enable Withdrawals for the API Key which requests this endpoint.
    /// </para>
    /// <para>
    /// Daily creation volume: 2 BTC / 24H Daily creation times: 200 Codes / 24H
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardBuyCodeResponse> BuyABinanceCodeTrade(BuyABinanceCodeTradeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/giftcard/buyCode"),
            [],
            [
                new Param("baseToken", request.BaseToken),
                new Param("faceToken", request.FaceToken),
                new Param("baseTokenAmount", request.BaseTokenAmount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardBuyCodeResponse>(),
            BuyABinanceCodeTradeError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a Binance Code (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardCreateCodeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateABinanceCodeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is for creating a Binance Code. To get started with, please make sure:
    /// <list type="bullet">
    ///   <item><description>You have a Binance account</description></item>
    ///   <item><description>You have passed kyc</description></item>
    ///   <item><description>You have a sufficient balance in your Binance funding wallet</description></item>
    ///   <item><description>You need Enable Withdrawals for the API Key which requests this endpoint.</description></item>
    /// </list>
    /// <para>
    /// Daily creation volume: 2 BTC / 24H Daily creation times: 200 Codes / 24H
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardCreateCodeResponse> CreateABinanceCodeUserData(CreateABinanceCodeUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/giftcard/createCode"),
            [],
            [
                new Param("token", request.Token),
                new Param("amount", request.Amount),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardCreateCodeResponse>(),
            CreateABinanceCodeUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Fetch RSA Public Key (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardCryptographyRsaPublicKeyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FetchRsaPublicKeyUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is for fetching the RSA Public Key.
    /// This RSA Public key will be used to encrypt the card code.
    /// Please note that the RSA Public key fetched is valid only for the current day.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardCryptographyRsaPublicKeyResponse> FetchRsaPublicKeyUserData(FetchRsaPublicKeyUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/giftcard/cryptography/rsa-public-key"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardCryptographyRsaPublicKeyResponse>(),
            FetchRsaPublicKeyUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Fetch Token Limit (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardBuyCodeTokenLimitResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FetchTokenLimitUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is to help you verify which tokens are available for you to purchase fixed-value gift cards as mentioned in section 2 and it's limitation.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardBuyCodeTokenLimitResponse> FetchTokenLimitUserData(FetchTokenLimitUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/giftcard/buyCode/token-limit"),
            [],
            [
                new Param("baseToken", request.BaseToken),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardBuyCodeTokenLimitResponse>(),
            FetchTokenLimitUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Redeem a Binance Code (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardRedeemCodeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RedeemABinanceCodeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is for redeeming the Binance Code. Once redeemed, the coins will be deposited in your funding wallet.
    /// <para>
    /// Please note that if you enter the wrong code 5 times within 24 hours, you will no longer be able to redeem any Binance Code that day.
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardRedeemCodeResponse> RedeemABinanceCodeUserData(RedeemABinanceCodeUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/giftcard/redeemCode"),
            [],
            [
                new Param("code", request.Code),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("externalUid", request.ExternalUid),
                new Param("recvWindow", request.RecvWindow),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardRedeemCodeResponse>(),
            RedeemABinanceCodeUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Verify a Binance Code (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardVerifyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="VerifyABinanceCodeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is for verifying whether the Binance Code is valid or not by entering Binance Code or reference number.
    /// <para>
    /// Please note that if you enter the wrong binance code 5 times within an hour, you will no longer be able to verify any binance code for that hour.
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardVerifyResponse> VerifyABinanceCodeUserData(VerifyABinanceCodeUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/giftcard/verify"),
            [],
            [
                new Param("referenceNo", request.ReferenceNo),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardVerifyResponse>(),
            VerifyABinanceCodeUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
