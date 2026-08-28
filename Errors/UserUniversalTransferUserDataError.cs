using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class UserUniversalTransferUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private UserUniversalTransferUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static UserUniversalTransferUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static UserUniversalTransferUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<UserUniversalTransferUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UserUniversalTransferUserDataErrorResponse : IErrorResponse<UserUniversalTransferUserDataError>
{
    public static UserUniversalTransferUserDataErrorResponse Instance { get; } = new();

    private UserUniversalTransferUserDataErrorResponse()
    {
    }

    public Task<UserUniversalTransferUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UserUniversalTransferUserDataError.Create(response, ct);
}
