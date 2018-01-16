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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetDimensionValues operation.
    /// You can use <code>GetDimensionValues</code> to retrieve all available filter values
    /// for a specific filter over a period of time. You can search the dimension values for
    /// an arbitrary string.
    /// </summary>
    public partial class GetDimensionValuesRequest : AmazonCostExplorerRequest
    {
        private Context _context;
        private Dimension _dimension;
        private string _nextPageToken;
        private string _searchString;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The context for the call to <code>GetDimensionValues</code>. This can be <code>RESERVED_INSTANCE</code>
        /// or <code>COST_AND_USAGE</code>. The default value is <code>COST_AND_USAGE</code>.
        /// If the context is set to <code>RESERVED_INSTANCE</code>, the resulting dimension values
        /// can be used in the <code>GetReservationUtilization</code> action. If the context is
        /// set to <code>COST_AND_USAGE</code>, , the resulting dimension values can be used in
        /// the <code>GetCostAndUsage</code> operation.
        /// </para>
        ///  
        /// <para>
        /// If you set the context to <code>CostAndUsage</code>, you can use the following dimensions
        /// for searching:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AZ - The Availability Zone. An example is us-east-1a.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InstanceType - The type of EC2 instance. An example is m4.xlarge.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LinkedAccount - The description in the attribute map that includes the full name of
        /// the member account. The value field contains the AWS ID of the member account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Operation - The action performed. Examples include RunInstance and CreateBucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PurchaseType - The reservation type of the purchase to which this usage is related.
        /// Examples include: On Demand Instances and Standard Reserved Instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service - The AWS service such as DynamoDB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UsageType -The type of usage. An example is DataTransfer-In-Bytes. The response for
        /// the GetDimensionValues action includes a unit attribute, examples of which include
        /// GB and Hrs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UsageTypeGroup - The grouping of common usage types. An example is EC2: CloudWatch
        /// – Alarms. The response for this action includes a unit attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RecordType - The different types of charges such as RI fees, usage costs, tax refunds,
        /// and credits
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set the context to <code>ReservedInstance</code>, you can use the following
        /// dimensions for searching:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AZ - The Availability Zone. An example is us-east-1a.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InstanceType - The type of EC2 instance. An example is m4.xlarge.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LinkedAccount - The description in the attribute map that includes the full name of
        /// the member account. The value field contains the AWS ID of the member account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Platform - The operating system. Examples are Windows or Linux.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Region - The AWS region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scope - The scope of a reserved instance (RI). Values are regional or a single availability
        /// zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy - The tenancy of a resource. Examples are shared or dedicated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Context Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The name of the dimension. Different <code>Dimensions</code>are available for different
        /// <code>Context</code>s. For more information, see <code>Context</code>.
        /// </para>
        /// </summary>
        public Dimension Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. AWS provides the token when the response
        /// from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property SearchString. 
        /// <para>
        /// The value that you want to search the filter values for.
        /// </para>
        /// </summary>
        public string SearchString
        {
            get { return this._searchString; }
            set { this._searchString = value; }
        }

        // Check to see if SearchString property is set
        internal bool IsSetSearchString()
        {
            return this._searchString != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The start and end dates for retrieving the dimension values. The start date is inclusive,
        /// but the end date is exclusive. For example, if <code>start</code> is <code>2017-01-01</code>
        /// and <code>end</code> is <code>2017-05-01</code>, then the cost and usage data is retrieved
        /// from <code>2017-01-01</code> up to and including <code>2017-04-30</code> but not including
        /// <code>2017-05-01</code>.
        /// </para>
        /// </summary>
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}