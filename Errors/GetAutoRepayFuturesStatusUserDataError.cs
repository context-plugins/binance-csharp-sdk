using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetAutoRepayFuturesStatusUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAutoRepayFuturesStatusUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAutoRepayFuturesStatusUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAutoRepayFuturesStatusUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAutoRepayFuturesStatusUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAutoRepayFuturesStatusUserDataErrorResponse : IErrorResponse<GetAutoRepayFuturesStatusUserDataError>
{
    public static GetAutoRepayFuturesStatusUserDataErrorResponse Instance { get; } = new();

    private GetAutoRepayFuturesStatusUserDataErrorResponse()
    {
    }

    public Task<GetAutoRepayFuturesStatusUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAutoRepayFuturesStatusUserDataError.Create(response, ct);
}
