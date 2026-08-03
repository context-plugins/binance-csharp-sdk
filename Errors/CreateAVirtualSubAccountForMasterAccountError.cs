using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class CreateAVirtualSubAccountForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateAVirtualSubAccountForMasterAccountError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateAVirtualSubAccountForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateAVirtualSubAccountForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateAVirtualSubAccountForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateAVirtualSubAccountForMasterAccountErrorResponse : IErrorResponse<CreateAVirtualSubAccountForMasterAccountError>
{
    public static CreateAVirtualSubAccountForMasterAccountErrorResponse Instance { get; } = new();

    private CreateAVirtualSubAccountForMasterAccountErrorResponse()
    {
    }

    public Task<CreateAVirtualSubAccountForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => CreateAVirtualSubAccountForMasterAccountError.Create(response, ct);
}
