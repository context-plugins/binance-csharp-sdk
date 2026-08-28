using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetFlexiblePersonalLeftQuotaUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFlexiblePersonalLeftQuotaUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFlexiblePersonalLeftQuotaUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFlexiblePersonalLeftQuotaUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFlexiblePersonalLeftQuotaUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFlexiblePersonalLeftQuotaUserDataErrorResponse : IErrorResponse<GetFlexiblePersonalLeftQuotaUserDataError>
{
    public static GetFlexiblePersonalLeftQuotaUserDataErrorResponse Instance { get; } = new();

    private GetFlexiblePersonalLeftQuotaUserDataErrorResponse()
    {
    }

    public Task<GetFlexiblePersonalLeftQuotaUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFlexiblePersonalLeftQuotaUserDataError.Create(response, ct);
}
