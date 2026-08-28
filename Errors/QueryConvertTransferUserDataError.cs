using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class QueryConvertTransferUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryConvertTransferUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryConvertTransferUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryConvertTransferUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryConvertTransferUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryConvertTransferUserDataErrorResponse : IErrorResponse<QueryConvertTransferUserDataError>
{
    public static QueryConvertTransferUserDataErrorResponse Instance { get; } = new();

    private QueryConvertTransferUserDataErrorResponse()
    {
    }

    public Task<QueryConvertTransferUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryConvertTransferUserDataError.Create(response, ct);
}
