using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class EnableFuturesForSubAccountForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EnableFuturesForSubAccountForMasterAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EnableFuturesForSubAccountForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EnableFuturesForSubAccountForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EnableFuturesForSubAccountForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EnableFuturesForSubAccountForMasterAccountErrorResponse : IErrorResponse<EnableFuturesForSubAccountForMasterAccountError>
{
    public static EnableFuturesForSubAccountForMasterAccountErrorResponse Instance { get; } = new();

    private EnableFuturesForSubAccountForMasterAccountErrorResponse()
    {
    }

    public Task<EnableFuturesForSubAccountForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => EnableFuturesForSubAccountForMasterAccountError.Create(response, ct);
}
