using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QuerySubAccountAssetsForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QuerySubAccountAssetsForMasterAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QuerySubAccountAssetsForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QuerySubAccountAssetsForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QuerySubAccountAssetsForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QuerySubAccountAssetsForMasterAccountErrorResponse : IErrorResponse<QuerySubAccountAssetsForMasterAccountError>
{
    public static QuerySubAccountAssetsForMasterAccountErrorResponse Instance { get; } = new();

    private QuerySubAccountAssetsForMasterAccountErrorResponse()
    {
    }

    public Task<QuerySubAccountAssetsForMasterAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QuerySubAccountAssetsForMasterAccountError.Create(response, ct);
}
