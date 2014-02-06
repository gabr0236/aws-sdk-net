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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The StackSummary Data Type</para>
    /// </summary>
    public class StackSummary
    {
        
        private string stackId;
        private string stackName;
        private string templateDescription;
        private DateTime? creationTime;
        private DateTime? lastUpdatedTime;
        private DateTime? deletionTime;
        private StackStatus stackStatus;
        private string stackStatusReason;


        /// <summary>
        /// Unique stack identifier.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The name associated with the stack.
        ///  
        /// </summary>
        public string StackName
        {
            get { return this.stackName; }
            set { this.stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this.stackName != null;
        }

        /// <summary>
        /// The template description of the template used to create the stack.
        ///  
        /// </summary>
        public string TemplateDescription
        {
            get { return this.templateDescription; }
            set { this.templateDescription = value; }
        }

        // Check to see if TemplateDescription property is set
        internal bool IsSetTemplateDescription()
        {
            return this.templateDescription != null;
        }

        /// <summary>
        /// The time the stack was created.
        ///  
        /// </summary>
        public DateTime CreationTime
        {
            get { return this.creationTime ?? default(DateTime); }
            set { this.creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this.creationTime.HasValue;
        }

        /// <summary>
        /// The time the stack was last updated. This field will only be returned if the stack has been updated at least once.
        ///  
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this.lastUpdatedTime ?? default(DateTime); }
            set { this.lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this.lastUpdatedTime.HasValue;
        }

        /// <summary>
        /// The time the stack was deleted.
        ///  
        /// </summary>
        public DateTime DeletionTime
        {
            get { return this.deletionTime ?? default(DateTime); }
            set { this.deletionTime = value; }
        }

        // Check to see if DeletionTime property is set
        internal bool IsSetDeletionTime()
        {
            return this.deletionTime.HasValue;
        }

        /// <summary>
        /// The current status of the stack.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CREATE_IN_PROGRESS, CREATE_FAILED, CREATE_COMPLETE, ROLLBACK_IN_PROGRESS, ROLLBACK_FAILED, ROLLBACK_COMPLETE, DELETE_IN_PROGRESS, DELETE_FAILED, DELETE_COMPLETE, UPDATE_IN_PROGRESS, UPDATE_COMPLETE_CLEANUP_IN_PROGRESS, UPDATE_COMPLETE, UPDATE_ROLLBACK_IN_PROGRESS, UPDATE_ROLLBACK_FAILED, UPDATE_ROLLBACK_COMPLETE_CLEANUP_IN_PROGRESS, UPDATE_ROLLBACK_COMPLETE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StackStatus StackStatus
        {
            get { return this.stackStatus; }
            set { this.stackStatus = value; }
        }

        // Check to see if StackStatus property is set
        internal bool IsSetStackStatus()
        {
            return this.stackStatus != null;
        }

        /// <summary>
        /// Success/Failure message associated with the stack status.
        ///  
        /// </summary>
        public string StackStatusReason
        {
            get { return this.stackStatusReason; }
            set { this.stackStatusReason = value; }
        }

        // Check to see if StackStatusReason property is set
        internal bool IsSetStackStatusReason()
        {
            return this.stackStatusReason != null;
        }
    }
}
