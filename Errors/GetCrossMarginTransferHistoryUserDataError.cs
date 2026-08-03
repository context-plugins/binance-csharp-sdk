using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetCrossMarginTransferHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCrossMarginTransferHistoryUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCrossMarginTransferHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCrossMarginTransferHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetCrossMarginTransferHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCrossMarginTransferHistoryUserDataErrorResponse : IErrorResponse<GetCrossMarginTransferHistoryUserDataError>
{
    public static GetCrossMarginTransferHistoryUserDataErrorResponse Instance { get; } = new();

    private GetCrossMarginTransferHistoryUserDataErrorResponse()
    {
    }

    public Task<GetCrossMarginTransferHistoryUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCrossMarginTransferHistoryUserDataError.Create(response, ct);
}
