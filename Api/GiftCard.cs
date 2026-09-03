using System;
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

namespace BinancePublicSpotApi.Api;

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
    /// <param name="baseToken">The token you want to pay, example BUSD</param>
    /// <param name="faceToken">The token you want to buy, example BNB. If faceToken = baseToken, it's the same as createCode endpoint.</param>
    /// <param name="baseTokenAmount">The base token asset quantity, example  1.002</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardBuyCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BuyABinanceCodeTradeError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1GiftcardBuyCodeResponse> BuyABinanceCodeTrade(string baseToken,
        string faceToken,
        double baseTokenAmount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/giftcard/buyCode"),
            [],
            [new Param("baseToken", baseToken),
                new Param("faceToken", faceToken),
                new Param("baseTokenAmount", baseTokenAmount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardBuyCodeResponse>(),
            BuyABinanceCodeTradeErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create a Binance Code (USER_DATA)
    /// </summary>
    /// <param name="token">The coin type contained in the Binance Code</param>
    /// <param name="amount">The amount of the coin</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardCreateCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateABinanceCodeUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1GiftcardCreateCodeResponse> CreateABinanceCodeUserData(string token,
        double amount,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/giftcard/createCode"),
            [],
            [new Param("token", token),
                new Param("amount", amount),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardCreateCodeResponse>(),
            CreateABinanceCodeUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch RSA Public Key (USER_DATA)
    /// </summary>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardCryptographyRsaPublicKeyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FetchRsaPublicKeyUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is for fetching the RSA Public Key.
    /// This RSA Public key will be used to encrypt the card code.
    /// Please note that the RSA Public key fetched is valid only for the current day.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardCryptographyRsaPublicKeyResponse> FetchRsaPublicKeyUserData(long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/giftcard/cryptography/rsa-public-key"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardCryptographyRsaPublicKeyResponse>(),
            FetchRsaPublicKeyUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch Token Limit (USER_DATA)
    /// </summary>
    /// <param name="baseToken">The token you want to pay, example BUSD</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardBuyCodeTokenLimitResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FetchTokenLimitUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is to help you verify which tokens are available for you to purchase fixed-value gift cards as mentioned in section 2 and it's limitation.
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardBuyCodeTokenLimitResponse> FetchTokenLimitUserData(string baseToken,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/giftcard/buyCode/token-limit"),
            [],
            [new Param("baseToken", baseToken),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardBuyCodeTokenLimitResponse>(),
            FetchTokenLimitUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Redeem a Binance Code (USER_DATA)
    /// </summary>
    /// <param name="code">Binance Code</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="externalUid">Each external unique ID represents a unique user on the partner platform. The function helps you to identify the redemption behavior of different users, such as redemption frequency and amount. It also helps risk and limit control of a single account, such as daily limit on redemption volume, frequency, and incorrect number of entries. This will also prevent a single user account reach the partner's daily redemption limits. We strongly recommend you to use this feature and transfer us the User ID of your users if you have different users redeeming Binance codes on your platform. To protect user data privacy, you may choose to transfer the user id in any desired format (max. 400 characters).</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardRedeemCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RedeemABinanceCodeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is for redeeming the Binance Code. Once redeemed, the coins will be deposited in your funding wallet.
    /// <para>
    /// Please note that if you enter the wrong code 5 times within 24 hours, you will no longer be able to redeem any Binance Code that day.
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardRedeemCodeResponse> RedeemABinanceCodeUserData(string code,
        long timestamp,
        string signature,
        string? externalUid,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/giftcard/redeemCode"),
            [],
            [new Param("code", code),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("externalUid", externalUid),
                new Param("recvWindow", recvWindow)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardRedeemCodeResponse>(),
            RedeemABinanceCodeUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Verify a Binance Code (USER_DATA)
    /// </summary>
    /// <param name="referenceNo">reference number</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1GiftcardVerifyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VerifyABinanceCodeUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This API is for verifying whether the Binance Code is valid or not by entering Binance Code or reference number.
    /// <para>
    /// Please note that if you enter the wrong binance code 5 times within an hour, you will no longer be able to verify any binance code for that hour.
    /// </para>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1GiftcardVerifyResponse> VerifyABinanceCodeUserData(string referenceNo,
        long timestamp,
        string signature,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/giftcard/verify"),
            [],
            [new Param("referenceNo", referenceNo),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1GiftcardVerifyResponse>(),
            VerifyABinanceCodeUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
