using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetSummaryOfMarginAccountUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetSummaryOfMarginAccountUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetSummaryOfMarginAccountUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetSummaryOfMarginAccountUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetSummaryOfMarginAccountUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSummaryOfMarginAccountUserDataErrorResponse : IErrorResponse<GetSummaryOfMarginAccountUserDataError>
{
    public static GetSummaryOfMarginAccountUserDataErrorResponse Instance { get; } = new();

    private GetSummaryOfMarginAccountUserDataErrorResponse()
    {
    }

    public Task<GetSummaryOfMarginAccountUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetSummaryOfMarginAccountUserDataError.Create(response, ct);
}
