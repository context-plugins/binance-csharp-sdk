using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetEthRedemptionHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetEthRedemptionHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetEthRedemptionHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetEthRedemptionHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetEthRedemptionHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetEthRedemptionHistoryUserDataErrorResponse : IErrorResponse<GetEthRedemptionHistoryUserDataError>
{
    public static GetEthRedemptionHistoryUserDataErrorResponse Instance { get; } = new();

    private GetEthRedemptionHistoryUserDataErrorResponse()
    {
    }

    public Task<GetEthRedemptionHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetEthRedemptionHistoryUserDataError.Create(response, ct);
}
