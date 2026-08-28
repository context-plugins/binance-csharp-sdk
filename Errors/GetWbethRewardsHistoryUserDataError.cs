using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetWbethRewardsHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetWbethRewardsHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetWbethRewardsHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetWbethRewardsHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetWbethRewardsHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetWbethRewardsHistoryUserDataErrorResponse : IErrorResponse<GetWbethRewardsHistoryUserDataError>
{
    public static GetWbethRewardsHistoryUserDataErrorResponse Instance { get; } = new();

    private GetWbethRewardsHistoryUserDataErrorResponse()
    {
    }

    public Task<GetWbethRewardsHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetWbethRewardsHistoryUserDataError.Create(response, ct);
}
