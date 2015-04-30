//
// Copyright 2014-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//
//
// Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
// You may not use this file except in compliance with the License.
// A copy of the License is located in the "license" file accompanying this file.
// See the License for the specific language governing permissions and limitations under the License.
//
//

/*
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Returned for a successful ListIdentityPoolUsage request.
    /// </summary>
    public partial class ListIdentityPoolUsageResponse : AmazonWebServiceResponse
    {
        private int? _count;
        private List<IdentityPoolUsage> _identityPoolUsages = new List<IdentityPoolUsage>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Count. Total number of identities for the identity pool.
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolUsages. Usage information for the identity
        /// pools.
        /// </summary>
        public List<IdentityPoolUsage> IdentityPoolUsages
        {
            get { return this._identityPoolUsages; }
            set { this._identityPoolUsages = value; }
        }

        // Check to see if IdentityPoolUsages property is set
        internal bool IsSetIdentityPoolUsages()
        {
            return this._identityPoolUsages != null && this._identityPoolUsages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of results to be returned.
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
        /// Gets and sets the property NextToken. A pagination token for obtaining the next page
        /// of results.
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