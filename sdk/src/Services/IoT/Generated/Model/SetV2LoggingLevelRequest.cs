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
    /// Container for the parameters to the SetV2LoggingLevel operation.
    /// Sets the logging level.
    /// </summary>
    public partial class SetV2LoggingLevelRequest : AmazonIoTRequest
    {
        private LogLevel _logLevel;
        private LogTarget _logTarget;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The log level.
        /// </para>
        /// </summary>
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property LogTarget. 
        /// <para>
        /// The log target.
        /// </para>
        /// </summary>
        public LogTarget LogTarget
        {
            get { return this._logTarget; }
            set { this._logTarget = value; }
        }

        // Check to see if LogTarget property is set
        internal bool IsSetLogTarget()
        {
            return this._logTarget != null;
        }

    }
}