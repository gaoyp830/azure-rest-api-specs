// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.Reservations.Models
{
    /// <summary> The ChangeDirectoryRequest. </summary>
    public partial class ChangeDirectoryContent
    {
        /// <summary> Initializes a new instance of ChangeDirectoryContent. </summary>
        public ChangeDirectoryContent()
        {
        }

        /// <summary> Tenant id GUID that reservation order is to be transferred to. </summary>
        public string DestinationTenantId { get; set; }
    }
}
