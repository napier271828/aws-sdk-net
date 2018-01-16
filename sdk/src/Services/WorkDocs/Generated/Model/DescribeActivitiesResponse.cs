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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// This is the response object from the DescribeActivities operation.
    /// </summary>
    public partial class DescribeActivitiesResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<Activity> _userActivities = new List<Activity>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property UserActivities. 
        /// <para>
        /// The list of activities for the specified user and time period.
        /// </para>
        /// </summary>
        public List<Activity> UserActivities
        {
            get { return this._userActivities; }
            set { this._userActivities = value; }
        }

        // Check to see if UserActivities property is set
        internal bool IsSetUserActivities()
        {
            return this._userActivities != null && this._userActivities.Count > 0; 
        }

    }
}