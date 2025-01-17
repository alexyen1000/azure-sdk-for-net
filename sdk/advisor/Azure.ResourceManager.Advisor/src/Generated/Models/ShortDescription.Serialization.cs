// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Advisor.Models
{
    public partial class ShortDescription : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Problem))
            {
                writer.WritePropertyName("problem"u8);
                writer.WriteStringValue(Problem);
            }
            if (Optional.IsDefined(Solution))
            {
                writer.WritePropertyName("solution"u8);
                writer.WriteStringValue(Solution);
            }
            writer.WriteEndObject();
        }

        internal static ShortDescription DeserializeShortDescription(JsonElement element)
        {
            Optional<string> problem = default;
            Optional<string> solution = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("problem"u8))
                {
                    problem = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("solution"u8))
                {
                    solution = property.Value.GetString();
                    continue;
                }
            }
            return new ShortDescription(problem.Value, solution.Value);
        }
    }
}
