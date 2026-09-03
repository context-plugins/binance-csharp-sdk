using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class FuturesPositionRiskOfSubAccountForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FuturesPositionRiskOfSubAccountForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FuturesPositionRiskOfSubAccountForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FuturesPositionRiskOfSubAccountForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FuturesPositionRiskOfSubAccountForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FuturesPositionRiskOfSubAccountForMasterAccountErrorResponse : IErrorResponse<FuturesPositionRiskOfSubAccountForMasterAccountError>
{
    public static FuturesPositionRiskOfSubAccountForMasterAccountErrorResponse Instance { get; } = new();

    private FuturesPositionRiskOfSubAccountForMasterAccountErrorResponse()
    {
    }

    public Task<FuturesPositionRiskOfSubAccountForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => FuturesPositionRiskOfSubAccountForMasterAccountError.Create(response, ct);
}
