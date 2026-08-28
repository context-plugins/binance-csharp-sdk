using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetInterestHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetInterestHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetInterestHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetInterestHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetInterestHistoryUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetInterestHistoryUserDataErrorResponse : IErrorResponse<GetInterestHistoryUserDataError>
{
    public static GetInterestHistoryUserDataErrorResponse Instance { get; } = new();

    private GetInterestHistoryUserDataErrorResponse()
    {
    }

    public Task<GetInterestHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetInterestHistoryUserDataError.Create(response, ct);
}
