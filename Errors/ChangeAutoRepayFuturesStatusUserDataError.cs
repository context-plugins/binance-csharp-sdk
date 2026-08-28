using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class ChangeAutoRepayFuturesStatusUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ChangeAutoRepayFuturesStatusUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ChangeAutoRepayFuturesStatusUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ChangeAutoRepayFuturesStatusUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ChangeAutoRepayFuturesStatusUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ChangeAutoRepayFuturesStatusUserDataErrorResponse : IErrorResponse<ChangeAutoRepayFuturesStatusUserDataError>
{
    public static ChangeAutoRepayFuturesStatusUserDataErrorResponse Instance { get; } = new();

    private ChangeAutoRepayFuturesStatusUserDataErrorResponse()
    {
    }

    public Task<ChangeAutoRepayFuturesStatusUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ChangeAutoRepayFuturesStatusUserDataError.Create(response, ct);
}
