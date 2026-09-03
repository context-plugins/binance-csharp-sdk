using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetManagedSubAccountDepositAddressForInvestorMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetManagedSubAccountDepositAddressForInvestorMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetManagedSubAccountDepositAddressForInvestorMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetManagedSubAccountDepositAddressForInvestorMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetManagedSubAccountDepositAddressForInvestorMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetManagedSubAccountDepositAddressForInvestorMasterAccountErrorResponse : IErrorResponse<GetManagedSubAccountDepositAddressForInvestorMasterAccountError>
{
    public static GetManagedSubAccountDepositAddressForInvestorMasterAccountErrorResponse Instance { get; } = new();

    private GetManagedSubAccountDepositAddressForInvestorMasterAccountErrorResponse()
    {
    }

    public Task<GetManagedSubAccountDepositAddressForInvestorMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetManagedSubAccountDepositAddressForInvestorMasterAccountError.Create(response, ct);
}
