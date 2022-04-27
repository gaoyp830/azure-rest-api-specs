// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.Reservations.Models
{
    public partial class ExtendedStatusInfo
    {
        internal static ExtendedStatusInfo DeserializeExtendedStatusInfo(JsonElement element)
        {
            Optional<ReservationStatusCode> statusCode = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statusCode = new ReservationStatusCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new ExtendedStatusInfo(Optional.ToNullable(statusCode), message.Value);
        }
    }
}
