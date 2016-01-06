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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDevicePoolCompatibility operation
    /// </summary>  
    public class GetDevicePoolCompatibilityResponseUnmarshaller : JsonResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetDevicePoolCompatibilityResponse response = new GetDevicePoolCompatibilityResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("compatibleDevices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DevicePoolCompatibilityResult, DevicePoolCompatibilityResultUnmarshaller>(DevicePoolCompatibilityResultUnmarshaller.Instance);
                    response.CompatibleDevices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("incompatibleDevices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DevicePoolCompatibilityResult, DevicePoolCompatibilityResultUnmarshaller>(DevicePoolCompatibilityResultUnmarshaller.Instance);
                    response.IncompatibleDevices = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("ArgumentException"))
            {
                return new ArgumentException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
            {
                return new LimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
            {
                return new NotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceAccountException"))
            {
                return new ServiceAccountException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonDeviceFarmException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetDevicePoolCompatibilityResponseUnmarshaller _instance = new GetDevicePoolCompatibilityResponseUnmarshaller();        

        internal static GetDevicePoolCompatibilityResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static GetDevicePoolCompatibilityResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}