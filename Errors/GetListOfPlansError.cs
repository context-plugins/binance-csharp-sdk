using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetListOfPlansError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetListOfPlansError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetListOfPlansError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetListOfPlansError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetListOfPlansError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetListOfPlansErrorResponse : IErrorResponse<GetListOfPlansError>
{
    public static GetListOfPlansErrorResponse Instance { get; } = new();

    private GetListOfPlansErrorResponse()
    {
    }

    public Task<GetListOfPlansError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetListOfPlansError.Create(response, ct);
}
