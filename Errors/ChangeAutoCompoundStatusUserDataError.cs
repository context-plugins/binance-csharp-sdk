using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class ChangeAutoCompoundStatusUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ChangeAutoCompoundStatusUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ChangeAutoCompoundStatusUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ChangeAutoCompoundStatusUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ChangeAutoCompoundStatusUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ChangeAutoCompoundStatusUserDataErrorResponse : IErrorResponse<ChangeAutoCompoundStatusUserDataError>
{
    public static ChangeAutoCompoundStatusUserDataErrorResponse Instance { get; } = new();

    private ChangeAutoCompoundStatusUserDataErrorResponse()
    {
    }

    public Task<ChangeAutoCompoundStatusUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ChangeAutoCompoundStatusUserDataError.Create(response, ct);
}
