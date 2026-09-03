using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetEthStakingHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetEthStakingHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetEthStakingHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetEthStakingHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetEthStakingHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetEthStakingHistoryUserDataErrorResponse : IErrorResponse<GetEthStakingHistoryUserDataError>
{
    public static GetEthStakingHistoryUserDataErrorResponse Instance { get; } = new();

    private GetEthStakingHistoryUserDataErrorResponse()
    {
    }

    public Task<GetEthStakingHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetEthStakingHistoryUserDataError.Create(response, ct);
}
