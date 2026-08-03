using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountErrorResponse : IErrorResponse<QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError>
{
    public static QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountErrorResponse Instance { get; } = new();

    private QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountErrorResponse()
    {
    }

    public Task<QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        QueryManagedSubAccountMarginAssetDetailsForInvestorMasterAccountError.Create(response, ct);
}
