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
    /// <param name="timestamp">UTC timestamp in ms</param>
    /// <param name="signature">Signature</param>
    /// <param name="startTime">UTC timestamp in ms</param>
    /// <param name="endTime">UTC timestamp in ms</param>
    /// <param name="page">default 1</param>
    /// <param name="recvWindow">The value cannot be greater than 60000</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SapiV1RebateTaxQueryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSpotRebateHistoryRecordsUserDataError"/> when the server returns an error response.</exception>
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
    public Task<SapiV1RebateTaxQueryResponse> GetSpotRebateHistoryRecordsUserData(long timestamp,
        string signature,
        long? startTime,
        long? endTime,
        int? page,
        long? recvWindow,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sapi/v1/rebate/taxQuery"),
            [],
            [new Param("timestamp", timestamp),
                new Param("signature", signature),
                new Param("startTime", startTime),
                new Param("endTime", endTime),
                new Param("page", page),
                new Param("recvWindow", recvWindow)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SapiV1RebateTaxQueryResponse>(),
            GetSpotRebateHistoryRecordsUserDataErrorResponse.Instance,
            [_auth.ApiKeyAuth],
            requestOptions,
            ct);
}
