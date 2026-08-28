using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class PortfolioMarginAccountUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PortfolioMarginAccountUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PortfolioMarginAccountUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static PortfolioMarginAccountUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<PortfolioMarginAccountUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PortfolioMarginAccountUserDataErrorResponse : IErrorResponse<PortfolioMarginAccountUserDataError>
{
    public static PortfolioMarginAccountUserDataErrorResponse Instance { get; } = new();

    private PortfolioMarginAccountUserDataErrorResponse()
    {
    }

    public Task<PortfolioMarginAccountUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PortfolioMarginAccountUserDataError.Create(response, ct);
}
