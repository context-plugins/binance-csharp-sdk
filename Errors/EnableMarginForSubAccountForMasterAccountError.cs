using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class EnableMarginForSubAccountForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EnableMarginForSubAccountForMasterAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EnableMarginForSubAccountForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EnableMarginForSubAccountForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EnableMarginForSubAccountForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EnableMarginForSubAccountForMasterAccountErrorResponse : IErrorResponse<EnableMarginForSubAccountForMasterAccountError>
{
    public static EnableMarginForSubAccountForMasterAccountErrorResponse Instance { get; } = new();

    private EnableMarginForSubAccountForMasterAccountErrorResponse()
    {
    }

    public Task<EnableMarginForSubAccountForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => EnableMarginForSubAccountForMasterAccountError.Create(response, ct);
}
