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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Returns the objects or data listed below if successful. Otherwise, returns an error.
    /// </summary>
    public partial class ListTagsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceTag> _resourceTagList = new List<ResourceTag>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Reserved for future use.
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
        /// Gets and sets the property ResourceTagList. 
        /// <para>
        /// A list of resource tags.
        /// </para>
        /// </summary>
        public List<ResourceTag> ResourceTagList
        {
            get { return this._resourceTagList; }
            set { this._resourceTagList = value; }
        }

        // Check to see if ResourceTagList property is set
        internal bool IsSetResourceTagList()
        {
            return this._resourceTagList != null && this._resourceTagList.Count > 0; 
        }

    }
}