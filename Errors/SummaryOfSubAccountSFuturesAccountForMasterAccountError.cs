using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SummaryOfSubAccountSFuturesAccountForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SummaryOfSubAccountSFuturesAccountForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SummaryOfSubAccountSFuturesAccountForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SummaryOfSubAccountSFuturesAccountForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SummaryOfSubAccountSFuturesAccountForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SummaryOfSubAccountSFuturesAccountForMasterAccountErrorResponse : IErrorResponse<SummaryOfSubAccountSFuturesAccountForMasterAccountError>
{
    public static SummaryOfSubAccountSFuturesAccountForMasterAccountErrorResponse Instance { get; } = new();

    private SummaryOfSubAccountSFuturesAccountForMasterAccountErrorResponse()
    {
    }

    public Task<SummaryOfSubAccountSFuturesAccountForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => SummaryOfSubAccountSFuturesAccountForMasterAccountError.Create(response, ct);
}
