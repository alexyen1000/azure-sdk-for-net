// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List resources which are encrypted with the disk encryption set. </summary>
    internal partial class ResourceUriList
    {
        /// <summary> Initializes a new instance of ResourceUriList. </summary>
        /// <param name="value"> A list of IDs or Owner IDs of resources which are encrypted with the disk encryption set. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ResourceUriList(IEnumerable<string> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ResourceUriList. </summary>
        /// <param name="value"> A list of IDs or Owner IDs of resources which are encrypted with the disk encryption set. </param>
        /// <param name="nextLink"> The uri to fetch the next page of encrypted resources. Call ListNext() with this to fetch the next page of encrypted resources. </param>
        internal ResourceUriList(IReadOnlyList<string> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of IDs or Owner IDs of resources which are encrypted with the disk encryption set. </summary>
        public IReadOnlyList<string> Value { get; }
        /// <summary> The uri to fetch the next page of encrypted resources. Call ListNext() with this to fetch the next page of encrypted resources. </summary>
        public string NextLink { get; }
    }
}
