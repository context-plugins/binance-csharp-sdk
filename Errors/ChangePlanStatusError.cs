using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class ChangePlanStatusError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ChangePlanStatusError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ChangePlanStatusError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static ChangePlanStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ChangePlanStatusError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ChangePlanStatusErrorResponse : IErrorResponse<ChangePlanStatusError>
{
    public static ChangePlanStatusErrorResponse Instance { get; } = new();

    private ChangePlanStatusErrorResponse()
    {
    }

    public Task<ChangePlanStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ChangePlanStatusError.Create(response, ct);
}
