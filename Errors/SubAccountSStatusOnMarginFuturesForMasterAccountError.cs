using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SubAccountSStatusOnMarginFuturesForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubAccountSStatusOnMarginFuturesForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubAccountSStatusOnMarginFuturesForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubAccountSStatusOnMarginFuturesForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubAccountSStatusOnMarginFuturesForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubAccountSStatusOnMarginFuturesForMasterAccountErrorResponse : IErrorResponse<SubAccountSStatusOnMarginFuturesForMasterAccountError>
{
    public static SubAccountSStatusOnMarginFuturesForMasterAccountErrorResponse Instance { get; } = new();

    private SubAccountSStatusOnMarginFuturesForMasterAccountErrorResponse()
    {
    }

    public Task<SubAccountSStatusOnMarginFuturesForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => SubAccountSStatusOnMarginFuturesForMasterAccountError.Create(response, ct);
}
