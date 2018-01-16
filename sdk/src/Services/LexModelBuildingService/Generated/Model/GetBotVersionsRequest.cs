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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetBotVersions operation.
    /// Gets information about all of the versions of a bot.
    /// 
    ///  
    /// <para>
    /// The <code>GetBotVersions</code> operation returns a <code>BotMetadata</code> object
    /// for each version of a bot. For example, if a bot has three numbered versions, the
    /// <code>GetBotVersions</code> operation returns four <code>BotMetadata</code> objects
    /// in the response, one for each numbered version and one for the <code>$LATEST</code>
    /// version. 
    /// </para>
    ///  
    /// <para>
    /// The <code>GetBotVersions</code> operation always returns at least one version, the
    /// <code>$LATEST</code> version.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <code>lex:GetBotVersions</code> action.
    /// </para>
    /// </summary>
    public partial class GetBotVersionsRequest : AmazonLexModelBuildingServiceRequest
    {
        private int? _maxResults;
        private string _name;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of bot versions to return in the response. The default is 10.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bot for which versions should be returned.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for fetching the next page of bot versions. If the response to
        /// this call is truncated, Amazon Lex returns a pagination token in the response. To
        /// fetch the next page of versions, specify the pagination token in the next request.
        /// 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}