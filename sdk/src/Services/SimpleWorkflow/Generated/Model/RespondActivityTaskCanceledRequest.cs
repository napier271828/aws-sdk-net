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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the RespondActivityTaskCanceled operation.
    /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
    /// <code>taskToken</code> was successfully canceled. Additional <code>details</code>
    /// can be provided using the <code>details</code> argument.
    /// 
    ///  
    /// <para>
    /// These <code>details</code> (if provided) appear in the <code>ActivityTaskCanceled</code>
    /// event added to the workflow history.
    /// </para>
    ///  <important> 
    /// <para>
    /// Only use this operation if the <code>canceled</code> flag of a <a>RecordActivityTaskHeartbeat</a>
    /// request returns <code>true</code> and if the activity can be safely undone or abandoned.
    /// </para>
    ///  </important> 
    /// <para>
    /// A task is considered open from the time that it is scheduled until it is closed. Therefore
    /// a task is reported as open while a worker is processing it. A task is closed after
    /// it has been specified in a call to <a>RespondActivityTaskCompleted</a>, RespondActivityTaskCanceled,
    /// <a>RespondActivityTaskFailed</a>, or the task has <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
    /// out</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Access Control</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a <code>Resource</code> element with the domain name to limit the action to only
    /// specified domains.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an <code>Action</code> element to allow or deny permission to call this action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot use an IAM policy to constrain this action's parameters.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the caller doesn't have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <code>cause</code> parameter is set to <code>OPERATION_NOT_PERMITTED</code>.
    /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a> in the <i>Amazon SWF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RespondActivityTaskCanceledRequest : AmazonSimpleWorkflowRequest
    {
        private string _details;
        private string _taskToken;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        ///  Information about the cancellation.
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property TaskToken. 
        /// <para>
        /// The <code>taskToken</code> of the <a>ActivityTask</a>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <code>taskToken</code> is generated by the service and should be treated as an opaque
        /// value. If the task is passed to another process, its <code>taskToken</code> must also
        /// be passed. This enables it to provide its progress and respond with results.
        /// </para>
        ///  </important>
        /// </summary>
        public string TaskToken
        {
            get { return this._taskToken; }
            set { this._taskToken = value; }
        }

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this._taskToken != null;
        }

    }
}