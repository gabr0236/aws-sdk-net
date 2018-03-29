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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutScalingPolicy Request Marshaller
    /// </summary>       
    public class PutScalingPolicyRequestMarshaller : IMarshaller<IRequest, PutScalingPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutScalingPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutScalingPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.PutScalingPolicy";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComparisonOperator())
                {
                    context.Writer.WritePropertyName("ComparisonOperator");
                    context.Writer.Write(publicRequest.ComparisonOperator);
                }

                if(publicRequest.IsSetEvaluationPeriods())
                {
                    context.Writer.WritePropertyName("EvaluationPeriods");
                    context.Writer.Write(publicRequest.EvaluationPeriods);
                }

                if(publicRequest.IsSetFleetId())
                {
                    context.Writer.WritePropertyName("FleetId");
                    context.Writer.Write(publicRequest.FleetId);
                }

                if(publicRequest.IsSetMetricName())
                {
                    context.Writer.WritePropertyName("MetricName");
                    context.Writer.Write(publicRequest.MetricName);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetScalingAdjustment())
                {
                    context.Writer.WritePropertyName("ScalingAdjustment");
                    context.Writer.Write(publicRequest.ScalingAdjustment);
                }

                if(publicRequest.IsSetScalingAdjustmentType())
                {
                    context.Writer.WritePropertyName("ScalingAdjustmentType");
                    context.Writer.Write(publicRequest.ScalingAdjustmentType);
                }

                if(publicRequest.IsSetThreshold())
                {
                    context.Writer.WritePropertyName("Threshold");
                    context.Writer.Write(publicRequest.Threshold);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutScalingPolicyRequestMarshaller _instance = new PutScalingPolicyRequestMarshaller();        

        internal static PutScalingPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutScalingPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}