using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetCollateralAssetDataUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCollateralAssetDataUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCollateralAssetDataUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCollateralAssetDataUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetCollateralAssetDataUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCollateralAssetDataUserDataErrorResponse : IErrorResponse<GetCollateralAssetDataUserDataError>
{
    public static GetCollateralAssetDataUserDataErrorResponse Instance { get; } = new();

    private GetCollateralAssetDataUserDataErrorResponse()
    {
    }

    public Task<GetCollateralAssetDataUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCollateralAssetDataUserDataError.Create(response, ct);
}
