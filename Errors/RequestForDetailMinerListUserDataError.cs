using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class RequestForDetailMinerListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RequestForDetailMinerListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RequestForDetailMinerListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RequestForDetailMinerListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RequestForDetailMinerListUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RequestForDetailMinerListUserDataErrorResponse : IErrorResponse<RequestForDetailMinerListUserDataError>
{
    public static RequestForDetailMinerListUserDataErrorResponse Instance { get; } = new();

    private RequestForDetailMinerListUserDataErrorResponse()
    {
    }

    public Task<RequestForDetailMinerListUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RequestForDetailMinerListUserDataError.Create(response, ct);
}
