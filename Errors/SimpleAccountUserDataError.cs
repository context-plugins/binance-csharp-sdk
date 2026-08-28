using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SimpleAccountUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SimpleAccountUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SimpleAccountUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SimpleAccountUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SimpleAccountUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SimpleAccountUserDataErrorResponse : IErrorResponse<SimpleAccountUserDataError>
{
    public static SimpleAccountUserDataErrorResponse Instance { get; } = new();

    private SimpleAccountUserDataErrorResponse()
    {
    }

    public Task<SimpleAccountUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SimpleAccountUserDataError.Create(response, ct);
}
