/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetRelationalDatabaseSnapshots operation.
    /// </summary>
    public partial class GetRelationalDatabaseSnapshotsResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private List<RelationalDatabaseSnapshot> _relationalDatabaseSnapshots = new List<RelationalDatabaseSnapshot>();

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to advance to the next page of resutls from your request.
        /// </para>
        ///  
        /// <para>
        /// A next page token is not returned if there are no more results to display.
        /// </para>
        ///  
        /// <para>
        /// To get the next page of results, perform another <code>GetRelationalDatabaseSnapshots</code>
        /// request and specify the next page token using the <code>pageToken</code> parameter.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseSnapshots. 
        /// <para>
        /// An object describing the result of your get relational database snapshots request.
        /// </para>
        /// </summary>
        public List<RelationalDatabaseSnapshot> RelationalDatabaseSnapshots
        {
            get { return this._relationalDatabaseSnapshots; }
            set { this._relationalDatabaseSnapshots = value; }
        }

        // Check to see if RelationalDatabaseSnapshots property is set
        internal bool IsSetRelationalDatabaseSnapshots()
        {
            return this._relationalDatabaseSnapshots != null && this._relationalDatabaseSnapshots.Count > 0; 
        }

    }
}