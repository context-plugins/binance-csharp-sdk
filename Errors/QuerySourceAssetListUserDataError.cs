using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QuerySourceAssetListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QuerySourceAssetListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QuerySourceAssetListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QuerySourceAssetListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QuerySourceAssetListUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QuerySourceAssetListUserDataErrorResponse : IErrorResponse<QuerySourceAssetListUserDataError>
{
    public static QuerySourceAssetListUserDataErrorResponse Instance { get; } = new();

    private QuerySourceAssetListUserDataErrorResponse()
    {
    }

    public Task<QuerySourceAssetListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QuerySourceAssetListUserDataError.Create(response, ct);
}
