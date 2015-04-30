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

using System;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// This exception is thrown when the dataset operation exceeds certain limit,
    /// e.g. maximum of 20 datasets per identity, 1024 records per dataset, and 1mb
    /// in size per dataset, etc.
    /// </summary>
    public class DataLimitExceededException : DataStorageException
    {
        public DataLimitExceededException()
            : base()
        {
        }

        public DataLimitExceededException(string detailMessage, Exception ex)
            : base(detailMessage, ex)
        {
        }

        public DataLimitExceededException(string detailMessage)
            : base(detailMessage)
        {
        }

        public DataLimitExceededException(Exception ex)
            : base(ex.Message, ex)
        {
        }
    }
}

