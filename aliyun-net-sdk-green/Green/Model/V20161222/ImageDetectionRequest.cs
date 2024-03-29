/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20161222;

namespace Aliyun.Acs.Green.Model.V20161222
{
    public class ImageDetectionRequest : RoaAcsRequest<ImageDetectionResponse>
    {
        public ImageDetectionRequest()
            : base("Green", "2016-12-22", "ImageDetection", "green", "openAPI")
        {
			UriPattern = "/image/detection";
			Method = MethodType.POST;
        }

        public override ImageDetectionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImageDetectionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
