using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class FundAutoCollectionUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FundAutoCollectionUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FundAutoCollectionUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FundAutoCollectionUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FundAutoCollectionUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FundAutoCollectionUserDataErrorResponse : IErrorResponse<FundAutoCollectionUserDataError>
{
    public static FundAutoCollectionUserDataErrorResponse Instance { get; } = new();

    private FundAutoCollectionUserDataErrorResponse()
    {
    }

    public Task<FundAutoCollectionUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FundAutoCollectionUserDataError.Create(response, ct);
}
