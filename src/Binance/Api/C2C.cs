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
using Binance.Requests.C2C;

namespace Binance.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1C2COrderMatchListUserOrderHistoryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetC2CTradeHistoryUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>If startTimestamp and endTimestamp are not sent, the recent 30-day data will be returned.</description></item>
    ///   <item><description>The max interval between startTimestamp and endTimestamp is 30 days.</description></item>
    /// </list>
    /// <para>
    /// Weight(IP): 1
    /// </para>
    /// </remarks>
    public Task<SapiV1C2COrderMatchListUserOrderHistoryResponse> GetC2CTradeHistoryUserData(GetC2CTradeHistoryUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/c2c/orderMatch/listUserOrderHistory"),
            [],
            [
                new Param("tradeType", request.TradeType),
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTimestamp", request.StartTimestamp),
                new Param("endTimestamp", request.EndTimestamp),
                new Param("page", request.Page),
                new Param("rows", request.Rows),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1C2COrderMatchListUserOrderHistoryResponse>(),
            GetC2CTradeHistoryUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
