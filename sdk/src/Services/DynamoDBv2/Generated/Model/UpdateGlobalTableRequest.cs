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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGlobalTable operation.
    /// Adds or removes replicas to the specified global table. The global table should already
    /// exist to be able to use this operation. Currently, the replica to be added should
    /// be empty.
    /// </summary>
    public partial class UpdateGlobalTableRequest : AmazonDynamoDBRequest
    {
        private string _globalTableName;
        private List<ReplicaUpdate> _replicaUpdates = new List<ReplicaUpdate>();

        /// <summary>
        /// Gets and sets the property GlobalTableName. 
        /// <para>
        /// The global table name.
        /// </para>
        /// </summary>
        public string GlobalTableName
        {
            get { return this._globalTableName; }
            set { this._globalTableName = value; }
        }

        // Check to see if GlobalTableName property is set
        internal bool IsSetGlobalTableName()
        {
            return this._globalTableName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaUpdates. 
        /// <para>
        /// A list of regions that should be added or removed from the global table.
        /// </para>
        /// </summary>
        public List<ReplicaUpdate> ReplicaUpdates
        {
            get { return this._replicaUpdates; }
            set { this._replicaUpdates = value; }
        }

        // Check to see if ReplicaUpdates property is set
        internal bool IsSetReplicaUpdates()
        {
            return this._replicaUpdates != null && this._replicaUpdates.Count > 0; 
        }

    }
}