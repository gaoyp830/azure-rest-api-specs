// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.Reservations.Models
{
    /// <summary> Reservation refund details. </summary>
    public partial class ReservationToExchange
    {
        /// <summary> Initializes a new instance of ReservationToExchange. </summary>
        internal ReservationToExchange()
        {
        }

        /// <summary> Initializes a new instance of ReservationToExchange. </summary>
        /// <param name="reservationId"> Fully qualified id of the Reservation being returned. </param>
        /// <param name="quantity"> Quantity to be returned. </param>
        /// <param name="billingRefundAmount"></param>
        /// <param name="billingInformation"> billing information. </param>
        internal ReservationToExchange(string reservationId, int? quantity, Price billingRefundAmount, BillingInformation billingInformation)
        {
            ReservationId = reservationId;
            Quantity = quantity;
            BillingRefundAmount = billingRefundAmount;
            BillingInformation = billingInformation;
        }

        /// <summary> Fully qualified id of the Reservation being returned. </summary>
        public string ReservationId { get; }
        /// <summary> Quantity to be returned. </summary>
        public int? Quantity { get; }
        /// <summary> Gets the billing refund amount. </summary>
        public Price BillingRefundAmount { get; }
        /// <summary> billing information. </summary>
        public BillingInformation BillingInformation { get; }
    }
}
