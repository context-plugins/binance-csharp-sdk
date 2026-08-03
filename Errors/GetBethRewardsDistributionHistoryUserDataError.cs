using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetBethRewardsDistributionHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetBethRewardsDistributionHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetBethRewardsDistributionHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetBethRewardsDistributionHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetBethRewardsDistributionHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBethRewardsDistributionHistoryUserDataErrorResponse : IErrorResponse<GetBethRewardsDistributionHistoryUserDataError>
{
    public static GetBethRewardsDistributionHistoryUserDataErrorResponse Instance { get; } = new();

    private GetBethRewardsDistributionHistoryUserDataErrorResponse()
    {
    }

    public Task<GetBethRewardsDistributionHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetBethRewardsDistributionHistoryUserDataError.Create(response, ct);
}
