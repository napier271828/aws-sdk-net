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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateScalingParameters Request Marshaller
    /// </summary>       
    public class UpdateScalingParametersRequestMarshaller : IMarshaller<IRequest, UpdateScalingParametersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateScalingParametersRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateScalingParametersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearch");
            request.Parameters.Add("Action", "UpdateScalingParameters");
            request.Parameters.Add("Version", "2013-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
                if(publicRequest.IsSetScalingParameters())
                {
                    if(publicRequest.ScalingParameters.IsSetDesiredInstanceType())
                    {
                        request.Parameters.Add("ScalingParameters" + "." + "DesiredInstanceType", StringUtils.FromString(publicRequest.ScalingParameters.DesiredInstanceType));
                    }
                    if(publicRequest.ScalingParameters.IsSetDesiredPartitionCount())
                    {
                        request.Parameters.Add("ScalingParameters" + "." + "DesiredPartitionCount", StringUtils.FromInt(publicRequest.ScalingParameters.DesiredPartitionCount));
                    }
                    if(publicRequest.ScalingParameters.IsSetDesiredReplicationCount())
                    {
                        request.Parameters.Add("ScalingParameters" + "." + "DesiredReplicationCount", StringUtils.FromInt(publicRequest.ScalingParameters.DesiredReplicationCount));
                    }
                }
            }
            return request;
        }
    }
}