using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryMaxTransferOutAmountUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryMaxTransferOutAmountUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryMaxTransferOutAmountUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryMaxTransferOutAmountUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryMaxTransferOutAmountUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryMaxTransferOutAmountUserDataErrorResponse : IErrorResponse<QueryMaxTransferOutAmountUserDataError>
{
    public static QueryMaxTransferOutAmountUserDataErrorResponse Instance { get; } = new();

    private QueryMaxTransferOutAmountUserDataErrorResponse()
    {
    }

    public Task<QueryMaxTransferOutAmountUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryMaxTransferOutAmountUserDataError.Create(response, ct);
}
