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
using BinancePublicSpotApi.Models.Enums;

namespace BinancePublicSpotApi.Api;

/// <summary>
/// Consumer-To-Consumer Endpoints
/// </summary>
public sealed class C2C
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal C2C(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get C2C Trade History (USER_DATA)
    /// </summary>
    /// <param name="tradeType"></param>
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTimestamp">UTC timestamp in ms</param>
    /// <param name="endTimestamp">UTC timestamp in ms</param>
    /// <param name="page">Default 1</param>
    /// <param name="rows">default 100, max 100</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1C2COrderMatchListUserOrderHistoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetC2CTradeHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTimestamp and endTimestamp are not sent, the recent 30-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTimestamp and endTimestamp is 30 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1C2COrderMatchListUserOrderHistoryResponse> GetC2CTradeHistoryUserData(TradeType tradeType,
        long timestamp,
        string signature,
        long? startTimestamp,
        long? endTimestamp,
        int? page,
        int? rows,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/c2c/orderMatch/listUserOrderHistory"),
            [],
            [new Param("tradeType", tradeType),
                new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTimestamp", startTimestamp),
                new Param("endTimestamp", endTimestamp),
                new Param("page", page),
                new Param("rows", rows),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1C2COrderMatchListUserOrderHistoryResponse>(),
            GetC2CTradeHistoryUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
