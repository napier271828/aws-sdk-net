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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComparedFace Object
    /// </summary>  
    public class ComparedFaceUnmarshaller : IUnmarshaller<ComparedFace, XmlUnmarshallerContext>, IUnmarshaller<ComparedFace, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ComparedFace IUnmarshaller<ComparedFace, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ComparedFace Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ComparedFace unmarshalledObject = new ComparedFace();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BoundingBox", targetDepth))
                {
                    var unmarshaller = BoundingBoxUnmarshaller.Instance;
                    unmarshalledObject.BoundingBox = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Confidence", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Landmarks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Landmark, LandmarkUnmarshaller>(LandmarkUnmarshaller.Instance);
                    unmarshalledObject.Landmarks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Pose", targetDepth))
                {
                    var unmarshaller = PoseUnmarshaller.Instance;
                    unmarshalledObject.Pose = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Quality", targetDepth))
                {
                    var unmarshaller = ImageQualityUnmarshaller.Instance;
                    unmarshalledObject.Quality = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ComparedFaceUnmarshaller _instance = new ComparedFaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComparedFaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}