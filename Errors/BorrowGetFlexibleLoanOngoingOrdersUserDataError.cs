using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class BorrowGetFlexibleLoanOngoingOrdersUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private BorrowGetFlexibleLoanOngoingOrdersUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static BorrowGetFlexibleLoanOngoingOrdersUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static BorrowGetFlexibleLoanOngoingOrdersUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<BorrowGetFlexibleLoanOngoingOrdersUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BorrowGetFlexibleLoanOngoingOrdersUserDataErrorResponse : IErrorResponse<BorrowGetFlexibleLoanOngoingOrdersUserDataError>
{
    public static BorrowGetFlexibleLoanOngoingOrdersUserDataErrorResponse Instance { get; } = new();

    private BorrowGetFlexibleLoanOngoingOrdersUserDataErrorResponse()
    {
    }

    public Task<BorrowGetFlexibleLoanOngoingOrdersUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => BorrowGetFlexibleLoanOngoingOrdersUserDataError.Create(response, ct);
}
