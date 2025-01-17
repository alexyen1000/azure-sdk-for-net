// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryPoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static RecoveryPoint DeserializeRecoveryPoint(JsonElement element)
        {
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShareRecoveryPoint": return AzureFileShareRecoveryPoint.DeserializeAzureFileShareRecoveryPoint(element);
                    case "AzureWorkloadPointInTimeRecoveryPoint": return AzureWorkloadPointInTimeRecoveryPoint.DeserializeAzureWorkloadPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadRecoveryPoint": return AzureWorkloadRecoveryPoint.DeserializeAzureWorkloadRecoveryPoint(element);
                    case "AzureWorkloadSAPHanaPointInTimeRecoveryPoint": return AzureWorkloadSAPHanaPointInTimeRecoveryPoint.DeserializeAzureWorkloadSAPHanaPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadSAPHanaRecoveryPoint": return AzureWorkloadSAPHanaRecoveryPoint.DeserializeAzureWorkloadSAPHanaRecoveryPoint(element);
                    case "AzureWorkloadSQLPointInTimeRecoveryPoint": return AzureWorkloadSQLPointInTimeRecoveryPoint.DeserializeAzureWorkloadSQLPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadSQLRecoveryPoint": return AzureWorkloadSQLRecoveryPoint.DeserializeAzureWorkloadSQLRecoveryPoint(element);
                    case "GenericRecoveryPoint": return GenericRecoveryPoint.DeserializeGenericRecoveryPoint(element);
                    case "IaasVMRecoveryPoint": return IaasVmRecoveryPoint.DeserializeIaasVmRecoveryPoint(element);
                }
            }
            return UnknownRecoveryPoint.DeserializeUnknownRecoveryPoint(element);
        }
    }
}
