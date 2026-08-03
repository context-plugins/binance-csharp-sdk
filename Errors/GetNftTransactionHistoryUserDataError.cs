using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetNftTransactionHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetNftTransactionHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetNftTransactionHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetNftTransactionHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetNftTransactionHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetNftTransactionHistoryUserDataErrorResponse : IErrorResponse<GetNftTransactionHistoryUserDataError>
{
    public static GetNftTransactionHistoryUserDataErrorResponse Instance { get; } = new();

    private GetNftTransactionHistoryUserDataErrorResponse()
    {
    }

    public Task<GetNftTransactionHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetNftTransactionHistoryUserDataError.Create(response, ct);
}
