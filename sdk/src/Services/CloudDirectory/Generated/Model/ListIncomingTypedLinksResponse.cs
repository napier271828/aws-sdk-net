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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// This is the response object from the ListIncomingTypedLinks operation.
    /// </summary>
    public partial class ListIncomingTypedLinksResponse : AmazonWebServiceResponse
    {
        private List<TypedLinkSpecifier> _linkSpecifiers = new List<TypedLinkSpecifier>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LinkSpecifiers. 
        /// <para>
        /// Returns one or more typed link specifiers as output.
        /// </para>
        /// </summary>
        public List<TypedLinkSpecifier> LinkSpecifiers
        {
            get { return this._linkSpecifiers; }
            set { this._linkSpecifiers = value; }
        }

        // Check to see if LinkSpecifiers property is set
        internal bool IsSetLinkSpecifiers()
        {
            return this._linkSpecifiers != null && this._linkSpecifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token.
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

    }
}