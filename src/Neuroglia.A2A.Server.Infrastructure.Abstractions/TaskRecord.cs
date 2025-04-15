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

namespace Neuroglia.A2A.Server.Infrastructure;

/// <summary>
/// Represents the internal record of a task, extending the protocol-level task definition with additional runtime information such as push notification configuration
/// </summary>
[DataContract]
public record TaskRecord
    : Models.Task
{

    /// <summary>
    /// Gets/sets the push notification configuration associated with the task, used to notify external systems about task updates
    /// </summary>
    [DataMember(Name = "notifications", Order = 5), JsonPropertyName("notifications"), JsonPropertyOrder(5), YamlMember(Alias = "notifications", Order = 5)]
    public virtual PushNotificationConfiguration? Notifications { get; set; }

}
