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
    /// Container for the parameters to the UpdateRuntimeConfiguration operation.
    /// Updates the current run-time configuration for the specified fleet, which tells Amazon
    /// GameLift how to launch server processes on instances in the fleet. You can update
    /// a fleet's run-time configuration at any time after the fleet is created; it does not
    /// need to be in an <code>ACTIVE</code> status.
    /// 
    ///  
    /// <para>
    /// To update run-time configuration, specify the fleet ID and provide a <code>RuntimeConfiguration</code>
    /// object with the updated collection of server process configurations.
    /// </para>
    ///  
    /// <para>
    /// Each instance in a Amazon GameLift fleet checks regularly for an updated run-time
    /// configuration and changes how it launches server processes to comply with the latest
    /// version. Existing server processes are not affected by the update; they continue to
    /// run until they end, while Amazon GameLift simply adds new server processes to fit
    /// the current run-time configuration. As a result, the run-time configuration changes
    /// are applied gradually as existing processes shut down and new processes are launched
    /// in Amazon GameLift's normal process recycling activity.
    /// </para>
    ///  
    /// <para>
    /// Fleet-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFleets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Describe fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetUtilization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeRuntimeConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetEvents</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Update fleets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>UpdateFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetPortSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRuntimeConfiguration</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Manage fleet capacity:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetCapacity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutScalingPolicy</a> (automatic scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScalingPolicies</a> (automatic scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScalingPolicy</a> (automatic scaling)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeEC2InstanceLimits</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a>DeleteFleet</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateRuntimeConfigurationRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private RuntimeConfiguration _runtimeConfiguration;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet to update run-time configuration for.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// Instructions for launching server processes on each instance in the fleet. The run-time
        /// configuration for a fleet has a collection of server process configurations, one for
        /// each type of server process to run on an instance. A server process configuration
        /// specifies the location of the server executable, launch parameters, and the number
        /// of concurrent processes with that configuration to maintain on each instance.
        /// </para>
        /// </summary>
        public RuntimeConfiguration RuntimeConfiguration
        {
            get { return this._runtimeConfiguration; }
            set { this._runtimeConfiguration = value; }
        }

        // Check to see if RuntimeConfiguration property is set
        internal bool IsSetRuntimeConfiguration()
        {
            return this._runtimeConfiguration != null;
        }

    }
}