using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class DetailOnSubAccountSFuturesAccountV2ForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DetailOnSubAccountSFuturesAccountV2ForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DetailOnSubAccountSFuturesAccountV2ForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DetailOnSubAccountSFuturesAccountV2ForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DetailOnSubAccountSFuturesAccountV2ForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DetailOnSubAccountSFuturesAccountV2ForMasterAccountErrorResponse : IErrorResponse<DetailOnSubAccountSFuturesAccountV2ForMasterAccountError>
{
    public static DetailOnSubAccountSFuturesAccountV2ForMasterAccountErrorResponse Instance { get; } = new();

    private DetailOnSubAccountSFuturesAccountV2ForMasterAccountErrorResponse()
    {
    }

    public Task<DetailOnSubAccountSFuturesAccountV2ForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => DetailOnSubAccountSFuturesAccountV2ForMasterAccountError.Create(response, ct);
}
