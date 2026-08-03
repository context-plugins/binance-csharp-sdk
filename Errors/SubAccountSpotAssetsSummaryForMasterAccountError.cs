using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SubAccountSpotAssetsSummaryForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubAccountSpotAssetsSummaryForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubAccountSpotAssetsSummaryForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubAccountSpotAssetsSummaryForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubAccountSpotAssetsSummaryForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubAccountSpotAssetsSummaryForMasterAccountErrorResponse : IErrorResponse<SubAccountSpotAssetsSummaryForMasterAccountError>
{
    public static SubAccountSpotAssetsSummaryForMasterAccountErrorResponse Instance { get; } = new();

    private SubAccountSpotAssetsSummaryForMasterAccountErrorResponse()
    {
    }

    public Task<SubAccountSpotAssetsSummaryForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => SubAccountSpotAssetsSummaryForMasterAccountError.Create(response, ct);
}
