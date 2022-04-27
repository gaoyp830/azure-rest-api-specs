// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.Reservations.Models
{
    public partial class Price
    {
        internal static Price DeserializePrice(JsonElement element)
        {
            Optional<string> currencyCode = default;
            Optional<double> amount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currencyCode"))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    amount = property.Value.GetDouble();
                    continue;
                }
            }
            return new Price(currencyCode.Value, Optional.ToNullable(amount));
        }
    }
}
