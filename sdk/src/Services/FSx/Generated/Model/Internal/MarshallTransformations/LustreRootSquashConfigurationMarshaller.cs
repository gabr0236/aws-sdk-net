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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LustreRootSquashConfiguration Marshaller
    /// </summary>
    public class LustreRootSquashConfigurationMarshaller : IRequestMarshaller<LustreRootSquashConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LustreRootSquashConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetNoSquashNids())
            {
                context.Writer.WritePropertyName("NoSquashNids");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNoSquashNidsListValue in requestObject.NoSquashNids)
                {
                        context.Writer.Write(requestObjectNoSquashNidsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRootSquash())
            {
                context.Writer.WritePropertyName("RootSquash");
                context.Writer.Write(requestObject.RootSquash);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LustreRootSquashConfigurationMarshaller Instance = new LustreRootSquashConfigurationMarshaller();

    }
}