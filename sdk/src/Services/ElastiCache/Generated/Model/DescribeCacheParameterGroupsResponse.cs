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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the output of a <code>DescribeCacheParameterGroups</code> operation.
    /// </summary>
    public partial class DescribeCacheParameterGroupsResponse : AmazonWebServiceResponse
    {
        private List<CacheParameterGroup> _cacheParameterGroups = new List<CacheParameterGroup>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property CacheParameterGroups. 
        /// <para>
        /// A list of cache parameter groups. Each element in the list contains detailed information
        /// about one cache parameter group.
        /// </para>
        /// </summary>
        public List<CacheParameterGroup> CacheParameterGroups
        {
            get { return this._cacheParameterGroups; }
            set { this._cacheParameterGroups = value; }
        }

        // Check to see if CacheParameterGroups property is set
        internal bool IsSetCacheParameterGroups()
        {
            return this._cacheParameterGroups != null && this._cacheParameterGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Provides an identifier to allow retrieval of paginated results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}