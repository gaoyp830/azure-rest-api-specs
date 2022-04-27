// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Microsoft.Azure.Management.Reservations.Models;

namespace Microsoft.Azure.Management.Reservations
{
    internal class ExchangeOperationResultResponseOperationSource : IOperationSource<ExchangeOperationResultResponse>
    {
        ExchangeOperationResultResponse IOperationSource<ExchangeOperationResultResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ExchangeOperationResultResponse.DeserializeExchangeOperationResultResponse(document.RootElement);
        }

        async ValueTask<ExchangeOperationResultResponse> IOperationSource<ExchangeOperationResultResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ExchangeOperationResultResponse.DeserializeExchangeOperationResultResponse(document.RootElement);
        }
    }
}
