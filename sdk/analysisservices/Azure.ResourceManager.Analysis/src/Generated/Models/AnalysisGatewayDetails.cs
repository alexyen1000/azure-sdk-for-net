// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> The gateway details. </summary>
    public partial class AnalysisGatewayDetails
    {
        /// <summary> Initializes a new instance of AnalysisGatewayDetails. </summary>
        public AnalysisGatewayDetails()
        {
        }

        /// <summary> Initializes a new instance of AnalysisGatewayDetails. </summary>
        /// <param name="gatewayResourceId"> Gateway resource to be associated with the server. </param>
        /// <param name="gatewayObjectId"> Gateway object id from in the DMTS cluster for the gateway resource. </param>
        /// <param name="dmtsClusterUri"> Uri of the DMTS cluster. </param>
        internal AnalysisGatewayDetails(string gatewayResourceId, string gatewayObjectId, Uri dmtsClusterUri)
        {
            GatewayResourceId = gatewayResourceId;
            GatewayObjectId = gatewayObjectId;
            DmtsClusterUri = dmtsClusterUri;
        }

        /// <summary> Gateway resource to be associated with the server. </summary>
        public string GatewayResourceId { get; set; }
        /// <summary> Gateway object id from in the DMTS cluster for the gateway resource. </summary>
        public string GatewayObjectId { get; }
        /// <summary> Uri of the DMTS cluster. </summary>
        public Uri DmtsClusterUri { get; }
    }
}
