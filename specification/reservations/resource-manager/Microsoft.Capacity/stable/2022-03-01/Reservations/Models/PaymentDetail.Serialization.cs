// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.Reservations.Models
{
    public partial class PaymentDetail
    {
        internal static PaymentDetail DeserializePaymentDetail(JsonElement element)
        {
            Optional<DateTimeOffset> dueDate = default;
            Optional<DateTimeOffset> paymentDate = default;
            Optional<Price> pricingCurrencyTotal = default;
            Optional<Price> billingCurrencyTotal = default;
            Optional<string> billingAccount = default;
            Optional<PaymentStatus> status = default;
            Optional<ExtendedStatusInfo> extendedStatusInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dueDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("paymentDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paymentDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("pricingCurrencyTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pricingCurrencyTotal = Price.DeserializePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    billingCurrencyTotal = Price.DeserializePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingAccount"))
                {
                    billingAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new PaymentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extendedStatusInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedStatusInfo = ExtendedStatusInfo.DeserializeExtendedStatusInfo(property.Value);
                    continue;
                }
            }
            return new PaymentDetail(Optional.ToNullable(dueDate), Optional.ToNullable(paymentDate), pricingCurrencyTotal.Value, billingCurrencyTotal.Value, billingAccount.Value, Optional.ToNullable(status), extendedStatusInfo.Value);
        }
    }
}
