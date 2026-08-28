using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetLockedPersonalLeftQuotaUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLockedPersonalLeftQuotaUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLockedPersonalLeftQuotaUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLockedPersonalLeftQuotaUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLockedPersonalLeftQuotaUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLockedPersonalLeftQuotaUserDataErrorResponse : IErrorResponse<GetLockedPersonalLeftQuotaUserDataError>
{
    public static GetLockedPersonalLeftQuotaUserDataErrorResponse Instance { get; } = new();

    private GetLockedPersonalLeftQuotaUserDataErrorResponse()
    {
    }

    public Task<GetLockedPersonalLeftQuotaUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLockedPersonalLeftQuotaUserDataError.Create(response, ct);
}
