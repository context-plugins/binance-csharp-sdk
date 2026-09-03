using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class WithdrawUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private WithdrawUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static WithdrawUserDataError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static WithdrawUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<WithdrawUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class WithdrawUserDataErrorResponse : IErrorResponse<WithdrawUserDataError>
{
    public static WithdrawUserDataErrorResponse Instance { get; } = new();

    private WithdrawUserDataErrorResponse()
    {
    }

    public Task<WithdrawUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        WithdrawUserDataError.Create(response, ct);
}
