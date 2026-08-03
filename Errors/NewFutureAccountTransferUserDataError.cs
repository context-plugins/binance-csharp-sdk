using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class NewFutureAccountTransferUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private NewFutureAccountTransferUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static NewFutureAccountTransferUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static NewFutureAccountTransferUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<NewFutureAccountTransferUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class NewFutureAccountTransferUserDataErrorResponse : IErrorResponse<NewFutureAccountTransferUserDataError>
{
    public static NewFutureAccountTransferUserDataErrorResponse Instance { get; } = new();

    private NewFutureAccountTransferUserDataErrorResponse()
    {
    }

    public Task<NewFutureAccountTransferUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        NewFutureAccountTransferUserDataError.Create(response, ct);
}
