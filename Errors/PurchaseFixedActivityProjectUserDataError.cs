using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class PurchaseFixedActivityProjectUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PurchaseFixedActivityProjectUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PurchaseFixedActivityProjectUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PurchaseFixedActivityProjectUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<PurchaseFixedActivityProjectUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PurchaseFixedActivityProjectUserDataErrorResponse : IErrorResponse<PurchaseFixedActivityProjectUserDataError>
{
    public static PurchaseFixedActivityProjectUserDataErrorResponse Instance { get; } = new();

    private PurchaseFixedActivityProjectUserDataErrorResponse()
    {
    }

    public Task<PurchaseFixedActivityProjectUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PurchaseFixedActivityProjectUserDataError.Create(response, ct);
}
