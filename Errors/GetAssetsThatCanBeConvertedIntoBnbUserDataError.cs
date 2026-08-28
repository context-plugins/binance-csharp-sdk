using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetAssetsThatCanBeConvertedIntoBnbUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAssetsThatCanBeConvertedIntoBnbUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAssetsThatCanBeConvertedIntoBnbUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAssetsThatCanBeConvertedIntoBnbUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAssetsThatCanBeConvertedIntoBnbUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAssetsThatCanBeConvertedIntoBnbUserDataErrorResponse : IErrorResponse<GetAssetsThatCanBeConvertedIntoBnbUserDataError>
{
    public static GetAssetsThatCanBeConvertedIntoBnbUserDataErrorResponse Instance { get; } = new();

    private GetAssetsThatCanBeConvertedIntoBnbUserDataErrorResponse()
    {
    }

    public Task<GetAssetsThatCanBeConvertedIntoBnbUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetAssetsThatCanBeConvertedIntoBnbUserDataError.Create(response, ct);
}
