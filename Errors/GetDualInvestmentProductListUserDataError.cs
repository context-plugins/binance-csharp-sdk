using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetDualInvestmentProductListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetDualInvestmentProductListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetDualInvestmentProductListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetDualInvestmentProductListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetDualInvestmentProductListUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDualInvestmentProductListUserDataErrorResponse : IErrorResponse<GetDualInvestmentProductListUserDataError>
{
    public static GetDualInvestmentProductListUserDataErrorResponse Instance { get; } = new();

    private GetDualInvestmentProductListUserDataErrorResponse()
    {
    }

    public Task<GetDualInvestmentProductListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDualInvestmentProductListUserDataError.Create(response, ct);
}
