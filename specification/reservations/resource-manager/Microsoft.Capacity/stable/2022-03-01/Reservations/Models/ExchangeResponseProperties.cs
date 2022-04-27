// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.Reservations.Models
{
    /// <summary> Exchange response properties. </summary>
    public partial class ExchangeResponseProperties
    {
        /// <summary> Initializes a new instance of ExchangeResponseProperties. </summary>
        internal ExchangeResponseProperties()
        {
            ReservationsToPurchase = new ChangeTrackingList<ReservationToPurchaseExchange>();
            ReservationsToExchange = new ChangeTrackingList<ReservationToReturnForExchange>();
        }

        /// <summary> Initializes a new instance of ExchangeResponseProperties. </summary>
        /// <param name="sessionId"> Exchange session identifier. </param>
        /// <param name="netPayable"></param>
        /// <param name="refundsTotal"></param>
        /// <param name="purchasesTotal"></param>
        /// <param name="reservationsToPurchase"> Details of the reservations being purchased. </param>
        /// <param name="reservationsToExchange"> Details of the reservations being returned. </param>
        /// <param name="policyResult"> Exchange policy errors. </param>
        internal ExchangeResponseProperties(string sessionId, Price netPayable, Price refundsTotal, Price purchasesTotal, IReadOnlyList<ReservationToPurchaseExchange> reservationsToPurchase, IReadOnlyList<ReservationToReturnForExchange> reservationsToExchange, ExchangePolicyErrors policyResult)
        {
            SessionId = sessionId;
            NetPayable = netPayable;
            RefundsTotal = refundsTotal;
            PurchasesTotal = purchasesTotal;
            ReservationsToPurchase = reservationsToPurchase;
            ReservationsToExchange = reservationsToExchange;
            PolicyResult = policyResult;
        }

        /// <summary> Exchange session identifier. </summary>
        public string SessionId { get; }
        /// <summary> Gets the net payable. </summary>
        public Price NetPayable { get; }
        /// <summary> Gets the refunds total. </summary>
        public Price RefundsTotal { get; }
        /// <summary> Gets the purchases total. </summary>
        public Price PurchasesTotal { get; }
        /// <summary> Details of the reservations being purchased. </summary>
        public IReadOnlyList<ReservationToPurchaseExchange> ReservationsToPurchase { get; }
        /// <summary> Details of the reservations being returned. </summary>
        public IReadOnlyList<ReservationToReturnForExchange> ReservationsToExchange { get; }
        /// <summary> Exchange policy errors. </summary>
        internal ExchangePolicyErrors PolicyResult { get; }
        /// <summary> Exchange Policy errors. </summary>
        public IReadOnlyList<ExchangePolicyError> PolicyErrors
        {
            get => PolicyResult.PolicyErrors;
        }
    }
}
