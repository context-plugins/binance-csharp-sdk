using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetCrossOrIsolatedMarginCapitalFlowUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCrossOrIsolatedMarginCapitalFlowUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCrossOrIsolatedMarginCapitalFlowUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCrossOrIsolatedMarginCapitalFlowUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetCrossOrIsolatedMarginCapitalFlowUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCrossOrIsolatedMarginCapitalFlowUserDataErrorResponse : IErrorResponse<GetCrossOrIsolatedMarginCapitalFlowUserDataError>
{
    public static GetCrossOrIsolatedMarginCapitalFlowUserDataErrorResponse Instance { get; } = new();

    private GetCrossOrIsolatedMarginCapitalFlowUserDataErrorResponse()
    {
    }

    public Task<GetCrossOrIsolatedMarginCapitalFlowUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetCrossOrIsolatedMarginCapitalFlowUserDataError.Create(response, ct);
}
