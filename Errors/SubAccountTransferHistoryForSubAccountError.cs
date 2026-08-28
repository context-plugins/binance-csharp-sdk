using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class SubAccountTransferHistoryForSubAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SubAccountTransferHistoryForSubAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SubAccountTransferHistoryForSubAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SubAccountTransferHistoryForSubAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SubAccountTransferHistoryForSubAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubAccountTransferHistoryForSubAccountErrorResponse : IErrorResponse<SubAccountTransferHistoryForSubAccountError>
{
    public static SubAccountTransferHistoryForSubAccountErrorResponse Instance { get; } = new();

    private SubAccountTransferHistoryForSubAccountErrorResponse()
    {
    }

    public Task<SubAccountTransferHistoryForSubAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubAccountTransferHistoryForSubAccountError.Create(response, ct);
}
