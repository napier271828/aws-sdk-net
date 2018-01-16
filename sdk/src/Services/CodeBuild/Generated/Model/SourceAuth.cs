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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the authorization settings for AWS CodeBuild to access the source
    /// code to be built.
    /// 
    ///  
    /// <para>
    /// This information is for the AWS CodeBuild console's use only. Your code should not
    /// get or set this information directly (unless the build project's source <code>type</code>
    /// value is <code>BITBUCKET</code> or <code>GITHUB</code>).
    /// </para>
    /// </summary>
    public partial class SourceAuth
    {
        private string _resource;
        private SourceAuthType _type;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource value that applies to the specified authorization type.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The authorization type to use. The only valid value is <code>OAUTH</code>, which represents
        /// the OAuth authorization type.
        /// </para>
        /// </summary>
        public SourceAuthType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}