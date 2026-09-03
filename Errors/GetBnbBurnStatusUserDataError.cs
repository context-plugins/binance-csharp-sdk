using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetBnbBurnStatusUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetBnbBurnStatusUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetBnbBurnStatusUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetBnbBurnStatusUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetBnbBurnStatusUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBnbBurnStatusUserDataErrorResponse : IErrorResponse<GetBnbBurnStatusUserDataError>
{
    public static GetBnbBurnStatusUserDataErrorResponse Instance { get; } = new();

    private GetBnbBurnStatusUserDataErrorResponse()
    {
    }

    public Task<GetBnbBurnStatusUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetBnbBurnStatusUserDataError.Create(response, ct);
}
