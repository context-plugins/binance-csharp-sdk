using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class EthStakingAccountV2UserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EthStakingAccountV2UserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EthStakingAccountV2UserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EthStakingAccountV2UserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EthStakingAccountV2UserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EthStakingAccountV2UserDataErrorResponse : IErrorResponse<EthStakingAccountV2UserDataError>
{
    public static EthStakingAccountV2UserDataErrorResponse Instance { get; } = new();

    private EthStakingAccountV2UserDataErrorResponse()
    {
    }

    public Task<EthStakingAccountV2UserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EthStakingAccountV2UserDataError.Create(response, ct);
}
