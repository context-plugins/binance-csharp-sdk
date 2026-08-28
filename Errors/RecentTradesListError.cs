using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class RecentTradesListError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RecentTradesListError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RecentTradesListError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static RecentTradesListError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RecentTradesListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RecentTradesListErrorResponse : IErrorResponse<RecentTradesListError>
{
    public static RecentTradesListErrorResponse Instance { get; } = new();

    private RecentTradesListErrorResponse()
    {
    }

    public Task<RecentTradesListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RecentTradesListError.Create(response, ct);
}
