using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetSmallLiabilityExchangeCoinListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetSmallLiabilityExchangeCoinListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetSmallLiabilityExchangeCoinListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetSmallLiabilityExchangeCoinListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetSmallLiabilityExchangeCoinListUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSmallLiabilityExchangeCoinListUserDataErrorResponse : IErrorResponse<GetSmallLiabilityExchangeCoinListUserDataError>
{
    public static GetSmallLiabilityExchangeCoinListUserDataErrorResponse Instance { get; } = new();

    private GetSmallLiabilityExchangeCoinListUserDataErrorResponse()
    {
    }

    public Task<GetSmallLiabilityExchangeCoinListUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetSmallLiabilityExchangeCoinListUserDataError.Create(response, ct);
}
