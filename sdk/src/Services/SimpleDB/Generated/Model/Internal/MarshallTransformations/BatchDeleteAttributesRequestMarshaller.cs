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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchDeleteAttributes Request Marshaller
    /// </summary>       
    public class BatchDeleteAttributesRequestMarshaller : IMarshaller<IRequest, BatchDeleteAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDeleteAttributesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchDeleteAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleDB");
            request.Parameters.Add("Action", "BatchDeleteAttributes");
            request.Parameters.Add("Version", "2009-04-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
                if(publicRequest.IsSetItems())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Items)
                    {
                        if(publicRequestlistValue.IsSetAttributes())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Attributes)
                            {
                                if(publicRequestlistValuelistValue.IsSetAlternateNameEncoding())
                                {
                                    request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "Attribute" + "." + publicRequestlistValuelistValueIndex + "." + "AlternateNameEncoding", StringUtils.FromString(publicRequestlistValuelistValue.AlternateNameEncoding));
                                }
                                if(publicRequestlistValuelistValue.IsSetAlternateValueEncoding())
                                {
                                    request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "Attribute" + "." + publicRequestlistValuelistValueIndex + "." + "AlternateValueEncoding", StringUtils.FromString(publicRequestlistValuelistValue.AlternateValueEncoding));
                                }
                                if(publicRequestlistValuelistValue.IsSetName())
                                {
                                    request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "Attribute" + "." + publicRequestlistValuelistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValuelistValue.Name));
                                }
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "Attribute" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetName())
                        {
                            request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "ItemName", StringUtils.FromString(publicRequestlistValue.Name));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
    }
}