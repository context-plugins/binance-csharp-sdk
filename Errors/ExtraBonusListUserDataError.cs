using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class ExtraBonusListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ExtraBonusListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ExtraBonusListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ExtraBonusListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ExtraBonusListUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ExtraBonusListUserDataErrorResponse : IErrorResponse<ExtraBonusListUserDataError>
{
    public static ExtraBonusListUserDataErrorResponse Instance { get; } = new();

    private ExtraBonusListUserDataErrorResponse()
    {
    }

    public Task<ExtraBonusListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ExtraBonusListUserDataError.Create(response, ct);
}
