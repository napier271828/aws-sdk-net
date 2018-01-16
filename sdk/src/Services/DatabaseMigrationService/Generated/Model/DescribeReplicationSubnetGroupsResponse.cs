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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeReplicationSubnetGroupsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ReplicationSubnetGroup> _replicationSubnetGroups = new List<ReplicationSubnetGroup>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <code>MaxRecords</code>. 
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
        /// Gets and sets the property ReplicationSubnetGroups. 
        /// <para>
        /// A description of the replication subnet groups.
        /// </para>
        /// </summary>
        public List<ReplicationSubnetGroup> ReplicationSubnetGroups
        {
            get { return this._replicationSubnetGroups; }
            set { this._replicationSubnetGroups = value; }
        }

        // Check to see if ReplicationSubnetGroups property is set
        internal bool IsSetReplicationSubnetGroups()
        {
            return this._replicationSubnetGroups != null && this._replicationSubnetGroups.Count > 0; 
        }

    }
}