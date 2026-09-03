using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class ManagedSubAccountAssetDetailsForInvestorMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ManagedSubAccountAssetDetailsForInvestorMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ManagedSubAccountAssetDetailsForInvestorMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ManagedSubAccountAssetDetailsForInvestorMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ManagedSubAccountAssetDetailsForInvestorMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ManagedSubAccountAssetDetailsForInvestorMasterAccountErrorResponse : IErrorResponse<ManagedSubAccountAssetDetailsForInvestorMasterAccountError>
{
    public static ManagedSubAccountAssetDetailsForInvestorMasterAccountErrorResponse Instance { get; } = new();

    private ManagedSubAccountAssetDetailsForInvestorMasterAccountErrorResponse()
    {
    }

    public Task<ManagedSubAccountAssetDetailsForInvestorMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        ManagedSubAccountAssetDetailsForInvestorMasterAccountError.Create(response, ct);
}
