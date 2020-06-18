// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayUrlPathMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (DefaultBackendAddressPool != null)
            {
                writer.WritePropertyName("defaultBackendAddressPool");
                writer.WriteObjectValue(DefaultBackendAddressPool);
            }
            if (DefaultBackendHttpSettings != null)
            {
                writer.WritePropertyName("defaultBackendHttpSettings");
                writer.WriteObjectValue(DefaultBackendHttpSettings);
            }
            if (DefaultRewriteRuleSet != null)
            {
                writer.WritePropertyName("defaultRewriteRuleSet");
                writer.WriteObjectValue(DefaultRewriteRuleSet);
            }
            if (DefaultRedirectConfiguration != null)
            {
                writer.WritePropertyName("defaultRedirectConfiguration");
                writer.WriteObjectValue(DefaultRedirectConfiguration);
            }
            if (PathRules != null)
            {
                writer.WritePropertyName("pathRules");
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayUrlPathMap DeserializeApplicationGatewayUrlPathMap(JsonElement element)
        {
            string name = default;
            string etag = default;
            string type = default;
            string id = default;
            SubResource defaultBackendAddressPool = default;
            SubResource defaultBackendHttpSettings = default;
            SubResource defaultRewriteRuleSet = default;
            SubResource defaultRedirectConfiguration = default;
            IList<ApplicationGatewayPathRule> pathRules = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultBackendAddressPool"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultBackendAddressPool = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultBackendHttpSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultBackendHttpSettings = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultRewriteRuleSet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultRewriteRuleSet = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultRedirectConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultRedirectConfiguration = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("pathRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationGatewayPathRule> array = new List<ApplicationGatewayPathRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ApplicationGatewayPathRule.DeserializeApplicationGatewayPathRule(item));
                                }
                            }
                            pathRules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayUrlPathMap(id, name, etag, type, defaultBackendAddressPool, defaultBackendHttpSettings, defaultRewriteRuleSet, defaultRedirectConfiguration, pathRules, provisioningState);
        }
    }
}