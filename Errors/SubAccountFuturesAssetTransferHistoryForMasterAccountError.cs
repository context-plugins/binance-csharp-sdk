using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SubAccountFuturesAssetTransferHistoryForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubAccountFuturesAssetTransferHistoryForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubAccountFuturesAssetTransferHistoryForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubAccountFuturesAssetTransferHistoryForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubAccountFuturesAssetTransferHistoryForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubAccountFuturesAssetTransferHistoryForMasterAccountErrorResponse : IErrorResponse<SubAccountFuturesAssetTransferHistoryForMasterAccountError>
{
    public static SubAccountFuturesAssetTransferHistoryForMasterAccountErrorResponse Instance { get; } = new();

    private SubAccountFuturesAssetTransferHistoryForMasterAccountErrorResponse()
    {
    }

    public Task<SubAccountFuturesAssetTransferHistoryForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        SubAccountFuturesAssetTransferHistoryForMasterAccountError.Create(response, ct);
}
