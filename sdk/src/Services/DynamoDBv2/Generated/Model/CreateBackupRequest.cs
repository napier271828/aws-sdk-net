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
    /// Container for the parameters to the CreateBackup operation.
    /// Creates a backup for an existing table.
    /// 
    ///  
    /// <para>
    ///  Each time you create an On-Demand Backup, the entire table data is backed up. There
    /// is no limit to the number of on-demand backups that can be taken. 
    /// </para>
    ///  
    /// <para>
    /// You can call <code>CreateBackup</code> at a maximum rate of 50 times per second.
    /// </para>
    ///  
    /// <para>
    /// All backups in DynamoDB work without consuming any provisioned throughput on the table.
    /// This results in a fast, low-cost, and scalable backup process. In general, the larger
    /// the table, the more time it takes to back up. The backup is stored in an S3 data store
    /// that is maintained and managed by DynamoDB.
    /// </para>
    ///  
    /// <para>
    /// Backups incorporate all writes (delete, put, update) that were completed within the
    /// last minute before the backup request was initiated. Backups might include some writes
    /// (delete, put, update) that were completed before the backup request was finished.
    /// </para>
    ///  
    /// <para>
    ///  For example, if you submit the backup request on 2018-12-14 at 14:25:00, the backup
    /// is guaranteed to contain all data committed to the table up to 14:24:00, and data
    /// committed after 14:26:00 will not be. The backup may or may not contain data modifications
    /// made between 14:24:00 and 14:26:00. On-Demand Backup does not support causal consistency.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  Along with data, the following are also included on the backups: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Global secondary indexes (GSIs)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Local secondary indexes (LSIs)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Streams
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provisioned read and write capacity
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateBackupRequest : AmazonDynamoDBRequest
    {
        private string _backupName;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property BackupName. 
        /// <para>
        /// Specified name for the backup.
        /// </para>
        /// </summary>
        public string BackupName
        {
            get { return this._backupName; }
            set { this._backupName = value; }
        }

        // Check to see if BackupName property is set
        internal bool IsSetBackupName()
        {
            return this._backupName != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
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