using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class TestNewOrderUsingSorTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private TestNewOrderUsingSorTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static TestNewOrderUsingSorTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static TestNewOrderUsingSorTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<TestNewOrderUsingSorTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TestNewOrderUsingSorTradeErrorResponse : IErrorResponse<TestNewOrderUsingSorTradeError>
{
    public static TestNewOrderUsingSorTradeErrorResponse Instance { get; } = new();

    private TestNewOrderUsingSorTradeErrorResponse()
    {
    }

    public Task<TestNewOrderUsingSorTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        TestNewOrderUsingSorTradeError.Create(response, ct);
}
