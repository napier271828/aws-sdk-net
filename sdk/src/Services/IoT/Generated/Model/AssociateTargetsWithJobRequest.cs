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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateTargetsWithJob operation.
    /// Associates a group with a continuous job. The following criteria must be met: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The job must have been created with the <code>targetSelection</code> field set to
    /// "CONTINUOUS".
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The job status must currently be "IN_PROGRESS".
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The total number of targets associated with a job must not exceed 100.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssociateTargetsWithJobRequest : AmazonIoTRequest
    {
        private string _comment;
        private string _jobId;
        private List<string> _targets = new List<string>();

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment string describing why the job was associated with the targets.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier you assigned to this job when it was created.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of thing group ARNs that define the targets of the job.
        /// </para>
        /// </summary>
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}