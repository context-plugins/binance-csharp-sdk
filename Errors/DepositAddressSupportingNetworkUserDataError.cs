using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class DepositAddressSupportingNetworkUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DepositAddressSupportingNetworkUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DepositAddressSupportingNetworkUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DepositAddressSupportingNetworkUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DepositAddressSupportingNetworkUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DepositAddressSupportingNetworkUserDataErrorResponse : IErrorResponse<DepositAddressSupportingNetworkUserDataError>
{
    public static DepositAddressSupportingNetworkUserDataErrorResponse Instance { get; } = new();

    private DepositAddressSupportingNetworkUserDataErrorResponse()
    {
    }

    public Task<DepositAddressSupportingNetworkUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => DepositAddressSupportingNetworkUserDataError.Create(response, ct);
}
