using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MarginTransferForSubAccountForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MarginTransferForSubAccountForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MarginTransferForSubAccountForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MarginTransferForSubAccountForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MarginTransferForSubAccountForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MarginTransferForSubAccountForMasterAccountErrorResponse : IErrorResponse<MarginTransferForSubAccountForMasterAccountError>
{
    public static MarginTransferForSubAccountForMasterAccountErrorResponse Instance { get; } = new();

    private MarginTransferForSubAccountForMasterAccountErrorResponse()
    {
    }

    public Task<MarginTransferForSubAccountForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => MarginTransferForSubAccountForMasterAccountError.Create(response, ct);
}
