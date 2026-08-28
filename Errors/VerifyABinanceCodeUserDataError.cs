using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class VerifyABinanceCodeUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private VerifyABinanceCodeUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static VerifyABinanceCodeUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static VerifyABinanceCodeUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<VerifyABinanceCodeUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class VerifyABinanceCodeUserDataErrorResponse : IErrorResponse<VerifyABinanceCodeUserDataError>
{
    public static VerifyABinanceCodeUserDataErrorResponse Instance { get; } = new();

    private VerifyABinanceCodeUserDataErrorResponse()
    {
    }

    public Task<VerifyABinanceCodeUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        VerifyABinanceCodeUserDataError.Create(response, ct);
}
