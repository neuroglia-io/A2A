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

namespace Neuroglia.A2A.Requests;

/// <summary>
/// Represents the request used to create, continue or restart a task
/// </summary>
[DataContract]
public record SendTaskRequest
    : RpcRequest<TaskSendParameters>
{

    /// <inheritdoc/>
    public override string Method { get; } = "tasks/send";

}
