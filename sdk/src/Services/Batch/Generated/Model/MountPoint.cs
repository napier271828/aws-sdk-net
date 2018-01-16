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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Details on a Docker volume mount point that is used in a job's container properties.
    /// </summary>
    public partial class MountPoint
    {
        private string _containerPath;
        private bool? _readOnly;
        private string _sourceVolume;

        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The path on the container at which to mount the host volume.
        /// </para>
        /// </summary>
        public string ContainerPath
        {
            get { return this._containerPath; }
            set { this._containerPath = value; }
        }

        // Check to see if ContainerPath property is set
        internal bool IsSetContainerPath()
        {
            return this._containerPath != null;
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// If this value is <code>true</code>, the container has read-only access to the volume;
        /// otherwise, the container can write to the volume. The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool ReadOnly
        {
            get { return this._readOnly.GetValueOrDefault(); }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceVolume. 
        /// <para>
        /// The name of the volume to mount.
        /// </para>
        /// </summary>
        public string SourceVolume
        {
            get { return this._sourceVolume; }
            set { this._sourceVolume = value; }
        }

        // Check to see if SourceVolume property is set
        internal bool IsSetSourceVolume()
        {
            return this._sourceVolume != null;
        }

    }
}