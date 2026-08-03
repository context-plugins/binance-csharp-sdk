using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class TestNewOrderTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private TestNewOrderTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static TestNewOrderTradeError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static TestNewOrderTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<TestNewOrderTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TestNewOrderTradeErrorResponse : IErrorResponse<TestNewOrderTradeError>
{
    public static TestNewOrderTradeErrorResponse Instance { get; } = new();

    private TestNewOrderTradeErrorResponse()
    {
    }

    public Task<TestNewOrderTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        TestNewOrderTradeError.Create(response, ct);
}
