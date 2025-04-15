﻿// Copyright � 2025-Present Neuroglia SRL
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Neuroglia.A2A;

/// <summary>
/// Represents the base class for all A2A RPC messages
/// </summary>
public abstract record RpcMessage
{

    /// <summary>
    /// Gets/sets the JSON RPC version to use
    /// </summary>
    [Required, AllowedValues(JsonRpcVersion.V2), DefaultValue(JsonRpcVersion.V2)]
    [DataMember(Name = "jsonrpc", Order = 0), JsonPropertyName("jsonrpc"), JsonPropertyOrder(0), YamlMember(Alias = "jsonrpc", Order = 0)]
    public virtual string JsonRpc { get; set; } = JsonRpcVersion.V2;

    /// <summary>
    /// Gets/sets the message's unique identifier
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "id", Order = 1), JsonPropertyName("id"), JsonPropertyOrder(1), YamlMember(Alias = "id", Order = 1)]
    public virtual string Id { get; set; } = null!;

}