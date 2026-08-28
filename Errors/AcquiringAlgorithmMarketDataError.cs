using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class AcquiringAlgorithmMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AcquiringAlgorithmMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AcquiringAlgorithmMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AcquiringAlgorithmMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AcquiringAlgorithmMarketDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AcquiringAlgorithmMarketDataErrorResponse : IErrorResponse<AcquiringAlgorithmMarketDataError>
{
    public static AcquiringAlgorithmMarketDataErrorResponse Instance { get; } = new();

    private AcquiringAlgorithmMarketDataErrorResponse()
    {
    }

    public Task<AcquiringAlgorithmMarketDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AcquiringAlgorithmMarketDataError.Create(response, ct);
}
