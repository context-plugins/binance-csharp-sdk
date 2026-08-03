using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class HashrateResaleDetailsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private HashrateResaleDetailsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static HashrateResaleDetailsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static HashrateResaleDetailsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<HashrateResaleDetailsUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class HashrateResaleDetailsUserDataErrorResponse : IErrorResponse<HashrateResaleDetailsUserDataError>
{
    public static HashrateResaleDetailsUserDataErrorResponse Instance { get; } = new();

    private HashrateResaleDetailsUserDataErrorResponse()
    {
    }

    public Task<HashrateResaleDetailsUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        HashrateResaleDetailsUserDataError.Create(response, ct);
}
