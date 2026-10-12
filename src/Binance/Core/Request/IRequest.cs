using System.Net.Http;

namespace Binance.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}