using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SubAccountSpotAssetsSummaryForMasterAccount2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubAccountSpotAssetsSummaryForMasterAccount2Error(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubAccountSpotAssetsSummaryForMasterAccount2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubAccountSpotAssetsSummaryForMasterAccount2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubAccountSpotAssetsSummaryForMasterAccount2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubAccountSpotAssetsSummaryForMasterAccount2ErrorResponse : IErrorResponse<SubAccountSpotAssetsSummaryForMasterAccount2Error>
{
    public static SubAccountSpotAssetsSummaryForMasterAccount2ErrorResponse Instance { get; } = new();

    private SubAccountSpotAssetsSummaryForMasterAccount2ErrorResponse()
    {
    }

    public Task<SubAccountSpotAssetsSummaryForMasterAccount2Error> Map(HttpResponseMessage response,
        CancellationToken ct) => SubAccountSpotAssetsSummaryForMasterAccount2Error.Create(response, ct);
}
