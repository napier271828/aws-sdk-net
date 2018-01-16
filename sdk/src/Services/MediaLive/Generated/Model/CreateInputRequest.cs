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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInput operation.
    /// Create an input
    /// </summary>
    public partial class CreateInputRequest : AmazonMediaLiveRequest
    {
        private List<InputDestinationRequest> _destinations = new List<InputDestinationRequest>();
        private List<string> _inputSecurityGroups = new List<string>();
        private string _name;
        private string _requestId;
        private List<InputSourceRequest> _sources = new List<InputSourceRequest>();
        private InputType _type;

        /// <summary>
        /// Gets and sets the property Destinations. settings required for PUSH-type inputs; one
        /// per redundancy group.Only one of sources and destinations can be specified.Note: there
        /// are currently no settings required for PUSH-type inputs
        /// </summary>
        public List<InputDestinationRequest> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputSecurityGroups. A list of security groups referenced
        /// by IDs to attach to the input.
        /// </summary>
        public List<string> InputSecurityGroups
        {
            get { return this._inputSecurityGroups; }
            set { this._inputSecurityGroups = value; }
        }

        // Check to see if InputSecurityGroups property is set
        internal bool IsSetInputSecurityGroups()
        {
            return this._inputSecurityGroups != null && this._inputSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. Name of the input.
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
        /// Gets and sets the property RequestId. Unique identifier of the request to ensure the
        /// request is handledexactly once in case of retries
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. settings required for PULL-type inputs; one per
        /// redundancy groupOnly one of sources and destinations can be specified
        /// </summary>
        public List<InputSourceRequest> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public InputType Type
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