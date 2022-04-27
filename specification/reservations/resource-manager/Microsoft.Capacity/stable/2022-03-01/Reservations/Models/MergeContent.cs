// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.Reservations.Models
{
    /// <summary> The MergeRequest. </summary>
    public partial class MergeContent
    {
        /// <summary> Initializes a new instance of MergeContent. </summary>
        public MergeContent()
        {
            Sources = new ChangeTrackingList<string>();
        }

        /// <summary> Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public IList<string> Sources { get; }
    }
}
