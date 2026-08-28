using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetDualInvestmentPositionsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetDualInvestmentPositionsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetDualInvestmentPositionsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetDualInvestmentPositionsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetDualInvestmentPositionsUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDualInvestmentPositionsUserDataErrorResponse : IErrorResponse<GetDualInvestmentPositionsUserDataError>
{
    public static GetDualInvestmentPositionsUserDataErrorResponse Instance { get; } = new();

    private GetDualInvestmentPositionsUserDataErrorResponse()
    {
    }

    public Task<GetDualInvestmentPositionsUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDualInvestmentPositionsUserDataError.Create(response, ct);
}
