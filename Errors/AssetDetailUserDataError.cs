using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class AssetDetailUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AssetDetailUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AssetDetailUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AssetDetailUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AssetDetailUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AssetDetailUserDataErrorResponse : IErrorResponse<AssetDetailUserDataError>
{
    public static AssetDetailUserDataErrorResponse Instance { get; } = new();

    private AssetDetailUserDataErrorResponse()
    {
    }

    public Task<AssetDetailUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AssetDetailUserDataError.Create(response, ct);
}
