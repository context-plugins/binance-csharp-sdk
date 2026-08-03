using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class CryptoLoanAdjustLtvTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CryptoLoanAdjustLtvTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CryptoLoanAdjustLtvTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CryptoLoanAdjustLtvTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CryptoLoanAdjustLtvTradeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CryptoLoanAdjustLtvTradeErrorResponse : IErrorResponse<CryptoLoanAdjustLtvTradeError>
{
    public static CryptoLoanAdjustLtvTradeErrorResponse Instance { get; } = new();

    private CryptoLoanAdjustLtvTradeErrorResponse()
    {
    }

    public Task<CryptoLoanAdjustLtvTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CryptoLoanAdjustLtvTradeError.Create(response, ct);
}
