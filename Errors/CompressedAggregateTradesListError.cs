using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CompressedAggregateTradesListError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CompressedAggregateTradesListError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CompressedAggregateTradesListError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CompressedAggregateTradesListError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CompressedAggregateTradesListError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CompressedAggregateTradesListErrorResponse : IErrorResponse<CompressedAggregateTradesListError>
{
    public static CompressedAggregateTradesListErrorResponse Instance { get; } = new();

    private CompressedAggregateTradesListErrorResponse()
    {
    }

    public Task<CompressedAggregateTradesListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CompressedAggregateTradesListError.Create(response, ct);
}
