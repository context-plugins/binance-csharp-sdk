using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetVipLoanOngoingOrdersUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetVipLoanOngoingOrdersUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetVipLoanOngoingOrdersUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetVipLoanOngoingOrdersUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetVipLoanOngoingOrdersUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVipLoanOngoingOrdersUserDataErrorResponse : IErrorResponse<GetVipLoanOngoingOrdersUserDataError>
{
    public static GetVipLoanOngoingOrdersUserDataErrorResponse Instance { get; } = new();

    private GetVipLoanOngoingOrdersUserDataErrorResponse()
    {
    }

    public Task<GetVipLoanOngoingOrdersUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVipLoanOngoingOrdersUserDataError.Create(response, ct);
}
