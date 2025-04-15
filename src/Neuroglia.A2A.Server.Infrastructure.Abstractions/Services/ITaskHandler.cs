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

namespace Neuroglia.A2A.Server.Infrastructure.Services;

/// <summary>
/// Defines the fundamentals of a service used to handle tasks
/// </summary>
public interface ITaskHandler
{

    /// <summary>
    /// Submits the specified task
    /// </summary>
    /// <param name="task">The task to submit</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken"/></param>
    /// <returns>The submitted task</returns>
    Task<TaskRecord> SubmitAsync(TaskRecord task, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cancels the specified task
    /// </summary>
    /// <param name="task">The task to cancel</param>
    /// <param name="message">A message, if any, associated with the task's cancellation</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken"/></param>
    /// <returns>The cancelled task</returns>
    Task<TaskRecord> CancelAsync(TaskRecord task, Message? message = null, CancellationToken cancellationToken = default);

}
