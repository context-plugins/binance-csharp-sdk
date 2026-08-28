using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetCloudMiningPaymentAndRefundHistoryUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCloudMiningPaymentAndRefundHistoryUserDataError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCloudMiningPaymentAndRefundHistoryUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCloudMiningPaymentAndRefundHistoryUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetCloudMiningPaymentAndRefundHistoryUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCloudMiningPaymentAndRefundHistoryUserDataErrorResponse : IErrorResponse<GetCloudMiningPaymentAndRefundHistoryUserDataError>
{
    public static GetCloudMiningPaymentAndRefundHistoryUserDataErrorResponse Instance { get; } = new();

    private GetCloudMiningPaymentAndRefundHistoryUserDataErrorResponse()
    {
    }

    public Task<GetCloudMiningPaymentAndRefundHistoryUserDataError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetCloudMiningPaymentAndRefundHistoryUserDataError.Create(response, ct);
}
