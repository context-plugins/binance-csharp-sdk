using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class VolumeParticipationVpNewOrderTradeError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private VolumeParticipationVpNewOrderTradeError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static VolumeParticipationVpNewOrderTradeError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static VolumeParticipationVpNewOrderTradeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<VolumeParticipationVpNewOrderTradeError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<VolumeParticipationVpNewOrderTradeError> Response { get; } = new(Create);
}
