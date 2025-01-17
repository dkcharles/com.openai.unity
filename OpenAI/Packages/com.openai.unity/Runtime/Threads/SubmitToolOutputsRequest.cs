// Licensed under the MIT License. See LICENSE in the project root for license information.

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;

namespace OpenAI.Threads
{
    [Preserve]
    public sealed class SubmitToolOutputsRequest
    {
        /// <summary>
        /// Tool output to be submitted.
        /// </summary>
        /// <param name="toolOutput"><see cref="ToolOutput"/>.</param>
        [Preserve]
        public SubmitToolOutputsRequest(ToolOutput toolOutput)
            : this(new[] { toolOutput })
        {
        }

        /// <summary>
        /// A list of tools for which the outputs are being submitted.
        /// </summary>
        /// <param name="toolOutputs">Collection of tools for which the outputs are being submitted.</param>
        [Preserve]
        [JsonConstructor]
        public SubmitToolOutputsRequest(
            [JsonProperty("tool_outputs")] IEnumerable<ToolOutput> toolOutputs)
        {
            ToolOutputs = toolOutputs?.ToList();
        }

        /// <summary>
        /// A list of tools for which the outputs are being submitted.
        /// </summary>
        [Preserve]
        [JsonProperty("tool_outputs")]
        public IReadOnlyList<ToolOutput> ToolOutputs { get; }

        [Preserve]
        public static implicit operator SubmitToolOutputsRequest(ToolOutput toolOutput) => new SubmitToolOutputsRequest(toolOutput);
    }
}
