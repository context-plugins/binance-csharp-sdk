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
using Binance.Requests.Rebate;

namespace Binance.Api;

/// <summary>
/// Rebate Endpoints
/// </summary>
public sealed class Rebate
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Rebate(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Spot Rebate History Records (USER_DATA)
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1RebateTaxQueryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSpotRebateHistoryRecordsUserDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><description>The max interval between startTime and endTime is 90 days.</description></item>
    ///   <item><description>If startTime and endTime are not sent, the recent 7 days' data will be returned.</description></item>
    ///   <item><description>The earliest startTime is supported on June 10, 2020</description></item>
    /// </list>
    /// <para>
    /// Weight(UID): 3000
    /// </para>
    /// </remarks>
    public Task<SapiV1RebateTaxQueryResponse> GetSpotRebateHistoryRecordsUserData(GetSpotRebateHistoryRecordsUserDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sapi/v1/rebate/taxQuery"),
            [],
            [
                new Param("timestamp", request.Timestamp),
                new Param("signature", request.Signature),
                new Param("startTime", request.StartTime),
                new Param("endTime", request.EndTime),
                new Param("page", request.Page),
                new Param("recvWindow", request.RecvWindow),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1RebateTaxQueryResponse>(),
            GetSpotRebateHistoryRecordsUserDataError.Response,
            [_auth.ApiKeyAuth],
            requestOptions,
            cancellationToken);
}
