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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// This is the response object from the VerifyResourcesExistForTagris operation.
    /// </summary>
    public partial class VerifyResourcesExistForTagrisResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _tagrisSweepListResult = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property TagrisSweepListResult.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> TagrisSweepListResult
        {
            get { return this._tagrisSweepListResult; }
            set { this._tagrisSweepListResult = value; }
        }

        // Check to see if TagrisSweepListResult property is set
        internal bool IsSetTagrisSweepListResult()
        {
            return this._tagrisSweepListResult != null && this._tagrisSweepListResult.Count > 0; 
        }

    }
}