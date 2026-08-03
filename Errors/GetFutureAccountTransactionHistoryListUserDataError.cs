using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetFutureAccountTransactionHistoryListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFutureAccountTransactionHistoryListUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFutureAccountTransactionHistoryListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFutureAccountTransactionHistoryListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFutureAccountTransactionHistoryListUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFutureAccountTransactionHistoryListUserDataErrorResponse : IErrorResponse<GetFutureAccountTransactionHistoryListUserDataError>
{
    public static GetFutureAccountTransactionHistoryListUserDataErrorResponse Instance { get; } = new();

    private GetFutureAccountTransactionHistoryListUserDataErrorResponse()
    {
    }

    public Task<GetFutureAccountTransactionHistoryListUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetFutureAccountTransactionHistoryListUserDataError.Create(response, ct);
}
