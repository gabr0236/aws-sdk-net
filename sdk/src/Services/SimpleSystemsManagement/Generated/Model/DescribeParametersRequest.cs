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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeParameters operation.
    /// Get information about a parameter.
    /// 
    ///  
    /// <para>
    /// Request results are returned on a best-effort basis. If you specify <c>MaxResults</c>
    /// in the request, the response includes information up to the limit specified. The number
    /// of items returned, however, can be between zero and the value of <c>MaxResults</c>.
    /// If the service reaches an internal limit while processing the results, it stops the
    /// operation and returns the matching values up to that point and a <c>NextToken</c>.
    /// You can specify the <c>NextToken</c> in a subsequent call to get the next set of results.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you change the KMS key alias for the KMS key used to encrypt a parameter, then
    /// you must also update the key alias the parameter uses to reference KMS. Otherwise,
    /// <c>DescribeParameters</c> retrieves whatever the original key alias was referencing.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DescribeParametersRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<ParametersFilter> _filters = new List<ParametersFilter>();
        private int? _maxResults;
        private string _nextToken;
        private List<ParameterStringFilter> _parameterFilters = new List<ParameterStringFilter>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This data type is deprecated. Instead, use <c>ParameterFilters</c>.
        /// </para>
        /// </summary>
        public List<ParametersFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterFilters. 
        /// <para>
        /// Filters to limit the request results.
        /// </para>
        /// </summary>
        public List<ParameterStringFilter> ParameterFilters
        {
            get { return this._parameterFilters; }
            set { this._parameterFilters = value; }
        }

        // Check to see if ParameterFilters property is set
        internal bool IsSetParameterFilters()
        {
            return this._parameterFilters != null && this._parameterFilters.Count > 0; 
        }

    }
}