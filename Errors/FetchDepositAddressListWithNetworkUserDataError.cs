using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class FetchDepositAddressListWithNetworkUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FetchDepositAddressListWithNetworkUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FetchDepositAddressListWithNetworkUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FetchDepositAddressListWithNetworkUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FetchDepositAddressListWithNetworkUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FetchDepositAddressListWithNetworkUserDataErrorResponse : IErrorResponse<FetchDepositAddressListWithNetworkUserDataError>
{
    public static FetchDepositAddressListWithNetworkUserDataErrorResponse Instance { get; } = new();

    private FetchDepositAddressListWithNetworkUserDataErrorResponse()
    {
    }

    public Task<FetchDepositAddressListWithNetworkUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => FetchDepositAddressListWithNetworkUserDataError.Create(response, ct);
}
