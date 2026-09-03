using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountErrorResponse : IErrorResponse<DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError>
{
    public static DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountErrorResponse Instance { get; } = new();

    private DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountErrorResponse()
    {
    }

    public Task<DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        DepositAssetsIntoTheManagedSubAccountForInvestorMasterAccountError.Create(response, ct);
}
