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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An object that contains a list of permissions to be applied to a list of analysis
    /// IDs.
    /// </summary>
    public partial class AssetBundleImportJobAnalysisOverridePermissions
    {
        private List<string> _analysisIds = new List<string>();
        private AssetBundleResourcePermissions _permissions;

        /// <summary>
        /// Gets and sets the property AnalysisIds. 
        /// <para>
        /// A list of analysis IDs that you want to apply overrides to. You can use <c>*</c> to
        /// override all analyses in this asset bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> AnalysisIds
        {
            get { return this._analysisIds; }
            set { this._analysisIds = value; }
        }

        // Check to see if AnalysisIds property is set
        internal bool IsSetAnalysisIds()
        {
            return this._analysisIds != null && this._analysisIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A list of permissions for the analyses that you want to apply overrides to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetBundleResourcePermissions Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null;
        }

    }
}