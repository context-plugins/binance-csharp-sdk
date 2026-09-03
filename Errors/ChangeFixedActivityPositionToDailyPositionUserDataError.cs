using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class ChangeFixedActivityPositionToDailyPositionUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ChangeFixedActivityPositionToDailyPositionUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ChangeFixedActivityPositionToDailyPositionUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ChangeFixedActivityPositionToDailyPositionUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ChangeFixedActivityPositionToDailyPositionUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ChangeFixedActivityPositionToDailyPositionUserDataErrorResponse : IErrorResponse<ChangeFixedActivityPositionToDailyPositionUserDataError>
{
    public static ChangeFixedActivityPositionToDailyPositionUserDataErrorResponse Instance { get; } = new();

    private ChangeFixedActivityPositionToDailyPositionUserDataErrorResponse()
    {
    }

    public Task<ChangeFixedActivityPositionToDailyPositionUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => ChangeFixedActivityPositionToDailyPositionUserDataError.Create(response, ct);
}
