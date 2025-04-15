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

namespace Neuroglia.A2A.Models;

/// <summary>
/// Represents a file part
/// </summary>
[DataContract]
public record FilePart
    : Part
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Type => PartType.File;

    /// <summary>
    /// Gets/sets the part's text
    /// </summary>
    [Required]
    [DataMember(Name = "file", Order = 1), JsonPropertyName("file"), JsonPropertyOrder(1), YamlMember(Alias = "file", Order = 1)]
    public virtual File File { get; set; } = null!;

}
