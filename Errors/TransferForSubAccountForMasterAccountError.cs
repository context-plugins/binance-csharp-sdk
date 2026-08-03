using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class TransferForSubAccountForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private TransferForSubAccountForMasterAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static TransferForSubAccountForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static TransferForSubAccountForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<TransferForSubAccountForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TransferForSubAccountForMasterAccountErrorResponse : IErrorResponse<TransferForSubAccountForMasterAccountError>
{
    public static TransferForSubAccountForMasterAccountErrorResponse Instance { get; } = new();

    private TransferForSubAccountForMasterAccountErrorResponse()
    {
    }

    public Task<TransferForSubAccountForMasterAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        TransferForSubAccountForMasterAccountError.Create(response, ct);
}
