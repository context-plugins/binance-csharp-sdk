using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class WithdrawHistorySupportingNetworkUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private WithdrawHistorySupportingNetworkUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static WithdrawHistorySupportingNetworkUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static WithdrawHistorySupportingNetworkUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<WithdrawHistorySupportingNetworkUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class WithdrawHistorySupportingNetworkUserDataErrorResponse : IErrorResponse<WithdrawHistorySupportingNetworkUserDataError>
{
    public static WithdrawHistorySupportingNetworkUserDataErrorResponse Instance { get; } = new();

    private WithdrawHistorySupportingNetworkUserDataErrorResponse()
    {
    }

    public Task<WithdrawHistorySupportingNetworkUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => WithdrawHistorySupportingNetworkUserDataError.Create(response, ct);
}
