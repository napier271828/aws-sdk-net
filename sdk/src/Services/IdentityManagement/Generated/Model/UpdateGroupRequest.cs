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
    /// Container for the parameters to the UpdateGroup operation.
    /// Updates the name and/or the path of the specified IAM group.
    /// 
    ///  <important> 
    /// <para>
    ///  You should understand the implications of changing a group's path or name. For more
    /// information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html">Renaming
    /// Users and Groups</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// To change an IAM group name the requester must have appropriate permissions on both
    /// the source object and the target object. For example, to change "Managers" to "MGRs",
    /// the entity making the request must have permission on both "Managers" and "MGRs",
    /// or must have permission on all (*). For more information about permissions, see <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html">Permissions
    /// and Policies</a>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateGroupRequest : AmazonIdentityManagementServiceRequest
    {
        private string _groupName;
        private string _newGroupName;
        private string _newPath;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateGroupRequest() { }

        /// <summary>
        /// Instantiates UpdateGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">Name of the IAM group to update. If you're changing the name of the group, this is the original name. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: =,.@-</param>
        public UpdateGroupRequest(string groupName)
        {
            _groupName = groupName;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Name of the IAM group to update. If you're changing the name of the group, this is
        /// the original name.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: =,.@-
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property NewGroupName. 
        /// <para>
        /// New name for the IAM group. Only include this if changing the group's name.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: =,.@-
        /// </para>
        /// </summary>
        public string NewGroupName
        {
            get { return this._newGroupName; }
            set { this._newGroupName = value; }
        }

        // Check to see if NewGroupName property is set
        internal bool IsSetNewGroupName()
        {
            return this._newGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property NewPath. 
        /// <para>
        /// New path for the IAM group. Only include this if changing the group's path.
        /// </para>
        ///  
        /// <para>
        /// This paramater allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of either a forward slash (/) by itself or a string
        /// that must begin and end with forward slashes, containing any ASCII character from
        /// the ! (\u0021) thru the DEL character (\u007F), including most punctuation characters,
        /// digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        public string NewPath
        {
            get { return this._newPath; }
            set { this._newPath = value; }
        }

        // Check to see if NewPath property is set
        internal bool IsSetNewPath()
        {
            return this._newPath != null;
        }

    }
}