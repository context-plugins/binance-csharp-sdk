using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class BlvtInfoMarketDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private BlvtInfoMarketDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static BlvtInfoMarketDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static BlvtInfoMarketDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<BlvtInfoMarketDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BlvtInfoMarketDataErrorResponse : IErrorResponse<BlvtInfoMarketDataError>
{
    public static BlvtInfoMarketDataErrorResponse Instance { get; } = new();

    private BlvtInfoMarketDataErrorResponse()
    {
    }

    public Task<BlvtInfoMarketDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BlvtInfoMarketDataError.Create(response, ct);
}
