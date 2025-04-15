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

using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Options;

namespace Neuroglia.A2A.IntegrationTests.Services;

internal class JsonRpcTestWebSocketTransportFactory(WebSocketClient client, IOptions<JsonRpcWebSocketTransportFactoryOptions> options, IJsonRpcMessageFormatter jsonRpcMessageFormatter)
    : IJsonRpcTransportFactory
{

    protected JsonRpcWebSocketTransportFactoryOptions Options { get; } = options.Value;

    protected IJsonRpcMessageFormatter JsonRpcMessageFormatter { get; } = jsonRpcMessageFormatter;

    protected WebSocketClient Client { get; } = client;

    public virtual async Task<JsonRpc> CreateAsync(CancellationToken cancellationToken = default)
    {
        var socket = await Client.ConnectAsync(Options.Endpoint, cancellationToken).ConfigureAwait(false);
        return new(new WebSocketMessageHandler(socket, JsonRpcMessageFormatter));
    }

}