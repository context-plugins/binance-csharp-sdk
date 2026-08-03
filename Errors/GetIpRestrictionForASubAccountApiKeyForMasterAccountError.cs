using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class GetIpRestrictionForASubAccountApiKeyForMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetIpRestrictionForASubAccountApiKeyForMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetIpRestrictionForASubAccountApiKeyForMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetIpRestrictionForASubAccountApiKeyForMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetIpRestrictionForASubAccountApiKeyForMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetIpRestrictionForASubAccountApiKeyForMasterAccountErrorResponse : IErrorResponse<GetIpRestrictionForASubAccountApiKeyForMasterAccountError>
{
    public static GetIpRestrictionForASubAccountApiKeyForMasterAccountErrorResponse Instance { get; } = new();

    private GetIpRestrictionForASubAccountApiKeyForMasterAccountErrorResponse()
    {
    }

    public Task<GetIpRestrictionForASubAccountApiKeyForMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetIpRestrictionForASubAccountApiKeyForMasterAccountError.Create(response, ct);
}
