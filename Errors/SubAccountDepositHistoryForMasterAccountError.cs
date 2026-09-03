using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class SubAccountDepositHistoryForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubAccountDepositHistoryForMasterAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubAccountDepositHistoryForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubAccountDepositHistoryForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubAccountDepositHistoryForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubAccountDepositHistoryForMasterAccountErrorResponse : IErrorResponse<SubAccountDepositHistoryForMasterAccountError>
{
    public static SubAccountDepositHistoryForMasterAccountErrorResponse Instance { get; } = new();

    private SubAccountDepositHistoryForMasterAccountErrorResponse()
    {
    }

    public Task<SubAccountDepositHistoryForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => SubAccountDepositHistoryForMasterAccountError.Create(response, ct);
}
