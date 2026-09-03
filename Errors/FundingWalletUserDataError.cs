using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class FundingWalletUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FundingWalletUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FundingWalletUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FundingWalletUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FundingWalletUserDataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FundingWalletUserDataErrorResponse : IErrorResponse<FundingWalletUserDataError>
{
    public static FundingWalletUserDataErrorResponse Instance { get; } = new();

    private FundingWalletUserDataErrorResponse()
    {
    }

    public Task<FundingWalletUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FundingWalletUserDataError.Create(response, ct);
}
