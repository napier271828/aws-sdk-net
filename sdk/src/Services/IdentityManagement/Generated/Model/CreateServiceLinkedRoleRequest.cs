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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceLinkedRole operation.
    /// Creates an IAM role that is linked to a specific AWS service. The service controls
    /// the attached policies and when the role can be deleted. This helps ensure that the
    /// service is not broken by an unexpectedly changed or deleted role, which could put
    /// your AWS resources into an unknown state. Allowing the service to control the role
    /// helps improve service stability and proper cleanup when a service and its role are
    /// no longer needed.
    /// 
    ///  
    /// <para>
    /// The name of the role is autogenerated by combining the string that you specify for
    /// the <code>AWSServiceName</code> parameter with the string that you specify for the
    /// <code>CustomSuffix</code> parameter. The resulting name must be unique in your account
    /// or the request fails.
    /// </para>
    ///  
    /// <para>
    /// To attach a policy to this service-linked role, you must make the request using the
    /// AWS service that depends on this role.
    /// </para>
    /// </summary>
    public partial class CreateServiceLinkedRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string _awsServiceName;
        private string _customSuffix;
        private string _description;

        /// <summary>
        /// Gets and sets the property AWSServiceName. 
        /// <para>
        /// The AWS service to which this role is attached. You use a string similar to a URL
        /// but without the http:// in front. For example: <code>elasticbeanstalk.amazonaws.com</code>
        /// 
        /// </para>
        /// </summary>
        public string AWSServiceName
        {
            get { return this._awsServiceName; }
            set { this._awsServiceName = value; }
        }

        // Check to see if AWSServiceName property is set
        internal bool IsSetAWSServiceName()
        {
            return this._awsServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSuffix. 
        /// <para>
        /// A string that you provide, which is combined with the service name to form the complete
        /// role name. If you make multiple requests for the same service, then you must supply
        /// a different <code>CustomSuffix</code> for each request. Otherwise the request fails
        /// with a duplicate role name error. For example, you could add <code>-1</code> or <code>-debug</code>
        /// to the suffix.
        /// </para>
        /// </summary>
        public string CustomSuffix
        {
            get { return this._customSuffix; }
            set { this._customSuffix = value; }
        }

        // Check to see if CustomSuffix property is set
        internal bool IsSetCustomSuffix()
        {
            return this._customSuffix != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the role.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}