// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class ClientScriptForConnect
    {
        internal static ClientScriptForConnect DeserializeClientScriptForConnect(JsonElement element)
        {
            Optional<string> scriptContent = default;
            Optional<string> scriptExtension = default;
            Optional<string> osType = default;
            Optional<Uri> url = default;
            Optional<string> scriptNameSuffix = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scriptContent"u8))
                {
                    scriptContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptExtension"u8))
                {
                    scriptExtension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scriptNameSuffix"u8))
                {
                    scriptNameSuffix = property.Value.GetString();
                    continue;
                }
            }
            return new ClientScriptForConnect(scriptContent.Value, scriptExtension.Value, osType.Value, url.Value, scriptNameSuffix.Value);
        }
    }
}
