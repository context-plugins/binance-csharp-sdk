using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetSmallLiabilityExchangeHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetSmallLiabilityExchangeHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetSmallLiabilityExchangeHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetSmallLiabilityExchangeHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetSmallLiabilityExchangeHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSmallLiabilityExchangeHistoryUserDataErrorResponse : IErrorResponse<GetSmallLiabilityExchangeHistoryUserDataError>
{
    public static GetSmallLiabilityExchangeHistoryUserDataErrorResponse Instance { get; } = new();

    private GetSmallLiabilityExchangeHistoryUserDataErrorResponse()
    {
    }

    public Task<GetSmallLiabilityExchangeHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetSmallLiabilityExchangeHistoryUserDataError.Create(response, ct);
}
