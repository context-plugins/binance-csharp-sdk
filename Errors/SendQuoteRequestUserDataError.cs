using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SendQuoteRequestUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SendQuoteRequestUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SendQuoteRequestUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SendQuoteRequestUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SendQuoteRequestUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SendQuoteRequestUserDataErrorResponse : IErrorResponse<SendQuoteRequestUserDataError>
{
    public static SendQuoteRequestUserDataErrorResponse Instance { get; } = new();

    private SendQuoteRequestUserDataErrorResponse()
    {
    }

    public Task<SendQuoteRequestUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SendQuoteRequestUserDataError.Create(response, ct);
}
