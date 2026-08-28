using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class GetFlexibleLoanAssetsDataUserDataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFlexibleLoanAssetsDataUserDataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFlexibleLoanAssetsDataUserDataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetFlexibleLoanAssetsDataUserDataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFlexibleLoanAssetsDataUserDataError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFlexibleLoanAssetsDataUserDataErrorResponse : IErrorResponse<GetFlexibleLoanAssetsDataUserDataError>
{
    public static GetFlexibleLoanAssetsDataUserDataErrorResponse Instance { get; } = new();

    private GetFlexibleLoanAssetsDataUserDataErrorResponse()
    {
    }

    public Task<GetFlexibleLoanAssetsDataUserDataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFlexibleLoanAssetsDataUserDataError.Create(response, ct);
}
