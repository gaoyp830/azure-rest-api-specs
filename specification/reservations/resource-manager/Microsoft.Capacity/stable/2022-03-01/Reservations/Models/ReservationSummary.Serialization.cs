// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.Reservations.Models
{
    internal partial class ReservationSummary
    {
        internal static ReservationSummary DeserializeReservationSummary(JsonElement element)
        {
            Optional<float> succeededCount = default;
            Optional<float> failedCount = default;
            Optional<float> expiringCount = default;
            Optional<float> expiredCount = default;
            Optional<float> pendingCount = default;
            Optional<float> cancelledCount = default;
            Optional<float> processingCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeededCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    succeededCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("failedCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failedCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiringCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiringCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiredCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiredCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("pendingCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pendingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("cancelledCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cancelledCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("processingCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    processingCount = property.Value.GetSingle();
                    continue;
                }
            }
            return new ReservationSummary(Optional.ToNullable(succeededCount), Optional.ToNullable(failedCount), Optional.ToNullable(expiringCount), Optional.ToNullable(expiredCount), Optional.ToNullable(pendingCount), Optional.ToNullable(cancelledCount), Optional.ToNullable(processingCount));
        }
    }
}
