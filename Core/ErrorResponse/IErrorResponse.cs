using System.Threading;
using System.Threading.Tasks;
using Binance.Core.Models;

namespace Binance.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}