using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SubscribeDualInvestmentProductsUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubscribeDualInvestmentProductsUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubscribeDualInvestmentProductsUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubscribeDualInvestmentProductsUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubscribeDualInvestmentProductsUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscribeDualInvestmentProductsUserDataErrorResponse : IErrorResponse<SubscribeDualInvestmentProductsUserDataError>
{
    public static SubscribeDualInvestmentProductsUserDataErrorResponse Instance { get; } = new();

    private SubscribeDualInvestmentProductsUserDataErrorResponse()
    {
    }

    public Task<SubscribeDualInvestmentProductsUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => SubscribeDualInvestmentProductsUserDataError.Create(response, ct);
}
