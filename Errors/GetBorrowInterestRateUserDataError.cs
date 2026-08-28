using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetBorrowInterestRateUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetBorrowInterestRateUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetBorrowInterestRateUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetBorrowInterestRateUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetBorrowInterestRateUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBorrowInterestRateUserDataErrorResponse : IErrorResponse<GetBorrowInterestRateUserDataError>
{
    public static GetBorrowInterestRateUserDataErrorResponse Instance { get; } = new();

    private GetBorrowInterestRateUserDataErrorResponse()
    {
    }

    public Task<GetBorrowInterestRateUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetBorrowInterestRateUserDataError.Create(response, ct);
}
