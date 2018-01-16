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
    /// This is the response object from the RestoreTableFromBackup operation.
    /// </summary>
    public partial class RestoreTableFromBackupResponse : AmazonWebServiceResponse
    {
        private TableDescription _tableDescription;

        /// <summary>
        /// Gets and sets the property TableDescription. 
        /// <para>
        /// The description of the table created from an existing backup.
        /// </para>
        /// </summary>
        public TableDescription TableDescription
        {
            get { return this._tableDescription; }
            set { this._tableDescription = value; }
        }

        // Check to see if TableDescription property is set
        internal bool IsSetTableDescription()
        {
            return this._tableDescription != null;
        }

    }
}