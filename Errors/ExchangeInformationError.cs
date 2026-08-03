using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class ExchangeInformationError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ExchangeInformationError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ExchangeInformationError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ExchangeInformationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ExchangeInformationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ExchangeInformationErrorResponse : IErrorResponse<ExchangeInformationError>
{
    public static ExchangeInformationErrorResponse Instance { get; } = new();

    private ExchangeInformationErrorResponse()
    {
    }

    public Task<ExchangeInformationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ExchangeInformationError.Create(response, ct);
}
