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
    /// Describes the certificate chain being used when code signing a file.
    /// </summary>
    public partial class CodeSigningCertificateChain
    {
        private string _certificateName;
        private string _inlineDocument;
        private Stream _stream;

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the certificate.
        /// </para>
        /// </summary>
        public string CertificateName
        {
            get { return this._certificateName; }
            set { this._certificateName = value; }
        }

        // Check to see if CertificateName property is set
        internal bool IsSetCertificateName()
        {
            return this._certificateName != null;
        }

        /// <summary>
        /// Gets and sets the property InlineDocument. 
        /// <para>
        /// A base64 encoded binary representation of the code signing certificate chain.
        /// </para>
        /// </summary>
        public string InlineDocument
        {
            get { return this._inlineDocument; }
            set { this._inlineDocument = value; }
        }

        // Check to see if InlineDocument property is set
        internal bool IsSetInlineDocument()
        {
            return this._inlineDocument != null;
        }

        /// <summary>
        /// Gets and sets the property Stream. 
        /// <para>
        /// A stream of the certificate chain files.
        /// </para>
        /// </summary>
        public Stream Stream
        {
            get { return this._stream; }
            set { this._stream = value; }
        }

        // Check to see if Stream property is set
        internal bool IsSetStream()
        {
            return this._stream != null;
        }

    }
}