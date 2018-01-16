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
    /// Container for the parameters to the DescribeContinuousBackups operation.
    /// Checks the status of the backup restore settings on the specified table. If backups
    /// are enabled, <code>ContinuousBackupsStatus</code> will bet set to ENABLED.
    /// 
    ///  
    /// <para>
    /// You can call <code>DescribeContinuousBackups</code> at a maximum rate of 10 times
    /// per second.
    /// </para>
    /// </summary>
    public partial class DescribeContinuousBackupsRequest : AmazonDynamoDBRequest
    {
        private string _tableName;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Name of the table for which the customer wants to check the backup and restore settings.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}