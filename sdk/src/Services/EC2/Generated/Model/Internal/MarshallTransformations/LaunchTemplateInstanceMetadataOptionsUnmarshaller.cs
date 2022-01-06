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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LaunchTemplateInstanceMetadataOptions Object
    /// </summary>  
    public class LaunchTemplateInstanceMetadataOptionsUnmarshaller : IUnmarshaller<LaunchTemplateInstanceMetadataOptions, XmlUnmarshallerContext>, IUnmarshaller<LaunchTemplateInstanceMetadataOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LaunchTemplateInstanceMetadataOptions Unmarshall(XmlUnmarshallerContext context)
        {
            LaunchTemplateInstanceMetadataOptions unmarshalledObject = new LaunchTemplateInstanceMetadataOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("httpEndpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HttpEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("httpProtocolIpv6", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HttpProtocolIpv6 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("httpPutResponseHopLimit", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.HttpPutResponseHopLimit = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("httpTokens", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HttpTokens = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceMetadataTags", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceMetadataTags = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LaunchTemplateInstanceMetadataOptions Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static LaunchTemplateInstanceMetadataOptionsUnmarshaller _instance = new LaunchTemplateInstanceMetadataOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LaunchTemplateInstanceMetadataOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}