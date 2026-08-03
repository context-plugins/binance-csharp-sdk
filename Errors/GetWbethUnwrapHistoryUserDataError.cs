using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetWbethUnwrapHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetWbethUnwrapHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetWbethUnwrapHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetWbethUnwrapHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetWbethUnwrapHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetWbethUnwrapHistoryUserDataErrorResponse : IErrorResponse<GetWbethUnwrapHistoryUserDataError>
{
    public static GetWbethUnwrapHistoryUserDataErrorResponse Instance { get; } = new();

    private GetWbethUnwrapHistoryUserDataErrorResponse()
    {
    }

    public Task<GetWbethUnwrapHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetWbethUnwrapHistoryUserDataError.Create(response, ct);
}
