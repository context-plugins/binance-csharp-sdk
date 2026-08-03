using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BinancePublicSpotApi.Core.ErrorResponse;
using BinancePublicSpotApi.Core.Models;
using BinancePublicSpotApi.Models;

namespace BinancePublicSpotApi.Errors;

public sealed class ManagedSubAccountSnapshotForInvestorMasterAccountError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ManagedSubAccountSnapshotForInvestorMasterAccountError(Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ManagedSubAccountSnapshotForInvestorMasterAccountError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ManagedSubAccountSnapshotForInvestorMasterAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ManagedSubAccountSnapshotForInvestorMasterAccountError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ManagedSubAccountSnapshotForInvestorMasterAccountErrorResponse : IErrorResponse<ManagedSubAccountSnapshotForInvestorMasterAccountError>
{
    public static ManagedSubAccountSnapshotForInvestorMasterAccountErrorResponse Instance { get; } = new();

    private ManagedSubAccountSnapshotForInvestorMasterAccountErrorResponse()
    {
    }

    public Task<ManagedSubAccountSnapshotForInvestorMasterAccountError> Map(HttpResponseMessage response,
        CancellationToken ct) => ManagedSubAccountSnapshotForInvestorMasterAccountError.Create(response, ct);
}
