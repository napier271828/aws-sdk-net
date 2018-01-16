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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceHealth operation.
    /// Describes the state of the specified instances with respect to the specified load
    /// balancer. If no instances are specified, the call describes the state of all instances
    /// that are currently registered with the load balancer. If instances are specified,
    /// their state is returned even if they are no longer registered with the load balancer.
    /// The state of terminated instances is not returned.
    /// </summary>
    public partial class DescribeInstanceHealthRequest : AmazonElasticLoadBalancingRequest
    {
        private List<Instance> _instances = new List<Instance>();
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeInstanceHealthRequest() { }

        /// <summary>
        /// Instantiates DescribeInstanceHealthRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        public DescribeInstanceHealthRequest(string loadBalancerName)
        {
            _loadBalancerName = loadBalancerName;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The IDs of the instances.
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

    }
}