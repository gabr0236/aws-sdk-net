/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Generate response part
    /// </summary>
    public partial class GeneratedResponsePart
    {
        private TextResponsePart _textResponsePart;

        /// <summary>
        /// Gets and sets the property TextResponsePart.
        /// </summary>
        public TextResponsePart TextResponsePart
        {
            get { return this._textResponsePart; }
            set { this._textResponsePart = value; }
        }

        // Check to see if TextResponsePart property is set
        internal bool IsSetTextResponsePart()
        {
            return this._textResponsePart != null;
        }

    }
}