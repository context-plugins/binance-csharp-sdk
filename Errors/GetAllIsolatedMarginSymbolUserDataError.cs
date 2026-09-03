using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetAllIsolatedMarginSymbolUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAllIsolatedMarginSymbolUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAllIsolatedMarginSymbolUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAllIsolatedMarginSymbolUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAllIsolatedMarginSymbolUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAllIsolatedMarginSymbolUserDataErrorResponse : IErrorResponse<GetAllIsolatedMarginSymbolUserDataError>
{
    public static GetAllIsolatedMarginSymbolUserDataErrorResponse Instance { get; } = new();

    private GetAllIsolatedMarginSymbolUserDataErrorResponse()
    {
    }

    public Task<GetAllIsolatedMarginSymbolUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAllIsolatedMarginSymbolUserDataError.Create(response, ct);
}
