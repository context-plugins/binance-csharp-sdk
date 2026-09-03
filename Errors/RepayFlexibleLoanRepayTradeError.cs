using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class RepayFlexibleLoanRepayTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RepayFlexibleLoanRepayTradeError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RepayFlexibleLoanRepayTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RepayFlexibleLoanRepayTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RepayFlexibleLoanRepayTradeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RepayFlexibleLoanRepayTradeErrorResponse : IErrorResponse<RepayFlexibleLoanRepayTradeError>
{
    public static RepayFlexibleLoanRepayTradeErrorResponse Instance { get; } = new();

    private RepayFlexibleLoanRepayTradeErrorResponse()
    {
    }

    public Task<RepayFlexibleLoanRepayTradeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RepayFlexibleLoanRepayTradeError.Create(response, ct);
}
