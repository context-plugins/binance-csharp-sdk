using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetCurrentEthStakingQuotaUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCurrentEthStakingQuotaUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCurrentEthStakingQuotaUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCurrentEthStakingQuotaUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetCurrentEthStakingQuotaUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCurrentEthStakingQuotaUserDataErrorResponse : IErrorResponse<GetCurrentEthStakingQuotaUserDataError>
{
    public static GetCurrentEthStakingQuotaUserDataErrorResponse Instance { get; } = new();

    private GetCurrentEthStakingQuotaUserDataErrorResponse()
    {
    }

    public Task<GetCurrentEthStakingQuotaUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCurrentEthStakingQuotaUserDataError.Create(response, ct);
}
