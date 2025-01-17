// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningUserAccountCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("adminUserName"u8);
            writer.WriteStringValue(AdminUserName);
            if (Optional.IsDefined(AdminUserSshPublicKey))
            {
                writer.WritePropertyName("adminUserSshPublicKey"u8);
                writer.WriteStringValue(AdminUserSshPublicKey);
            }
            if (Optional.IsDefined(AdminUserPassword))
            {
                writer.WritePropertyName("adminUserPassword"u8);
                writer.WriteStringValue(AdminUserPassword);
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningUserAccountCredentials DeserializeMachineLearningUserAccountCredentials(JsonElement element)
        {
            string adminUserName = default;
            Optional<string> adminUserSshPublicKey = default;
            Optional<string> adminUserPassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUserName"u8))
                {
                    adminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUserSshPublicKey"u8))
                {
                    adminUserSshPublicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminUserPassword"u8))
                {
                    adminUserPassword = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningUserAccountCredentials(adminUserName, adminUserSshPublicKey.Value, adminUserPassword.Value);
        }
    }
}
