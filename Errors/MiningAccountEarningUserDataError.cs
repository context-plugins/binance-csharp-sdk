using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class MiningAccountEarningUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private MiningAccountEarningUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static MiningAccountEarningUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static MiningAccountEarningUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<MiningAccountEarningUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MiningAccountEarningUserDataErrorResponse : IErrorResponse<MiningAccountEarningUserDataError>
{
    public static MiningAccountEarningUserDataErrorResponse Instance { get; } = new();

    private MiningAccountEarningUserDataErrorResponse()
    {
    }

    public Task<MiningAccountEarningUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MiningAccountEarningUserDataError.Create(response, ct);
}
