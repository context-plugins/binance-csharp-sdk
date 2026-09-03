using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class NewOrderUsingSorTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private NewOrderUsingSorTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static NewOrderUsingSorTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static NewOrderUsingSorTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<NewOrderUsingSorTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class NewOrderUsingSorTradeErrorResponse : IErrorResponse<NewOrderUsingSorTradeError>
{
    public static NewOrderUsingSorTradeErrorResponse Instance { get; } = new();

    private NewOrderUsingSorTradeErrorResponse()
    {
    }

    public Task<NewOrderUsingSorTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        NewOrderUsingSorTradeError.Create(response, ct);
}
