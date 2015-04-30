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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecordPatch Marshaller
    /// </summary>       
    public class RecordPatchMarshaller : IRequestMarshaller<RecordPatch, JsonMarshallerContext> 
    {
        public void Marshall(RecordPatch requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeviceLastModifiedDate())
            {
                context.Writer.WritePropertyName("DeviceLastModifiedDate");
                context.Writer.Write(requestObject.DeviceLastModifiedDate);
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("Key");
                context.Writer.Write(requestObject.Key);
            }

            if(requestObject.IsSetOp())
            {
                context.Writer.WritePropertyName("Op");
                context.Writer.Write(requestObject.Op);
            }

            if(requestObject.IsSetSyncCount())
            {
                context.Writer.WritePropertyName("SyncCount");
                context.Writer.Write(requestObject.SyncCount);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.Write(requestObject.Value);
            }

        }

        public readonly static RecordPatchMarshaller Instance = new RecordPatchMarshaller();

    }
}