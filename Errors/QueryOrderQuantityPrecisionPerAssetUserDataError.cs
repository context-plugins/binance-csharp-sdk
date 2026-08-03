using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryOrderQuantityPrecisionPerAssetUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryOrderQuantityPrecisionPerAssetUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryOrderQuantityPrecisionPerAssetUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryOrderQuantityPrecisionPerAssetUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryOrderQuantityPrecisionPerAssetUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryOrderQuantityPrecisionPerAssetUserDataErrorResponse : IErrorResponse<QueryOrderQuantityPrecisionPerAssetUserDataError>
{
    public static QueryOrderQuantityPrecisionPerAssetUserDataErrorResponse Instance { get; } = new();

    private QueryOrderQuantityPrecisionPerAssetUserDataErrorResponse()
    {
    }

    public Task<QueryOrderQuantityPrecisionPerAssetUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => QueryOrderQuantityPrecisionPerAssetUserDataError.Create(response, ct);
}
