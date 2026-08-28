using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetSimpleEarnFlexibleProductListUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetSimpleEarnFlexibleProductListUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetSimpleEarnFlexibleProductListUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetSimpleEarnFlexibleProductListUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetSimpleEarnFlexibleProductListUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSimpleEarnFlexibleProductListUserDataErrorResponse : IErrorResponse<GetSimpleEarnFlexibleProductListUserDataError>
{
    public static GetSimpleEarnFlexibleProductListUserDataErrorResponse Instance { get; } = new();

    private GetSimpleEarnFlexibleProductListUserDataErrorResponse()
    {
    }

    public Task<GetSimpleEarnFlexibleProductListUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetSimpleEarnFlexibleProductListUserDataError.Create(response, ct);
}
