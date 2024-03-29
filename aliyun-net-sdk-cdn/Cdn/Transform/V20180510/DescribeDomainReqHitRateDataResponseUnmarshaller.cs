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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainReqHitRateDataResponseUnmarshaller
    {
        public static DescribeDomainReqHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainReqHitRateDataResponse describeDomainReqHitRateDataResponse = new DescribeDomainReqHitRateDataResponse();

			describeDomainReqHitRateDataResponse.HttpResponse = context.HttpResponse;
			describeDomainReqHitRateDataResponse.RequestId = context.StringValue("DescribeDomainReqHitRateData.RequestId");
			describeDomainReqHitRateDataResponse.DomainName = context.StringValue("DescribeDomainReqHitRateData.DomainName");
			describeDomainReqHitRateDataResponse.DataInterval = context.StringValue("DescribeDomainReqHitRateData.DataInterval");
			describeDomainReqHitRateDataResponse.StartTime = context.StringValue("DescribeDomainReqHitRateData.StartTime");
			describeDomainReqHitRateDataResponse.EndTime = context.StringValue("DescribeDomainReqHitRateData.EndTime");

			List<DescribeDomainReqHitRateDataResponse.DescribeDomainReqHitRateData_DataModule> describeDomainReqHitRateDataResponse_reqHitRateInterval = new List<DescribeDomainReqHitRateDataResponse.DescribeDomainReqHitRateData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainReqHitRateData.ReqHitRateInterval.Length"); i++) {
				DescribeDomainReqHitRateDataResponse.DescribeDomainReqHitRateData_DataModule dataModule = new DescribeDomainReqHitRateDataResponse.DescribeDomainReqHitRateData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainReqHitRateData.ReqHitRateInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainReqHitRateData.ReqHitRateInterval["+ i +"]._Value");
				dataModule.HttpsValue = context.StringValue("DescribeDomainReqHitRateData.ReqHitRateInterval["+ i +"].HttpsValue");

				describeDomainReqHitRateDataResponse_reqHitRateInterval.Add(dataModule);
			}
			describeDomainReqHitRateDataResponse.ReqHitRateInterval = describeDomainReqHitRateDataResponse_reqHitRateInterval;
        
			return describeDomainReqHitRateDataResponse;
        }
    }
}
