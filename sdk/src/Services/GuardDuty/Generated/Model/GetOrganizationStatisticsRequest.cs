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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetOrganizationStatistics operation.
    /// Retrieves how many active member accounts in your Amazon Web Services organization
    /// have each feature enabled within GuardDuty. Only a delegated GuardDuty administrator
    /// of an organization can run this API.
    /// 
    ///  
    /// <para>
    /// When you create a new Amazon Web Services organization, it might take up to 24 hours
    /// to generate the statistics for the entire organization.
    /// </para>
    /// </summary>
    public partial class GetOrganizationStatisticsRequest : AmazonGuardDutyRequest
    {

    }
}