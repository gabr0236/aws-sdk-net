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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGeneratedTemplate operation.
    /// Creates a template from existing resources that are not already managed with CloudFormation.
    /// You can check the status of the template generation using the <c>DescribeGeneratedTemplate</c>
    /// API action.
    /// </summary>
    public partial class CreateGeneratedTemplateRequest : AmazonCloudFormationRequest
    {
        private string _generatedTemplateName;
        private List<ResourceDefinition> _resources = new List<ResourceDefinition>();
        private string _stackName;
        private TemplateConfiguration _templateConfiguration;

        /// <summary>
        /// Gets and sets the property GeneratedTemplateName. 
        /// <para>
        /// The name assigned to the generated template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GeneratedTemplateName
        {
            get { return this._generatedTemplateName; }
            set { this._generatedTemplateName = value; }
        }

        // Check to see if GeneratedTemplateName property is set
        internal bool IsSetGeneratedTemplateName()
        {
            return this._generatedTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// An optional list of resources to be included in the generated template.
        /// </para>
        ///  
        /// <para>
        ///  If no resources are specified,the template will be created without any resources.
        /// Resources can be added to the template using the <c>UpdateGeneratedTemplate</c> API
        /// action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<ResourceDefinition> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// An optional name or ARN of a stack to use as the base stack for the generated template.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The configuration details of the generated template, including the <c>DeletionPolicy</c>
        /// and <c>UpdateReplacePolicy</c>.
        /// </para>
        /// </summary>
        public TemplateConfiguration TemplateConfiguration
        {
            get { return this._templateConfiguration; }
            set { this._templateConfiguration = value; }
        }

        // Check to see if TemplateConfiguration property is set
        internal bool IsSetTemplateConfiguration()
        {
            return this._templateConfiguration != null;
        }

    }
}