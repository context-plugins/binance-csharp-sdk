using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetLockedRewardsHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLockedRewardsHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLockedRewardsHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLockedRewardsHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLockedRewardsHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLockedRewardsHistoryUserDataErrorResponse : IErrorResponse<GetLockedRewardsHistoryUserDataError>
{
    public static GetLockedRewardsHistoryUserDataErrorResponse Instance { get; } = new();

    private GetLockedRewardsHistoryUserDataErrorResponse()
    {
    }

    public Task<GetLockedRewardsHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLockedRewardsHistoryUserDataError.Create(response, ct);
}
