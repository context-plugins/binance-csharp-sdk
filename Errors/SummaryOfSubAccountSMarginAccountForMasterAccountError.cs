using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SummaryOfSubAccountSMarginAccountForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SummaryOfSubAccountSMarginAccountForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SummaryOfSubAccountSMarginAccountForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SummaryOfSubAccountSMarginAccountForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SummaryOfSubAccountSMarginAccountForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SummaryOfSubAccountSMarginAccountForMasterAccountErrorResponse : IErrorResponse<SummaryOfSubAccountSMarginAccountForMasterAccountError>
{
    public static SummaryOfSubAccountSMarginAccountForMasterAccountErrorResponse Instance { get; } = new();

    private SummaryOfSubAccountSMarginAccountForMasterAccountErrorResponse()
    {
    }

    public Task<SummaryOfSubAccountSMarginAccountForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => SummaryOfSubAccountSMarginAccountForMasterAccountError.Create(response, ct);
}
