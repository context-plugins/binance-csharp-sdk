using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetFlexibleSubscriptionRecordUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFlexibleSubscriptionRecordUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFlexibleSubscriptionRecordUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFlexibleSubscriptionRecordUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFlexibleSubscriptionRecordUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFlexibleSubscriptionRecordUserDataErrorResponse : IErrorResponse<GetFlexibleSubscriptionRecordUserDataError>
{
    public static GetFlexibleSubscriptionRecordUserDataErrorResponse Instance { get; } = new();

    private GetFlexibleSubscriptionRecordUserDataErrorResponse()
    {
    }

    public Task<GetFlexibleSubscriptionRecordUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFlexibleSubscriptionRecordUserDataError.Create(response, ct);
}
