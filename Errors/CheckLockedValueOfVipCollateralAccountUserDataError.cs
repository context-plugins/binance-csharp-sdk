using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class CheckLockedValueOfVipCollateralAccountUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CheckLockedValueOfVipCollateralAccountUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CheckLockedValueOfVipCollateralAccountUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CheckLockedValueOfVipCollateralAccountUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CheckLockedValueOfVipCollateralAccountUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckLockedValueOfVipCollateralAccountUserDataErrorResponse : IErrorResponse<CheckLockedValueOfVipCollateralAccountUserDataError>
{
    public static CheckLockedValueOfVipCollateralAccountUserDataErrorResponse Instance { get; } = new();

    private CheckLockedValueOfVipCollateralAccountUserDataErrorResponse()
    {
    }

    public Task<CheckLockedValueOfVipCollateralAccountUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => CheckLockedValueOfVipCollateralAccountUserDataError.Create(response, ct);
}
