using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class VipLoanRenewError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private VipLoanRenewError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static VipLoanRenewError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static VipLoanRenewError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<VipLoanRenewError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class VipLoanRenewErrorResponse : IErrorResponse<VipLoanRenewError>
{
    public static VipLoanRenewErrorResponse Instance { get; } = new();

    private VipLoanRenewErrorResponse()
    {
    }

    public Task<VipLoanRenewError> Map(HttpResponseMessage response, CancellationToken ct) =>
        VipLoanRenewError.Create(response, ct);
}
