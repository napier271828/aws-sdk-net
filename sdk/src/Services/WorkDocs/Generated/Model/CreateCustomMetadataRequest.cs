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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomMetadata operation.
    /// Adds one or more custom properties to the specified resource (a folder, document,
    /// or version).
    /// </summary>
    public partial class CreateCustomMetadataRequest : AmazonWorkDocsRequest
    {
        private string _authenticationToken;
        private Dictionary<string, string> _customMetadata = new Dictionary<string, string>();
        private string _resourceId;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Do not set this field when using administrative
        /// API actions, as in accessing the API using AWS credentials.
        /// </para>
        /// </summary>
        public string AuthenticationToken
        {
            get { return this._authenticationToken; }
            set { this._authenticationToken = value; }
        }

        // Check to see if AuthenticationToken property is set
        internal bool IsSetAuthenticationToken()
        {
            return this._authenticationToken != null;
        }

        /// <summary>
        /// Gets and sets the property CustomMetadata. 
        /// <para>
        /// Custom metadata in the form of name-value pairs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> CustomMetadata
        {
            get { return this._customMetadata; }
            set { this._customMetadata = value; }
        }

        // Check to see if CustomMetadata property is set
        internal bool IsSetCustomMetadata()
        {
            return this._customMetadata != null && this._customMetadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of the version, if the custom metadata is being added to a document version.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}