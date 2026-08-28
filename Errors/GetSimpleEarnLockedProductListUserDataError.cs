using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetSimpleEarnLockedProductListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetSimpleEarnLockedProductListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetSimpleEarnLockedProductListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetSimpleEarnLockedProductListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetSimpleEarnLockedProductListUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSimpleEarnLockedProductListUserDataErrorResponse : IErrorResponse<GetSimpleEarnLockedProductListUserDataError>
{
    public static GetSimpleEarnLockedProductListUserDataErrorResponse Instance { get; } = new();

    private GetSimpleEarnLockedProductListUserDataErrorResponse()
    {
    }

    public Task<GetSimpleEarnLockedProductListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetSimpleEarnLockedProductListUserDataError.Create(response, ct);
}
