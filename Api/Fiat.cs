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
/// Fiat Endpoints
/// </summary>
public sealed class Fiat
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Fiat(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Fiat Deposit/Withdraw History (USER_DATA)
    /// </summary>
    /// <param name="transactionType">* <c>0</c> - deposit * <c>1</c> - withdraw</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="beginTime"></param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="rows">Default 100, max 500</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FiatOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FiatDepositWithdrawHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If beginTime and endTime are not sent, the recent 30-day data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 90000
    /// </para>
    /// </remarks>
    public Task<SapiV1FiatOrdersResponse> FiatDepositWithdrawHistoryUserData(int transactionType,
        long timestamp,
        string signature,
        long? beginTime,
        long? endTime,
        int? page,
        int? rows,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/fiat/orders"),
            [],
            [new Param("transactionType", transactionType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("beginTime", beginTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("rows", rows),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FiatOrdersResponse>(),
            FiatDepositWithdrawHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Fiat Payments History (USER_DATA)
    /// </summary>
    /// <param name="transactionType">* <c>0</c> - deposit * <c>1</c> - withdraw</param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="beginTime"></param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="rows">Default 100, max 500</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1FiatPaymentsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FiatPaymentsHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If beginTime and endTime are not sent, the recent 30-day data will be returned.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1FiatPaymentsResponse> FiatPaymentsHistoryUserData(int transactionType,
        long timestamp,
        string signature,
        long? beginTime,
        long? endTime,
        int? page,
        int? rows,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/fiat/payments"),
            [],
            [new Param("transactionType", transactionType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("beginTime", beginTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("rows", rows),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1FiatPaymentsResponse>(),
            FiatPaymentsHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
