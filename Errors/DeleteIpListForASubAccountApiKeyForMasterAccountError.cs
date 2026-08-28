using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Binance.Core.ErrorResponse;
using Binance.Core.Models;
using Binance.Models;

namespace Binance.Errors;

public sealed class DeleteIpListForASubAccountApiKeyForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteIpListForASubAccountApiKeyForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteIpListForASubAccountApiKeyForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteIpListForASubAccountApiKeyForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteIpListForASubAccountApiKeyForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteIpListForASubAccountApiKeyForMasterAccountErrorResponse : IErrorResponse<DeleteIpListForASubAccountApiKeyForMasterAccountError>
{
    public static DeleteIpListForASubAccountApiKeyForMasterAccountErrorResponse Instance { get; } = new();

    private DeleteIpListForASubAccountApiKeyForMasterAccountErrorResponse()
    {
    }

    public Task<DeleteIpListForASubAccountApiKeyForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => DeleteIpListForASubAccountApiKeyForMasterAccountError.Create(response, ct);
}
