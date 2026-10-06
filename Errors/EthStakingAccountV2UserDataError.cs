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

    private static EthStakingAccountV2UserDataError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static EthStakingAccountV2UserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<EthStakingAccountV2UserDataError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<EthStakingAccountV2UserDataError> Response { get; } = new(Create);
}
