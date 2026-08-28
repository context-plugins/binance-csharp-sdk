using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class StatisticListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private StatisticListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static StatisticListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static StatisticListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<StatisticListUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class StatisticListUserDataErrorResponse : IErrorResponse<StatisticListUserDataError>
{
    public static StatisticListUserDataErrorResponse Instance { get; } = new();

    private StatisticListUserDataErrorResponse()
    {
    }

    public Task<StatisticListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        StatisticListUserDataError.Create(response, ct);
}
