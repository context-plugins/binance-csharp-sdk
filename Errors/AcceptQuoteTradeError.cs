using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class AcceptQuoteTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AcceptQuoteTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AcceptQuoteTradeError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static AcceptQuoteTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AcceptQuoteTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AcceptQuoteTradeErrorResponse : IErrorResponse<AcceptQuoteTradeError>
{
    public static AcceptQuoteTradeErrorResponse Instance { get; } = new();

    private AcceptQuoteTradeErrorResponse()
    {
    }

    public Task<AcceptQuoteTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AcceptQuoteTradeError.Create(response, ct);
}
