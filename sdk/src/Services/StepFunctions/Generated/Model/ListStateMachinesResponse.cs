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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the ListStateMachines operation.
    /// </summary>
    public partial class ListStateMachinesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StateMachineListItem> _stateMachines = new List<StateMachineListItem>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a <code>nextToken</code> is returned by a previous call, there are more results
        /// available. To retrieve the next page of results, make the call again using the returned
        /// token in <code>nextToken</code>. Keep all other arguments unchanged.
        /// </para>
        ///  
        /// <para>
        /// The configured <code>maxResults</code> determines how many results can be returned
        /// in a single call.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StateMachines.
        /// </summary>
        public List<StateMachineListItem> StateMachines
        {
            get { return this._stateMachines; }
            set { this._stateMachines = value; }
        }

        // Check to see if StateMachines property is set
        internal bool IsSetStateMachines()
        {
            return this._stateMachines != null && this._stateMachines.Count > 0; 
        }

    }
}