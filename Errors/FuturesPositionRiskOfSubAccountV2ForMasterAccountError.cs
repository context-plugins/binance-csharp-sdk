using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class FuturesPositionRiskOfSubAccountV2ForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FuturesPositionRiskOfSubAccountV2ForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FuturesPositionRiskOfSubAccountV2ForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FuturesPositionRiskOfSubAccountV2ForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FuturesPositionRiskOfSubAccountV2ForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FuturesPositionRiskOfSubAccountV2ForMasterAccountErrorResponse : IErrorResponse<FuturesPositionRiskOfSubAccountV2ForMasterAccountError>
{
    public static FuturesPositionRiskOfSubAccountV2ForMasterAccountErrorResponse Instance { get; } = new();

    private FuturesPositionRiskOfSubAccountV2ForMasterAccountErrorResponse()
    {
    }

    public Task<FuturesPositionRiskOfSubAccountV2ForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => FuturesPositionRiskOfSubAccountV2ForMasterAccountError.Create(response, ct);
}
