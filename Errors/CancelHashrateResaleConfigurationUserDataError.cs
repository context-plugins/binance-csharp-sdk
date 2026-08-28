using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class CancelHashrateResaleConfigurationUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CancelHashrateResaleConfigurationUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CancelHashrateResaleConfigurationUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CancelHashrateResaleConfigurationUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CancelHashrateResaleConfigurationUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CancelHashrateResaleConfigurationUserDataErrorResponse : IErrorResponse<CancelHashrateResaleConfigurationUserDataError>
{
    public static CancelHashrateResaleConfigurationUserDataErrorResponse Instance { get; } = new();

    private CancelHashrateResaleConfigurationUserDataErrorResponse()
    {
    }

    public Task<CancelHashrateResaleConfigurationUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => CancelHashrateResaleConfigurationUserDataError.Create(response, ct);
}
