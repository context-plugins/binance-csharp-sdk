using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class BnbTransferUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private BnbTransferUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static BnbTransferUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static BnbTransferUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<BnbTransferUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BnbTransferUserDataErrorResponse : IErrorResponse<BnbTransferUserDataError>
{
    public static BnbTransferUserDataErrorResponse Instance { get; } = new();

    private BnbTransferUserDataErrorResponse()
    {
    }

    public Task<BnbTransferUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BnbTransferUserDataError.Create(response, ct);
}
