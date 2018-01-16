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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Represents the returned data in response to a request action.
    /// </summary>
    public partial class CreateFleetResponse : AmazonWebServiceResponse
    {
        private FleetAttributes _fleetAttributes;

        /// <summary>
        /// Gets and sets the property FleetAttributes. 
        /// <para>
        /// Properties for the newly created fleet.
        /// </para>
        /// </summary>
        public FleetAttributes FleetAttributes
        {
            get { return this._fleetAttributes; }
            set { this._fleetAttributes = value; }
        }

        // Check to see if FleetAttributes property is set
        internal bool IsSetFleetAttributes()
        {
            return this._fleetAttributes != null;
        }

    }
}