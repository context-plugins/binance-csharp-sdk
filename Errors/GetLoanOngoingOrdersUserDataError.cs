using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetLoanOngoingOrdersUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLoanOngoingOrdersUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLoanOngoingOrdersUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLoanOngoingOrdersUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLoanOngoingOrdersUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLoanOngoingOrdersUserDataErrorResponse : IErrorResponse<GetLoanOngoingOrdersUserDataError>
{
    public static GetLoanOngoingOrdersUserDataErrorResponse Instance { get; } = new();

    private GetLoanOngoingOrdersUserDataErrorResponse()
    {
    }

    public Task<GetLoanOngoingOrdersUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLoanOngoingOrdersUserDataError.Create(response, ct);
}
