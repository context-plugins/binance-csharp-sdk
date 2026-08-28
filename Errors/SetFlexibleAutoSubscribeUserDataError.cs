using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SetFlexibleAutoSubscribeUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SetFlexibleAutoSubscribeUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SetFlexibleAutoSubscribeUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SetFlexibleAutoSubscribeUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SetFlexibleAutoSubscribeUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetFlexibleAutoSubscribeUserDataErrorResponse : IErrorResponse<SetFlexibleAutoSubscribeUserDataError>
{
    public static SetFlexibleAutoSubscribeUserDataErrorResponse Instance { get; } = new();

    private SetFlexibleAutoSubscribeUserDataErrorResponse()
    {
    }

    public Task<SetFlexibleAutoSubscribeUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetFlexibleAutoSubscribeUserDataError.Create(response, ct);
}
