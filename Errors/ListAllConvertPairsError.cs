using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class ListAllConvertPairsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ListAllConvertPairsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ListAllConvertPairsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ListAllConvertPairsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ListAllConvertPairsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListAllConvertPairsErrorResponse : IErrorResponse<ListAllConvertPairsError>
{
    public static ListAllConvertPairsErrorResponse Instance { get; } = new();

    private ListAllConvertPairsErrorResponse()
    {
    }

    public Task<ListAllConvertPairsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListAllConvertPairsError.Create(response, ct);
}
