using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CreateABinanceCodeUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateABinanceCodeUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateABinanceCodeUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateABinanceCodeUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateABinanceCodeUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateABinanceCodeUserDataErrorResponse : IErrorResponse<CreateABinanceCodeUserDataError>
{
    public static CreateABinanceCodeUserDataErrorResponse Instance { get; } = new();

    private CreateABinanceCodeUserDataErrorResponse()
    {
    }

    public Task<CreateABinanceCodeUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateABinanceCodeUserDataError.Create(response, ct);
}
