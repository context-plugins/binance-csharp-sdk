using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetFlexibleRewardsHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFlexibleRewardsHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFlexibleRewardsHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFlexibleRewardsHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFlexibleRewardsHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFlexibleRewardsHistoryUserDataErrorResponse : IErrorResponse<GetFlexibleRewardsHistoryUserDataError>
{
    public static GetFlexibleRewardsHistoryUserDataErrorResponse Instance { get; } = new();

    private GetFlexibleRewardsHistoryUserDataErrorResponse()
    {
    }

    public Task<GetFlexibleRewardsHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFlexibleRewardsHistoryUserDataError.Create(response, ct);
}
