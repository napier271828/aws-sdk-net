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
    /// Container for the parameters to the GetLoadBalancerMetricData operation.
    /// Returns information about health metrics for your Lightsail load balancer.
    /// </summary>
    public partial class GetLoadBalancerMetricDataRequest : AmazonLightsailRequest
    {
        private DateTime? _endTime;
        private string _loadBalancerName;
        private LoadBalancerMetricName _metricName;
        private int? _period;
        private DateTime? _startTime;
        private List<string> _statistics = new List<string>();
        private MetricUnit _unit;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the period.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
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

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric about which you want to return information. Valid values are listed below,
        /// along with the most useful <code>statistics</code> to include in your request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>ClientTLSNegotiationErrorCount</code> </b> - The number of TLS connections
        /// initiated by the client that did not establish a session with the load balancer. Possible
        /// causes include a mismatch of ciphers or protocols.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HealthyHostCount</code> </b> - The number of target instances that are
        /// considered healthy.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic are <code>Average</code>, <code>Minimum</code>,
        /// and <code>Maximum</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>UnhealthyHostCount</code> </b> - The number of target instances that are
        /// considered unhealthy.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic are <code>Average</code>, <code>Minimum</code>,
        /// and <code>Maximum</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_LB_4XX_Count</code> </b> - The number of HTTP 4XX client error
        /// codes that originate from the load balancer. Client errors are generated when requests
        /// are malformed or incomplete. These requests have not been received by the target instance.
        /// This count does not include any response codes generated by the target instances.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_LB_5XX_Count</code> </b> - The number of HTTP 5XX server error
        /// codes that originate from the load balancer. This count does not include any response
        /// codes generated by the target instances.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// Note that <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all
        /// return <code>1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_Instance_2XX_Count</code> </b> - The number of HTTP response codes
        /// generated by the target instances. This does not include any response codes generated
        /// by the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_Instance_3XX_Count</code> </b> - The number of HTTP response codes
        /// generated by the target instances. This does not include any response codes generated
        /// by the load balancer. 
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_Instance_4XX_Count</code> </b> - The number of HTTP response codes
        /// generated by the target instances. This does not include any response codes generated
        /// by the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>HTTPCode_Instance_5XX_Count</code> </b> - The number of HTTP response codes
        /// generated by the target instances. This does not include any response codes generated
        /// by the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>InstanceResponseTime</code> </b> - The time elapsed, in seconds, after
        /// the request leaves the load balancer until a response from the target instance is
        /// received.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Average</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>RejectedConnectionCount</code> </b> - The number of connections that were
        /// rejected because the load balancer had reached its maximum number of connections.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>RequestCount</code> </b> - The number of requests processed over IPv4.
        /// This count includes only the requests with a response generated by a target instance
        /// of the load balancer.
        /// </para>
        ///  
        /// <para>
        ///  <code>Statistics</code>: The most useful statistic is <code>Sum</code>. Note that
        /// <code>Minimum</code>, <code>Maximum</code>, and <code>Average</code> all return <code>1</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LoadBalancerMetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The time period duration for your health data request.
        /// </para>
        /// </summary>
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the period.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// An array of statistics that you want to request metrics for. Valid values are listed
        /// below.
        /// </para>
        /// </summary>
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the time period request. Valid values are listed below.
        /// </para>
        /// </summary>
        public MetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}