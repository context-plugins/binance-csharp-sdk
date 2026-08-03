using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class TransferToSubAccountOfSameMasterForSubAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private TransferToSubAccountOfSameMasterForSubAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static TransferToSubAccountOfSameMasterForSubAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static TransferToSubAccountOfSameMasterForSubAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<TransferToSubAccountOfSameMasterForSubAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class TransferToSubAccountOfSameMasterForSubAccountErrorResponse : IErrorResponse<TransferToSubAccountOfSameMasterForSubAccountError>
{
    public static TransferToSubAccountOfSameMasterForSubAccountErrorResponse Instance { get; } = new();

    private TransferToSubAccountOfSameMasterForSubAccountErrorResponse()
    {
    }

    public Task<TransferToSubAccountOfSameMasterForSubAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => TransferToSubAccountOfSameMasterForSubAccountError.Create(response, ct);
}
