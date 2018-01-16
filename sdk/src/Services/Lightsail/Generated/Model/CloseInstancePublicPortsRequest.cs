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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CloseInstancePublicPorts operation.
    /// Closes the public ports on a specific Amazon Lightsail instance.
    /// </summary>
    public partial class CloseInstancePublicPortsRequest : AmazonLightsailRequest
    {
        private string _instanceName;
        private PortInfo _portInfo;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance on which you're attempting to close the public ports.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property PortInfo. 
        /// <para>
        /// Information about the public port you are trying to close.
        /// </para>
        /// </summary>
        public PortInfo PortInfo
        {
            get { return this._portInfo; }
            set { this._portInfo = value; }
        }

        // Check to see if PortInfo property is set
        internal bool IsSetPortInfo()
        {
            return this._portInfo != null;
        }

    }
}