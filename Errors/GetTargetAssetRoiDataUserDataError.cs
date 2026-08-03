using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetTargetAssetRoiDataUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetTargetAssetRoiDataUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetTargetAssetRoiDataUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetTargetAssetRoiDataUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetTargetAssetRoiDataUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTargetAssetRoiDataUserDataErrorResponse : IErrorResponse<GetTargetAssetRoiDataUserDataError>
{
    public static GetTargetAssetRoiDataUserDataErrorResponse Instance { get; } = new();

    private GetTargetAssetRoiDataUserDataErrorResponse()
    {
    }

    public Task<GetTargetAssetRoiDataUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTargetAssetRoiDataUserDataError.Create(response, ct);
}
