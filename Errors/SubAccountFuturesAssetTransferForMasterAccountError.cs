using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SubAccountFuturesAssetTransferForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubAccountFuturesAssetTransferForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubAccountFuturesAssetTransferForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubAccountFuturesAssetTransferForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubAccountFuturesAssetTransferForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubAccountFuturesAssetTransferForMasterAccountErrorResponse : IErrorResponse<SubAccountFuturesAssetTransferForMasterAccountError>
{
    public static SubAccountFuturesAssetTransferForMasterAccountErrorResponse Instance { get; } = new();

    private SubAccountFuturesAssetTransferForMasterAccountErrorResponse()
    {
    }

    public Task<SubAccountFuturesAssetTransferForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => SubAccountFuturesAssetTransferForMasterAccountError.Create(response, ct);
}
