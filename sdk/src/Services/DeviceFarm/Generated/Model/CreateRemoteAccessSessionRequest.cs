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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRemoteAccessSession operation.
    /// Specifies and starts a remote access session.
    /// </summary>
    public partial class CreateRemoteAccessSessionRequest : AmazonDeviceFarmRequest
    {
        private string _clientId;
        private CreateRemoteAccessSessionConfiguration _configuration;
        private string _deviceArn;
        private string _name;
        private string _projectArn;
        private bool? _remoteDebugEnabled;
        private string _sshPublicKey;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// Unique identifier for the client. If you want access to multiple devices on the same
        /// client, you should pass the same <code>clientId</code> value in each call to <code>CreateRemoteAccessSession</code>.
        /// This is required only if <code>remoteDebugEnabled</code> is set to true <code>true</code>.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration information for the remote access session request.
        /// </para>
        /// </summary>
        public CreateRemoteAccessSessionConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device for which you want to create a remote
        /// access session.
        /// </para>
        /// </summary>
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the remote access session that you wish to create.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project for which you want to create a remote
        /// access session.
        /// </para>
        /// </summary>
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteDebugEnabled. 
        /// <para>
        /// Set to <code>true</code> if you want to access devices remotely for debugging in your
        /// remote access session.
        /// </para>
        /// </summary>
        public bool RemoteDebugEnabled
        {
            get { return this._remoteDebugEnabled.GetValueOrDefault(); }
            set { this._remoteDebugEnabled = value; }
        }

        // Check to see if RemoteDebugEnabled property is set
        internal bool IsSetRemoteDebugEnabled()
        {
            return this._remoteDebugEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SshPublicKey. 
        /// <para>
        /// The public key of the <code>ssh</code> key pair you want to use for connecting to
        /// remote devices in your remote debugging session. This is only required if <code>remoteDebugEnabled</code>
        /// is set to <code>true</code>.
        /// </para>
        /// </summary>
        public string SshPublicKey
        {
            get { return this._sshPublicKey; }
            set { this._sshPublicKey = value; }
        }

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this._sshPublicKey != null;
        }

    }
}