using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class HashrateResaleRequestUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private HashrateResaleRequestUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static HashrateResaleRequestUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static HashrateResaleRequestUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<HashrateResaleRequestUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class HashrateResaleRequestUserDataErrorResponse : IErrorResponse<HashrateResaleRequestUserDataError>
{
    public static HashrateResaleRequestUserDataErrorResponse Instance { get; } = new();

    private HashrateResaleRequestUserDataErrorResponse()
    {
    }

    public Task<HashrateResaleRequestUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        HashrateResaleRequestUserDataError.Create(response, ct);
}
