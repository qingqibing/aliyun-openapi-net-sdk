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
    public class DescribeDomainBpsDataResponseUnmarshaller
    {
        public static DescribeDomainBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainBpsDataResponse describeDomainBpsDataResponse = new DescribeDomainBpsDataResponse();

			describeDomainBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainBpsDataResponse.RequestId = context.StringValue("DescribeDomainBpsData.RequestId");
			describeDomainBpsDataResponse.DomainName = context.StringValue("DescribeDomainBpsData.DomainName");
			describeDomainBpsDataResponse.StartTime = context.StringValue("DescribeDomainBpsData.StartTime");
			describeDomainBpsDataResponse.EndTime = context.StringValue("DescribeDomainBpsData.EndTime");
			describeDomainBpsDataResponse.LocationNameEn = context.StringValue("DescribeDomainBpsData.LocationNameEn");
			describeDomainBpsDataResponse.IspNameEn = context.StringValue("DescribeDomainBpsData.IspNameEn");
			describeDomainBpsDataResponse.DataInterval = context.StringValue("DescribeDomainBpsData.DataInterval");

			List<DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule> describeDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule dataModule = new DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"]._Value");
				dataModule.DomesticValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].OverseasValue");
				dataModule.HttpsValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].HttpsValue");
				dataModule.HttpsDomesticValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].HttpsDomesticValue");
				dataModule.HttpsOverseasValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].HttpsOverseasValue");

				describeDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeDomainBpsDataResponse.BpsDataPerInterval = describeDomainBpsDataResponse_bpsDataPerInterval;
        
			return describeDomainBpsDataResponse;
        }
    }
}
