using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryAllSourceAssetAndTargetAssetUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryAllSourceAssetAndTargetAssetUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryAllSourceAssetAndTargetAssetUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryAllSourceAssetAndTargetAssetUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryAllSourceAssetAndTargetAssetUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryAllSourceAssetAndTargetAssetUserDataErrorResponse : IErrorResponse<QueryAllSourceAssetAndTargetAssetUserDataError>
{
    public static QueryAllSourceAssetAndTargetAssetUserDataErrorResponse Instance { get; } = new();

    private QueryAllSourceAssetAndTargetAssetUserDataErrorResponse()
    {
    }

    public Task<QueryAllSourceAssetAndTargetAssetUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => QueryAllSourceAssetAndTargetAssetUserDataError.Create(response, ct);
}
