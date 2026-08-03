using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SubAccountSpotAssetTransferHistoryForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubAccountSpotAssetTransferHistoryForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubAccountSpotAssetTransferHistoryForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubAccountSpotAssetTransferHistoryForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubAccountSpotAssetTransferHistoryForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubAccountSpotAssetTransferHistoryForMasterAccountErrorResponse : IErrorResponse<SubAccountSpotAssetTransferHistoryForMasterAccountError>
{
    public static SubAccountSpotAssetTransferHistoryForMasterAccountErrorResponse Instance { get; } = new();

    private SubAccountSpotAssetTransferHistoryForMasterAccountErrorResponse()
    {
    }

    public Task<SubAccountSpotAssetTransferHistoryForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => SubAccountSpotAssetTransferHistoryForMasterAccountError.Create(response, ct);
}
