using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QuerySubAccountListForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QuerySubAccountListForMasterAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QuerySubAccountListForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QuerySubAccountListForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QuerySubAccountListForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QuerySubAccountListForMasterAccountErrorResponse : IErrorResponse<QuerySubAccountListForMasterAccountError>
{
    public static QuerySubAccountListForMasterAccountErrorResponse Instance { get; } = new();

    private QuerySubAccountListForMasterAccountErrorResponse()
    {
    }

    public Task<QuerySubAccountListForMasterAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QuerySubAccountListForMasterAccountError.Create(response, ct);
}
