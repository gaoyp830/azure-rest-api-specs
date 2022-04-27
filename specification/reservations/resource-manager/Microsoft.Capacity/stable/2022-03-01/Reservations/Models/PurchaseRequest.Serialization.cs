// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.Reservations.Models
{
    public partial class PurchaseRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ReservedResourceType))
            {
                writer.WritePropertyName("reservedResourceType");
                writer.WriteStringValue(ReservedResourceType.Value.ToString());
            }
            if (Optional.IsDefined(BillingScopeId))
            {
                writer.WritePropertyName("billingScopeId");
                writer.WriteStringValue(BillingScopeId);
            }
            if (Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term");
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan");
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity");
                writer.WriteNumberValue(Quantity.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(AppliedScopeType))
            {
                writer.WritePropertyName("appliedScopeType");
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AppliedScopes))
            {
                writer.WritePropertyName("appliedScopes");
                writer.WriteStartArray();
                foreach (var item in AppliedScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Renew))
            {
                writer.WritePropertyName("renew");
                writer.WriteBooleanValue(Renew.Value);
            }
            if (Optional.IsDefined(ReservedResourceProperties))
            {
                writer.WritePropertyName("reservedResourceProperties");
                writer.WriteObjectValue(ReservedResourceProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PurchaseRequest DeserializePurchaseRequest(JsonElement element)
        {
            Optional<ReservationsSkuName> sku = default;
            Optional<string> location = default;
            Optional<ReservedResourceType> reservedResourceType = default;
            Optional<string> billingScopeId = default;
            Optional<ReservationTerm> term = default;
            Optional<ReservationBillingPlan> billingPlan = default;
            Optional<int> quantity = default;
            Optional<string> displayName = default;
            Optional<AppliedScopeType> appliedScopeType = default;
            Optional<IList<string>> appliedScopes = default;
            Optional<bool> renew = default;
            Optional<PurchaseRequestPropertiesReservedResourceProperties> reservedResourceProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = ReservationsSkuName.DeserializeReservationsSkuName(property.Value);
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("reservedResourceType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reservedResourceType = new ReservedResourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingScopeId"))
                        {
                            billingScopeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("term"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            term = new ReservationTerm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingPlan = new ReservationBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("quantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            quantity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            appliedScopeType = new AppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            appliedScopes = array;
                            continue;
                        }
                        if (property0.NameEquals("renew"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            renew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reservedResourceProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reservedResourceProperties = PurchaseRequestPropertiesReservedResourceProperties.DeserializePurchaseRequestPropertiesReservedResourceProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PurchaseRequest(sku.Value, location.Value, Optional.ToNullable(reservedResourceType), billingScopeId.Value, Optional.ToNullable(term), Optional.ToNullable(billingPlan), Optional.ToNullable(quantity), displayName.Value, Optional.ToNullable(appliedScopeType), Optional.ToList(appliedScopes), Optional.ToNullable(renew), reservedResourceProperties.Value);
        }
    }
}
