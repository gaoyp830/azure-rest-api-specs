// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.Reservations.Models
{
    /// <summary> The AppliedReservationList. </summary>
    public partial class AppliedReservationList
    {
        /// <summary> Initializes a new instance of AppliedReservationList. </summary>
        internal AppliedReservationList()
        {
            Value = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppliedReservationList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> Url to get the next page of reservations. </param>
        internal AppliedReservationList(IReadOnlyList<string> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<string> Value { get; }
        /// <summary> Url to get the next page of reservations. </summary>
        public string NextLink { get; }
    }
}
