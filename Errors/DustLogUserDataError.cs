using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class DustLogUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DustLogUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DustLogUserDataError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static DustLogUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DustLogUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DustLogUserDataErrorResponse : IErrorResponse<DustLogUserDataError>
{
    public static DustLogUserDataErrorResponse Instance { get; } = new();

    private DustLogUserDataErrorResponse()
    {
    }

    public Task<DustLogUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DustLogUserDataError.Create(response, ct);
}
