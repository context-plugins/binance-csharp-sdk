using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class EarningsListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EarningsListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EarningsListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EarningsListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EarningsListUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EarningsListUserDataErrorResponse : IErrorResponse<EarningsListUserDataError>
{
    public static EarningsListUserDataErrorResponse Instance { get; } = new();

    private EarningsListUserDataErrorResponse()
    {
    }

    public Task<EarningsListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EarningsListUserDataError.Create(response, ct);
}
