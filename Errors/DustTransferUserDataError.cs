using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class DustTransferUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DustTransferUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DustTransferUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DustTransferUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DustTransferUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DustTransferUserDataErrorResponse : IErrorResponse<DustTransferUserDataError>
{
    public static DustTransferUserDataErrorResponse Instance { get; } = new();

    private DustTransferUserDataErrorResponse()
    {
    }

    public Task<DustTransferUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DustTransferUserDataError.Create(response, ct);
}
