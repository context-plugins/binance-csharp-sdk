using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class HashrateResaleListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private HashrateResaleListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static HashrateResaleListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static HashrateResaleListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<HashrateResaleListUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class HashrateResaleListUserDataErrorResponse : IErrorResponse<HashrateResaleListUserDataError>
{
    public static HashrateResaleListUserDataErrorResponse Instance { get; } = new();

    private HashrateResaleListUserDataErrorResponse()
    {
    }

    public Task<HashrateResaleListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        HashrateResaleListUserDataError.Create(response, ct);
}
