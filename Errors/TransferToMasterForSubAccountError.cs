using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class TransferToMasterForSubAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private TransferToMasterForSubAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static TransferToMasterForSubAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static TransferToMasterForSubAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<TransferToMasterForSubAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TransferToMasterForSubAccountErrorResponse : IErrorResponse<TransferToMasterForSubAccountError>
{
    public static TransferToMasterForSubAccountErrorResponse Instance { get; } = new();

    private TransferToMasterForSubAccountErrorResponse()
    {
    }

    public Task<TransferToMasterForSubAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        TransferToMasterForSubAccountError.Create(response, ct);
}
