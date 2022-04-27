// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.Reservations.Models
{
    /// <summary> The Error. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="errorValue"></param>
        internal Error(ExtendedErrorInfo errorValue)
        {
            ErrorValue = errorValue;
        }

        /// <summary> Gets the error value. </summary>
        public ExtendedErrorInfo ErrorValue { get; }
    }
}
