using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class UiKlinesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private UiKlinesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static UiKlinesError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static UiKlinesError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<UiKlinesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UiKlinesErrorResponse : IErrorResponse<UiKlinesError>
{
    public static UiKlinesErrorResponse Instance { get; } = new();

    private UiKlinesErrorResponse()
    {
    }

    public Task<UiKlinesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UiKlinesError.Create(response, ct);
}
