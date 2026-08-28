using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetFlexibleLoanCollateralAssetsDataUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFlexibleLoanCollateralAssetsDataUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFlexibleLoanCollateralAssetsDataUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFlexibleLoanCollateralAssetsDataUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFlexibleLoanCollateralAssetsDataUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFlexibleLoanCollateralAssetsDataUserDataErrorResponse : IErrorResponse<GetFlexibleLoanCollateralAssetsDataUserDataError>
{
    public static GetFlexibleLoanCollateralAssetsDataUserDataErrorResponse Instance { get; } = new();

    private GetFlexibleLoanCollateralAssetsDataUserDataErrorResponse()
    {
    }

    public Task<GetFlexibleLoanCollateralAssetsDataUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetFlexibleLoanCollateralAssetsDataUserDataError.Create(response, ct);
}
