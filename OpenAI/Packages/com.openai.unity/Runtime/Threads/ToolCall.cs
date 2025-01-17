// Licensed under the MIT License. See LICENSE in the project root for license information.

using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace OpenAI.Threads
{
    [Preserve]
    public sealed class ToolCall
    {
        [Preserve]
        [JsonConstructor]
        public ToolCall(
            [JsonProperty("id")] string id,
            [JsonProperty("type")] string type,
            [JsonProperty("function")] FunctionCall functionCall)
        {
            Id = id;
            Type = type;
            FunctionCall = functionCall;
        }

        /// <summary>
        /// The ID of the tool call.
        /// This ID must be referenced when you submit the tool outputs in using the Submit tool outputs to run endpoint.
        /// </summary>
        [Preserve]
        [JsonProperty("id")]
        public string Id { get; }

        /// <summary>
        /// The type of tool call the output is required for. For now, this is always 'function'.
        /// </summary>
        [Preserve]
        [JsonProperty("type")]
        public string Type { get; }

        /// <summary>
        /// The function definition.
        /// </summary>
        [Preserve]
        [JsonProperty("function")]
        public FunctionCall FunctionCall { get; }
    }
}
