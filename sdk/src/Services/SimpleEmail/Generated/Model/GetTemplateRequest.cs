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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the GetTemplate operation.
    /// Displays the template object (which includes the Subject line, HTML part and text
    /// part) for the template you specify.
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class GetTemplateRequest : AmazonSimpleEmailServiceRequest
    {
        private string _templateName;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the template you want to retrieve.
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}