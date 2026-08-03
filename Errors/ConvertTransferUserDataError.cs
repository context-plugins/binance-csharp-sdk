using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class ConvertTransferUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ConvertTransferUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ConvertTransferUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ConvertTransferUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ConvertTransferUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ConvertTransferUserDataErrorResponse : IErrorResponse<ConvertTransferUserDataError>
{
    public static ConvertTransferUserDataErrorResponse Instance { get; } = new();

    private ConvertTransferUserDataErrorResponse()
    {
    }

    public Task<ConvertTransferUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ConvertTransferUserDataError.Create(response, ct);
}
