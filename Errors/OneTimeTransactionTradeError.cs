using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class OneTimeTransactionTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private OneTimeTransactionTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static OneTimeTransactionTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static OneTimeTransactionTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<OneTimeTransactionTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OneTimeTransactionTradeErrorResponse : IErrorResponse<OneTimeTransactionTradeError>
{
    public static OneTimeTransactionTradeErrorResponse Instance { get; } = new();

    private OneTimeTransactionTradeErrorResponse()
    {
    }

    public Task<OneTimeTransactionTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OneTimeTransactionTradeError.Create(response, ct);
}
