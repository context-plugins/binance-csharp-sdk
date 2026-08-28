using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SubscribeFlexibleProductTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubscribeFlexibleProductTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubscribeFlexibleProductTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubscribeFlexibleProductTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubscribeFlexibleProductTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscribeFlexibleProductTradeErrorResponse : IErrorResponse<SubscribeFlexibleProductTradeError>
{
    public static SubscribeFlexibleProductTradeErrorResponse Instance { get; } = new();

    private SubscribeFlexibleProductTradeErrorResponse()
    {
    }

    public Task<SubscribeFlexibleProductTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubscribeFlexibleProductTradeError.Create(response, ct);
}
