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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListFunctions Request Marshaller
    /// </summary>       
    public class ListFunctionsRequestMarshaller : IMarshaller<IRequest, ListFunctionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListFunctionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListFunctionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.HttpMethod = "GET";

            string uriResourcePath = "/2015-03-31/functions/";
            
            if (publicRequest.IsSetFunctionVersion())
                request.Parameters.Add("FunctionVersion", StringUtils.FromString(publicRequest.FunctionVersion));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMasterRegion())
                request.Parameters.Add("MasterRegion", StringUtils.FromString(publicRequest.MasterRegion));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }


    }
}